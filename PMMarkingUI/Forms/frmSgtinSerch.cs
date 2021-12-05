using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMarkingUI.Forms
{
    public partial class frmSgtinSerch : Form
    {
        public frmSgtinSerch()
        {
            InitializeComponent();
            cbMode.SelectedIndex = 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            tbRes.Text = "";
            List<object> resList = new List<object>();            

            if (tbSgtin.Text.Trim().Length == 27)
            {
                try
                {
                    ProfitMed.DataContract.SSFilter WebFilter = new ProfitMed.DataContract.SSFilter();
                    WebFilter.filter = new ProfitMed.DataContract.Sfilter();
                    WebFilter.filter.sgtins = new List<string>();
                    WebFilter.filter.sgtins.Add(tbSgtin.Text.Trim());

                    switch (cbMode.SelectedIndex)
                    {
                        case 1:
                            ProfitMed.DataContract.SgtinByList resOrg = Sys.Global.WebMethod<ProfitMed.DataContract.SgtinByList>(149, WebFilter);
                            if (resOrg.failed == 1)
                            {
                                resList.Add($"Код: {resOrg.failed_entries[0].error_code}");
                                resList.Add($"Сообщение: {resOrg.failed_entries[0].error_desc}");
                            }
                            else
                            {
                                resList.Add($"Коробка: {((string.IsNullOrEmpty(resOrg.entries[0].pack3_id)) ? "< НЕ В КОРОБКЕ / КОРОБКА БЫЛА РАЗАГРЕГИРОВАНА РАНЕЕ >" : resOrg.entries[0].pack3_id)}");
                                resList.Add($"Серия: {resOrg.entries[0].batch}");
                                resList.Add($"Статус: {resOrg.entries[0].status}");
                                resList.Add($"Текущий владелец: {resOrg.entries[0].owner}");
                                resList.Add($"branch_id: {resOrg.entries[0].sys_id}");
                                resList.Add($"");
                                resList.Add($"Наименование: {resOrg.entries[0].prod_name}");
                                resList.Add($"Торговое наименование: {resOrg.entries[0].sell_name}");
                                resList.Add($"SGTIN: {resOrg.entries[0].sgtin}");
                                resList.Add($"");
                                resList.Add($"Статус: {resOrg.entries[0].status} от {resOrg.entries[0].status_date}");
                                resList.Add($"Территориально находится: ({resOrg.entries[0].federal_subject_code}) {resOrg.entries[0].federal_subject_name}");
                            }
                            break;

                        case 0:
                            ProfitMed.DataContract.PublicSgtinByList resPublic = Sys.Global.WebMethod<ProfitMed.DataContract.PublicSgtinByList>(150, WebFilter);
                            if (resPublic.failed == 1)
                            {
                               
                                resList.Add($"Код: {resPublic.failed_entries[0].error_code}");
                                resList.Add($"Сообщение: {resPublic.failed_entries[0].error_desc}");
                            }
                            else
                            {
                                string org_name = "";
                                try
                                {
                                    ProfitMed.DataContract.Filters<ProfitMed.DataContract.PartnersFilter> WebFilterBID = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.PartnersFilter>
                                    {
                                        filter = new ProfitMed.DataContract.PartnersFilter { reg_entity_type = 1, branch_id = resPublic.entries[0].branch_id },
                                        start_from = 0,
                                        count = 10
                                    };
                                    List<ProfitMed.DataContract.FilteredRecords> resBID = Sys.Global.WebMethodFiltered<ProfitMed.DataContract.PartnersFilter, ProfitMed.DataContract.CountragentsList, ProfitMed.DataContract.FilteredRecords>(166, WebFilterBID);

                                    org_name = resBID[0].ORG_NAME;
                                }
                                catch (Exception ex) { org_name = ""; }

                                resList.Add($"Коробка: {(string.IsNullOrEmpty(resPublic.entries[0].sscc) ? "< НЕ В КОРОБКЕ / КОРОБКА БЫЛА РАЗАГРЕГИРОВАНА РАНЕЕ >" : resPublic.entries[0].sscc)}");
                                resList.Add($"Серия: {resPublic.entries[0].batch}");
                                resList.Add($"Статус: {resPublic.entries[0].status}");
                                resList.Add($"Текущий владелец: {(string.IsNullOrEmpty(org_name) ? "< не определен >" : org_name)}");
                                resList.Add($"branch_id: {resPublic.entries[0].branch_id}");
                                resList.Add($"");
                                resList.Add($"Наименование: {resPublic.entries[0].prod_name}");
                                resList.Add($"Торговое наименование: {resPublic.entries[0].sell_name}");
                                resList.Add($"SGTIN: {resPublic.entries[0].sgtin}");
                            }
                            break;
                    }
                }
                catch (NullReferenceException nex)
                {
                    resList.Clear();
                    resList.Add("Не удалось получить данные от сервера МДЛП.");
                    resList.Add("Попробуйте другой режим поиска.");
                }
                catch (Exception ex)
                {
                    resList.Clear();
                    resList.Add(ex.Message);
                }
            }
            if (tbSgtin.Text.Trim().Length == 18)
            {
                try
                {
                    ProfitMed.DataContract.SSFilter WebFilter = new ProfitMed.DataContract.SSFilter();
                    WebFilter.filter = new ProfitMed.DataContract.Sfilter();
                    WebFilter.filter.sgtins = new List<string>();
                    WebFilter.filter.sgtins.Add(tbSgtin.Text.Trim());

                    ProfitMed.DataContract.Filters<ProfitMed.DataContract.SsccSgtinsFilter> filter = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.SsccSgtinsFilter>();
                    filter.filter = new ProfitMed.DataContract.SsccSgtinsFilter();
                    filter.start_from = 0;
                    filter.count = 10;
                    ProfitMed.DataContract.SgtinsListFromSscc resSSCC = Sys.Global.WebMethod<ProfitMed.DataContract.SgtinsListFromSscc>(156, filter, tbSgtin.Text.Trim());
                    if (resSSCC.total > 0)
                    {
                        resList.Add($"Коробка существует");
                        resList.Add($"Текущий владелец: {resSSCC.entries[0].owner}");
                        resList.Add($"Содержит: {resSSCC.total} ед. продукции");
                        resList.Add($"-------------------------------------------");
                        List<SsccDetailInfo> detail = new List<SsccDetailInfo>();
                        foreach (ProfitMed.DataContract.Sgtin sgtin in resSSCC.entries)
                        {
                            SsccDetailInfo sdi = new SsccDetailInfo();
                            sdi.gtin = sgtin.gtin;
                            sdi.batch = sgtin.batch;
                            sdi.status = sgtin.status;
                            sdi.status_date = sgtin.status_date;

                            bool isExist = false;
                            foreach (SsccDetailInfo item in detail)
                            {
                                if (item.gtin == sdi.gtin && item.batch == sdi.batch)
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                            if (!isExist)
                                detail.Add(sdi);
                        }
                        foreach (SsccDetailInfo item in detail)
                        {
                            resList.Add($"GTIN: {item.gtin}");
                            resList.Add($"Серия: {item.batch}");
                            resList.Add($"Статус: {item.status} от {item.status_date}");
                            resList.Add($"-------------------------------------------");
                        }
                    }
                    else
                    {
                        resList.Add("Ничего найти не удалось.");
                        resList.Add("Возможно коробка была ранее РАЗАГРЕГИРОВАНА.");
                    }
                }
                catch (NullReferenceException nex)
                {
                    resList.Clear();
                    resList.Add("Не удалось получить данные от сервера МДЛП.");
                }
                catch (Exception ex)
                {
                    resList.Clear();
                    resList.Add(ex.Message);
                }
            }

            foreach (string item in resList)
            {
                tbRes.Text += item + Environment.NewLine;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbRes.Text);
                MessageBox.Show("Текст скопирован");
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, tbRes.Text);
                    MessageBox.Show("Файл сохранен");
                }
            }
            catch { }
        }

        private class SsccDetailInfo
        {
            public string gtin { get; set; }
            public string batch { get; set; }
            public string status { get; set; }
            public DateTime status_date { get; set; }
        }
    }
}
