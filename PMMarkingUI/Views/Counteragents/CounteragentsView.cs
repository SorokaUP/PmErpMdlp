using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using DevExpress.XtraGrid.Columns;

namespace PMMarkingUI.Views
{
    public partial class CounteragentsView : UserControl
    {
        public event DelegateAddPage dAddPage;
        Sys.SelectRow sysRow = new Sys.SelectRow();
        int IndexColID;
        int IndexColNAME;
        public CounteragentsView(DelegateAddPage ntp)
        {
            InitializeComponent();
            this.Text = "Список контрагентов";
            dAddPage = ntp;
            // Подписка на событие изменения
            ricbxBool.EditValueChanged += Sys.Data.ImmediatePost;
            Refresh_Counteragents();
            Sys.GridColumns.CreateFormatRules(vCounteragents, "IsError", "INN", "(Len([INN]) != 10) And (Len([INN]) != 12)", false);
            gridFilterView.SetGridView(vCounteragents);
            vCounteragents.SetDefaultGridViewOptions();

            // Список папок контрагентов
            IndexColID = tlFolders.Columns["tlcID"].AbsoluteIndex;
            IndexColNAME = tlFolders.Columns["tlcNAME"].AbsoluteIndex;
            Refresh_Folders();
        }
        /// <summary>
        /// Обновить список контрагентов
        /// </summary>
        private void Refresh_Counteragents()
        {
            cCounteragents.DataSource = DAO.GetTW_Counteragents();
        }
        /// <summary>
        /// Открыть карточку контрагента
        /// </summary>
        private void OpenCounteragentCard()
        {
            try
            {
                DataRow row = vCounteragents.GetDataSourceRow();
                dAddPage(new CounteragentView((int)row["ID"], "TW4"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Обновить список папок
        /// </summary>
        private void Refresh_Folders()
        {
            DataTable Folders = DAO.GetCounteragentsTW4Parents();
            tlFolders.CreateGroupFolders(Folders, 4000);
        }

        #region ПАПКИ контрагентов
        private void tlFolders_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            string FieldName = "PARENT_LID";
            if (e.Clicks == 2)
            {
                int PARENT_LID = 0;
                try
                {
                    PARENT_LID = (int)e.Node.GetValue(IndexColID);
                    if (PARENT_LID == 0)
                    {
                        vCounteragents.Columns[FieldName].FilterInfo = new ColumnFilterInfo();
                        return;
                    }

                    vCounteragents.Columns[FieldName].FilterInfo =
                        new ColumnFilterInfo($"[{FieldName}] LIKE '{PARENT_LID}'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                    vCounteragents.Columns[FieldName].FilterInfo = new ColumnFilterInfo();
                }
            }
        }
        #endregion
        #region Выделение
        /// <summary>
        /// Выбрать всех контрагентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll(object sender, EventArgs e)
        {
            cCounteragents.GridSelectAll("HANDLE_SELECT", 1);
        }
        /// <summary>
        /// Снять выделение со всех контрагентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnselectAll(object sender, EventArgs e)
        {
            cCounteragents.GridSelectAll("HANDLE_SELECT", 0);
        }
        /// <summary>
        /// Выделить всех контрагентов не являющихся доверенными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllNonVerify(object sender, EventArgs e)
        {
            DataTable data = cCounteragents.DataSource as DataTable;

            if (data == null)
                return;
            UnselectAll(sender, e);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    data.Rows[i]["HANDLE_SELECT"] = ((int)data.Rows[i]["IS_VERIFY"] == 1) ? 0 : 1;
                }
            }
        }
        /// <summary>
        /// Выделить всех доверенных контрагентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllVerify(object sender, EventArgs e)
        {
            DataTable data = cCounteragents.DataSource as DataTable;

            if (data == null)
                return;
            UnselectAll(sender, e);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    data.Rows[i]["HANDLE_SELECT"] = ((int)data.Rows[i]["IS_VERIFY"] == 1) ? 1 : 0;
                }
            }
        }
        #endregion
        #region Фильтры
        /// <summary>
        /// Показать только доверенных
        /// </summary>
        /// <param name="sender"></param>
        private void FilterVerify(object sender, int mode)
        {
            string FieldName = "IS_VERIFY";
            try
            {
                vCounteragents.Columns[FieldName].FilterInfo =
                    new ColumnFilterInfo($"[{FieldName}] = {mode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                vCounteragents.Columns[FieldName].FilterInfo = new ColumnFilterInfo();
            }
        }
        /// <summary>
        /// Показать только с ошибками
        /// </summary>
        private void FilterCounteragentsError()
        {
            string FieldName = "INN";
            try
            {
                vCounteragents.Columns[FieldName].FilterInfo =
                    new ColumnFilterInfo($"Len([{FieldName}]) != 10 and Len([{FieldName}]) != 12");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                vCounteragents.Columns[FieldName].FilterInfo = new ColumnFilterInfo();
            }
        }
        /// <summary>
        /// Очистить фильтры
        /// </summary>
        private void FilterClear()
        {
            if (MessageBox.Show("Очистить все фильтры?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            foreach (GridColumn col in vCounteragents.Columns)
            {
                col.FilterInfo = new ColumnFilterInfo();
            }
        }
        #endregion
        #region Функции
        /// <summary>
        /// Синхронизация контрагентов с ТВ4
        /// </summary>
        private void SyncCounteragentsWithTW4()
        {
            bool res = Additional.CounteragentsSyncWithTW4(this, true);
            if (res)
            {
                Refresh_Counteragents();
            }
        }
        /// <summary>
        /// Синхронизация адресов контрагентов с ТВ4 (по всем / выбранным)
        /// </summary>
        /// <param name="isNeedHandleSelect"></param>
        private void SyncAddressesWithTW4(bool isNeedHandleSelect)
        {
            string question = (isNeedHandleSelect) 
                ? "Получить информацию по адресам ПОМЕЧЕННЫХ контрагентов?"
                : "Получить информацию по адресам ВСЕХ контрагентов?";
            if (MessageBox.Show(question + " Это может занять много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<string> inns = new List<string>();
            if (isNeedHandleSelect)
            {
                inns = GetInns(isNeedHandleSelect);
                if (inns.Count == 0)
                {
                    MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\"");
                    return;
                }
            }

            bool isExist = Additional.CounteragentsAddressesSyncWithTW4(this, inns, false, true);
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Связать контрагентов ТВ4 и МДЛП по запросу SysId из МДЛП
        /// </summary>
        /// <param name="isNeedHandleSelect">Брать только выделенных</param>
        private void LinkedCounteragentsByMdlp(bool isNeedHandleSelect)
        {
            if (MessageBox.Show("Будут обновлены все связки контрагентов. Условие поиска - ИНН. Вручную созданные привязки могут быть утеряны! Операция может занять много времени! Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<LidInnSysid> data = GetSelected(isNeedHandleSelect);
            List<string> inns = new List<string>();
            for (int i = data.Count - 1; i >= 0; i--)
            {
                if (!Additional.CheckInn(data[i].inn))
                    data.RemoveAt(i);
                else
                {
                    if (!inns.Contains(data[i].inn))
                        inns.Add(data[i].inn);
                }
            }            
            if (data.Count == 0)
            {
                MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\". Либо выбранные Вами контрагенты имеют не верный ИНН!");
                return;
            }

            bool isNeedSleep = false;
            bool isExist = false;
            // По списку уникальных ИНН
            using (frmProccess p = new frmProccess())
            {
                p.progressBarControl.Properties.Maximum = inns.Count;
                foreach (string inn in inns)
                {
                    // Получаем из МДЛП sys_id контрагента
                    string sys_id = WebMethods.GetCounteragentSysId(this, false, inn, false);
                    foreach (LidInnSysid d in data)
                    {
                        // Связываем по ИНН (всем ИНН проставляем полученный SysId)
                        if (d.inn == inn)
                        {
                            bool res = Additional.CounteragentsSetLinks(d.lid, sys_id);
                            isExist = true;
                        }
                    }
                    if (isNeedSleep)
                        System.Threading.Thread.Sleep(500);
                    else
                        isNeedSleep = true;

                    p.progressBarControl.Position++;
                }

                MessageBox.Show((isExist ? "Информация получена, список данных будет обновлен." : "Контрагентов для связки в МДЛП не найдено."));
                p.Close();
                if (isExist)
                    Refresh_Counteragents();
            }
        }
        /// <summary>
        /// Связать контрагентов ТВ4 и МДЛП по запросу SysId вручную
        /// </summary>
        private void LinkedCounteragentsByHandle()
        {
            try
            {
                // Передать ID или LID на форму, в которой добавить текстовое поле
                DataRow row = vCounteragents.GetDataSourceRow();
                if (row == null)
                {
                    MessageBox.Show("Не выбран контрагент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                frmCounteragentsLinks frm = new frmCounteragentsLinks(Convert.ToInt32(row["ID"]), row["SYS_ID"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Выполнено, список данных будет обновлен.");
                    Refresh_Counteragents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        /// <summary>
        /// Связать контрагентов ТВ4 и МДЛП по запросу SysId автоматически по ИНН
        /// </summary>
        private void LinkedCounteragentsByInn()
        {
            if (MessageBox.Show("Выполнить связку контрагентов автоматически по ИНН? Это может удалить вручную созданные привязки!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                DAO.SetCounteragentsLinks();
        }
        /// <summary>
        /// Удалить связку контрагентов ТВ4 и МДЛП
        /// </summary>
        private void DeleteCounteragentsLinks()
        {
            try
            {
                DataRow row = vCounteragents.GetDataSourceRow();
                if (MessageBox.Show($"Удалить привязку у {row["NAME"].ToString()}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                bool res = Additional.CounteragentsTWDelLink(Convert.ToInt32(row["LID"]));
                if (res)
                {
                    MessageBox.Show("Выполнено. Список данных будет обновлен.");
                    Refresh_Counteragents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Связать адреса контрагентов МДЛП с ТВ4
        /// </summary>
        private void LinkedCounteragentsAddresses(bool isOnlyHandleSelect)
        {
            if (MessageBox.Show("Будут обновлены все связки вдресов контрагентов. Операция может занять много времени! Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                if (isOnlyHandleSelect)
                {
                    List<LidInnSysid> lids = GetSelected(true);
                    foreach (LidInnSysid item in lids)
                    {
                        DAO.LinkedAddressesTW4WithMDLP(item.lid, "");
                    }
                }
                else
                {
                    DAO.LinkedAddressesTW4WithMDLP(0, "");
                }
                MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Получение ФИАС по адресам контрагента
        /// </summary>
        /// <param name="lid">0 = ВСЕ | по конкретному</param>
        private void GetFiasAddressesTW4(bool isAll = false)
        {
            string question = (isAll) ? "ВСЕХ" : "ПОМЕЧЕННЫХ";
            if (MessageBox.Show($"Получить информацию по адресам {question} контрагентов? Это может занять много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            bool isExist = false;
            if (!isAll)
            {
                List<LidInnSysid> data = GetSelected(true);
                foreach (LidInnSysid item in data)
                {
                    if (isExist)
                        System.Threading.Thread.Sleep(500);

                    if (item.lid > 0)
                    {
                        Additional.GetFiasAhunter(this, item.lid, false);
                        isExist = true;
                    }
                }
            }            
            else
            {
                Additional.GetFiasAhunter(this, 0, true);
            }

            if (isExist)
            {
                MessageBox.Show("Информация получена.");
            }
        }
        /// <summary>
        /// Получить информацию по адресам контрагентов из- МДЛП
        /// </summary>
        private void GetAddressesFromMdlpByInn()
        {
            List<LidInnSysid> lids = GetSelected(true);
            if (lids.Count == 0)
            {
                MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\"");
                return;
            }
            List<string> inns = new List<string>();
            foreach (var item in lids)
            {
                if (!inns.Contains(item.inn))
                    inns.Add(item.inn);
            }

            // Получаем информацию о контрагенте по ИНН
            foreach (string inn in inns)
            {
                bool isExist = WebMethods.GetCounteragentInfoByInn(this, true, inn, false);
            }
            MessageBox.Show("Выполнено");
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Возвращает список уникальных ИНН по контрагентам, которые соответствуют маске ИНН
        /// </summary>
        /// <param name="isOnlyHandleSelect">Брать только выбранных</param>
        /// <returns></returns>
        private List<string> GetInns(bool isOnlyHandleSelect)
        {
            List<string> inns = new List<string>();
            foreach (DataRow row in (cCounteragents.DataSource as DataTable).Rows)
            {
                try
                {
                    if ((isOnlyHandleSelect && Convert.ToInt32(row["HANDLE_SELECT"]) == 1) || !isOnlyHandleSelect)
                    {
                        string inn = row["INN"].ToString();
                        if (Additional.CheckInn(inn))
                        {
                            if (!inns.ToArray().Contains(inn))
                                inns.Add(inn);
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
            return inns;
        }
        /// <summary>
        /// Возвращает список уникальных данных (Lid, INN, SysId) по всем выбранным контрагентам
        /// </summary>
        /// <returns></returns>
        private List<LidInnSysid> GetSelected(bool isOnlyHandleSelect)
        {
            List<LidInnSysid> lids = new List<LidInnSysid>();
            foreach (DataRow row in (cCounteragents.DataSource as DataTable).Rows)
            {
                if ((isOnlyHandleSelect && Convert.ToInt32(row["HANDLE_SELECT"]) == 1) || !isOnlyHandleSelect)
                {
                    try
                    {
                        LidInnSysid item = new LidInnSysid();
                        item.lid = (int)row["LID"];
                        item.inn = row["INN"].ToString();
                        item.sys_id = row["SYS_ID"].ToString();
                        if (!lids.Contains(item))
                            lids.Add(item);
                    }
                    catch (Exception ex)
                    { }
                }
            }
            return lids;
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Отправить контрагентов в доверенные / убрать из доверенных (помеченных или всех)
        /// </summary>
        /// <param name="mode">add | del</param>
        /// <param name="isNeedHandleSelect">Брать только выделенных</param>
        private void ToVerify(string mode, bool isNeedHandleSelect)
        {
            List<string> inns = new List<string>();
            if (mode != "info")
            {
                inns = GetInns(isNeedHandleSelect);
                if (inns.Count == 0)
                {
                    MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\"");
                    return;
                }
            }

            bool res = WebMethods.CounteragentsToVerify(mode, inns, this, true);
            if (res)
            {
                MessageBox.Show("Информация получена, список данных будет обновлен.");
                Refresh_Counteragents();
            }
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Синхронизировать рег. номера МДЛП на карточке помеченных контрагентов (SYS_ID)
        /// </summary>
        /// <param name="isOnlyHandleSelect">Брать только помеченных</param>
        private void SetSystemSubjId(bool isOnlyHandleSelect)
        {
            string question = (isOnlyHandleSelect)
                ? "Синхронизировать рег. номера МДЛП на карточке ПОМЕЧЕННЫХ контрагентов (SYS_ID)?"
                : "Синхронизировать рег. номера МДЛП на карточке ВСЕХ контрагентов (SYS_ID)?";
            if (MessageBox.Show(question + " Это может занять много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<LidInnSysid> lids = new List<LidInnSysid>();
            if (isOnlyHandleSelect)
            {
                GetSelected(true);
                if (lids.Count == 0)
                {
                    MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\"");
                    return;
                }
            }
                
            bool isExist = Additional.CounteragentsLinkToTw4(this, lids);
        }
        /// <summary>
        /// Синхронизировать идентификаторы адресов МДЛП на карточке помеченных контрагентов (BRANCH_ID)
        /// </summary>
        /// <param name="isOnlyHandleSelect">Брать только помеченных</param>
        private void SetBranchIdAddresses_TW4(bool isOnlyHandleSelect)
        {
            string question = (isOnlyHandleSelect)
                ? "Синхронизировать идентификаторы адресов МДЛП на карточке ПОМЕЧЕННЫХ контрагентов (BRANCH_ID)?"
                : "Синхронизировать идентификаторы адресов МДЛП на карточке ВСЕХ контрагентов (BRANCH_ID)?";
            if (MessageBox.Show(question + " Это может занять много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<LidInnSysid> lids = new List<LidInnSysid>();
            if (isOnlyHandleSelect)
            {
                GetSelected(true);
                if (lids.Count == 0)
                {
                    MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\"");
                    return;
                }
            }

            bool isExist = Additional.AddressesBranchIdLinkToTw4(this, lids);
        }
        /// <summary>
        /// Синхронизировать FIAS с TW4
        /// </summary>
        /// <param name="isOnlyHandleSelect">Брать только помеченных</param>
        private void SetFias_TW4(bool isOnlyHandleSelect)
        {
            string question = (isOnlyHandleSelect)
                ? "Синхронизировать базу ФИАС ПОМЕЧЕННЫХ контрагентов?"
                : "Синхронизировать базу ФИАС ВСЕХ контрагентов?";
            if (MessageBox.Show(question + " Это может занять много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<LidInnSysid> lids = new List<LidInnSysid>();
            if (isOnlyHandleSelect)
            {
                GetSelected(true);
                if (lids.Count == 0)
                {
                    MessageBox.Show("Для продолжения, необходимо поставить пометку на контрагента(-ов) в поле \"Выбрать\"");
                    return;
                }
            }

            bool isExist = Additional.FiasToTw4(this, lids, false);
        }
        #endregion

        //=======================================================================================================================

        #region Пункты меню и действия
        private void обновитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh_Counteragents();
        }
        private void синхронизироватьСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncCounteragentsWithTW4();
        }
        private void актуализироватьСвязкиКонтрагентовНаОсновеИННToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedCounteragentsByMdlp(true);
        }
        private void ручнаяПривязкаКонтрагентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedCounteragentsByHandle();
        }
        private void удалитьПривязкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCounteragentsLinks();
        }
        private void добавитьВДоверенныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToVerify("add", true);
        }
        private void убратьИзДоверенныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToVerify("del", true);
        }
        private void показатьТолькоДоверенныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterVerify(sender, 1);
        }
        private void карточкаКонтрагентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCounteragentCard();
        }
        private void синхронизироватьАдресаСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncAddressesWithTW4(true);
        }
        private void показатьТолькоКонтрагентовСОшибкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterCounteragentsError();
        }
        private void показатьТолькоНеДоверенныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterVerify(sender, 0);
        }
        private void очиститьФильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterClear();
        }
        private void синхронизироватьКонтрагентовСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncCounteragentsWithTW4();
        }
        private void синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncAddressesWithTW4(false);
        }
        private void связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedCounteragentsByMdlp(false);
        }
        private void получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFiasAddressesTW4(true);
        }
        private void получитьДетальнуюИнформациюПоАдресамПомеченныхКонтрагентовTW4ФИАСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFiasAddressesTW4(false);
        }
        private void связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedCounteragentsAddresses(false);
        }
        private void добавитьКонтрагентовВДоверенныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToVerify("add", false);
        }
        private void tsmiAction_SetSystemSubjId_TW4_Click(object sender, EventArgs e)
        {
            SetSystemSubjId(true);
        }
        private void tsmiAction_SetBranchIdAddresses_TW4_Click(object sender, EventArgs e)
        {
            SetBranchIdAddresses_TW4(true);
        }
        private void tsmiAction_RefreshCounteragent_Click(object sender, EventArgs e)
        {
            GetAddressesFromMdlpByInn();
        }
        private void tsmiAction_Verify_SyncForMdlp_Click(object sender, EventArgs e)
        {
            ToVerify("info", false);
        }
        private void синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncAddressesWithTW4(false);
        }
        private void tsmiAction_SyncToTW4_CounteragentsSysId_All_Click(object sender, EventArgs e)
        {
            SetSystemSubjId(false);
        }
        private void tsmiAction_SyncToTW4_AddressesBranchId_All_Click(object sender, EventArgs e)
        {
            SetBranchIdAddresses_TW4(false);
        }
        private void tsmiAction_LinkToTW4_ForInn_Click(object sender, EventArgs e)
        {
            LinkedCounteragentsByInn();
        }
        private void связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedCounteragentsAddresses(true);
        }
        private void vCounteragents_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
                OpenCounteragentCard();
        }
        private void tsmiAction_SyncToTW4_Fias_Click(object sender, EventArgs e)
        {
            SetFias_TW4(true);
        }
        private void tsmiAction_SyncToTW4_FiasAll_Click(object sender, EventArgs e)
        {
            SetFias_TW4(false);
        }
        #endregion
    }
}
