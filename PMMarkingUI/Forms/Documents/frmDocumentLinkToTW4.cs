using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Sys;
using DevExpress.XtraBars;
using ProfitMed.Firebird;
using PMMarkingUI.Classes;

namespace PMMarkingUI.Forms
{
    public partial class frmDocumentLinkToTW4 : Form
    {
        int doc_id = 0;
        int serch_concept = 0;

        public frmDocumentLinkToTW4(int doc_id)
        {
            InitializeComponent();
            this.doc_id = doc_id;
            bbiLink.Enabled = false;

            vDocs.SetDefaultGridViewOptions();
            vLins.SetDefaultGridViewOptions();

            DataTable doc = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
            if (doc.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось проверить документ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if ((int)doc.Rows[0]["DOC_TYPE"] != 601)
            {
                MessageBox.Show("Не верный тип документа! Требуется 601 (приход по прямому акцепту).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            DateTime doc_date = Convert.ToDateTime(doc.Rows[0]["DOC_DATE"]);

            beiPeriodEnd.EditValue = doc_date;
            beiPeriodStart.EditValue = doc_date.AddDays(-14);

            beiDocInfoDate.EditValue = doc_date.ToString("dd.MM.yyyy");
            beiDocInfoId.EditValue = doc_id;
            beiDocInfoDocNum.EditValue = doc.Rows[0]["DOC_NUM"].ToString();

            beiDocInfoSenderAddress.EditValue = doc.Rows[0]["SENDER_ADDRESS"].ToString();
            beiDocInfoSenderName.EditValue = doc.Rows[0]["SENDER_NAME"].ToString();
            beiDocInfoTurnoverType.EditValue = doc.Rows[0]["TURNOVER_TYPE_NAME"].ToString();

            DataTable counteragent = DAO.GetTW_CounteragentsBySysId(doc.Rows[0]["SENDER_SYS_ID"].ToString());
            beiCounteragent.Tag = Convert.ToInt32(counteragent.Rows[0]["LID"]);
            beiCounteragent.EditValue = counteragent.Rows[0]["NAME"].ToString();
        }

        #region Методы связки документов
        /// <summary>
        /// Связать ГОТОВЫЕ ДОКУМЕНТЫ
        /// </summary>
        private void LinkFinishedDoc(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int did = Convert.ToInt32(vDocs.GetDataSourceRow()["DID"]);
                string dcode = vDocs.GetDataSourceRow()["DCODE"].ToString();

                if (MessageBox.Show($"Связать выбранные документы?{Environment.NewLine}{Environment.NewLine}МДЛП: ID = {doc_id} | \"{beiDocInfoDocNum.EditValue.ToString()}\"{Environment.NewLine}TW4: DID = {did} | \"{dcode}\"", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool res = DAO.DocumentSetLinkDid(doc_id, did);                    
                    MessageBox.Show(res ? "Выполнено" : "Связать не удалось");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка привязки готовых документов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                      
        }

        private void LinkWithCreateSerialLins(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("(В РАЗРАБОТКЕ) Документы с созданием строк серии");
            return;

            switch (this.serch_concept)
            {
                case 6901:
                    #region 6901
                    MessageBox.Show("6901 (В РАЗРАБОТКЕ)");
                    #endregion
                    break;

                case 6001:
                    #region 6001                    
                    int DID6901 = 0;
                    int USER_ID = 201;
                    string DOC_NUM = "";
                    DateTime DOC_DATE = DateTime.Now;

                    try
                    {
                        DataTable res = DAO.CreateDocument6001From6901(DID6901, USER_ID, DOC_NUM, DOC_DATE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                    break;

                default:
                    MessageBox.Show($"Работа с концептом {this.serch_concept} не определена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        private void LinkWithCreateAll(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("(В РАЗРАБОТКЕ) Документы с созданием всего необходимого");
            return;

            switch (this.serch_concept)
            {
                case 6901:
                    #region 6901
                    MessageBox.Show("6901 (В РАЗРАБОТКЕ)");
                    #endregion
                    break;

                case 6001:
                    #region 6001                    
                    int DID6901 = 0;
                    int USER_ID = 201;
                    string DOC_NUM = "";
                    DateTime DOC_DATE = DateTime.Now;

                    try
                    {
                        DataTable res = DAO.CreateDocument6001From6901(DID6901, USER_ID, DOC_NUM, DOC_DATE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                    break;

                default:
                    MessageBox.Show($"Работа с концептом {this.serch_concept} не определена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
        #endregion
        #region Работа с документами и строками
        /// <summary>
        /// Получить документы по фильтру
        /// </summary>
        /// <param name="DCONCEPT">6901 (заказы поставщика) | 6001 (приходные накладные)</param>
        private void GetDocumentsTWByConcept(int DCONCEPT)
        {
            this.serch_concept = DCONCEPT;
            string vDocsCaption = "Документы";

            switch (this.serch_concept)
            {
                case 6901:
                    vDocs.ViewCaption =  $"{vDocsCaption} ({this.serch_concept} - заказы поставщика)";
                    break;

                case 6001:
                    vDocs.ViewCaption = $"{vDocsCaption} ({this.serch_concept} - приходные накладные)";
                    break;

                default:
                    MessageBox.Show($"Работа с концептом {this.serch_concept} не определена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Контрагент
            int DID1 = Convert.ToInt32(beiCounteragent.Tag);
            // Период
            DateTime BEG_DATE = Convert.ToDateTime(beiPeriodStart.EditValue);
            DateTime END_DATE = Convert.ToDateTime(beiPeriodEnd.EditValue);

            cDocs.DataSource = DAO.GetTW4DocumentsForLink(DID1, BEG_DATE, END_DATE, DCONCEPT);
            vDocs.LayoutChanged();

            // Обновляем список, если документы пришли
            Refresh_Lin();   
        }

        /// <summary>
        /// Обновить список строк выбранного документа vDocs
        /// </summary>
        private void Refresh_Lin()
        {
            DataRow row = vDocs.GetDataSourceRow();
            if (row == null)
            {
                cLins.DataSource = new DataTable();
                vLins.LayoutChanged();
                return;
            }

            int did = 0;
            try
            {
                did = Convert.ToInt32(row["DID"]);
            }
            catch
            {
                did = 0;
            }
            if (did == 0)
            {
                cLins.DataSource = new DataTable();
                vLins.LayoutChanged();
                return;
            }

            cLins.DataSource = DAO.GetTW4DocumentLinsForLink(did);
            vLins.LayoutChanged();

            bbiLink.Enabled = ((cLins.DataSource as DataTable).Rows.Count > 0);
        }
        #endregion





        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beiCounteragent.Ref(e, DAO.Ref_GetTwCounteragents(), "LID", "NAME");
        }

        private void vDocs_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Refresh_Lin();
        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            // ПОЛУЧИТЬ ДОКУМЕНТЫ
            // Заказы поставщика
            GetDocumentsTWByConcept(6901);
        }

        private void barButtonItem8_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            // ПОЛУЧИТЬ ДОКУМЕНТЫ
            // Приходные накладные
            GetDocumentsTWByConcept(6001);
        }

        private void bbiGetDocs_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetDocumentsTWByConcept(6001);
        }
    }
}
