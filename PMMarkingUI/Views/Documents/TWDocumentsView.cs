using System;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PMMarkingUI.Delegats;
using PMMarkingUI.Classes;
using ProfitMed.Firebird;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PMMarkingUI.Views
{
    public partial class TWDocumentsView : UserControl
    {
        public event DelegateAddPage dapDocument;
        DataRow DocsCurrentRow;

        DataTable Docs;
        DocFilterTWDb docFilter;
        ProfitMedServiceClient.ProfitMedClient Api = new ProfitMedServiceClient.ProfitMedClient();
        public TWDocumentsView(DelegateAddPage ntp)
        {
            InitializeComponent();
            Text = "Документы TW4";
            Tag = true;

            // Передаем значение делегата в событие (frmMain)
            dapDocument = ntp;
            docFilterTWDbPanel.SetDelegate(GetFilter);
            //TWDbFilterPanel.DeactivateDirection();
            //TWDbFilterPanel.DeactivateManager();
            //TWDbFilterPanel.DeactivateDepartament();
            //TWDbFilterPanel.DeactivateGroup();

            Docs = new DataTable();
            gDocs.DataSource = Docs;
        }

        //===================================================================================
        #region Документы
        private void GetFilter(DocFilterTWDb docFilter)
        {
            this.docFilter = docFilter;
            Refresh_Docs();
        }

        /// <summary>
        /// Обновляет список документов
        /// </summary>
        private void Refresh_Docs()
        {
            //vDocs.Columns.Clear();
            Docs = DAO.GetTWDocumentByFilter(
                docFilter.FromDate,
                docFilter.ToDate,
                0//docFilter.Counteragent
                );
            gDocs.DataSource = Docs;
            vDocs.LayoutChanged();
        }    
                
        private void vDocs_DoubleClick(object sender, EventArgs e)
        {
            // Окрашиваем текущую выбранную запись
            GridView view = sender as GridView;
            rowHandle = view.GetHitInfo_RowHandle(e);
            if (rowHandle >= 0)
            {
                view.LayoutChanged();
                SelectDoc();
            }
        }

        /// <summary>
        /// Выбрать текущий документ (на котором сейчас стоит курсор)
        /// </summary>
        private void SelectDoc()
        {
            try
            {
                DataRow row = vDocs.GetDataSourceRow();

                // Открываем вкладку
                // Вызываем событие по делегату
                dapDocument(new TWDocumentView(Convert.ToInt32(row["DID"])));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        #endregion
        #region Окраска строк
        int rowHandle = GridControl.InvalidRowHandle;
        Color selectRowColor1 = Color.Wheat;
        Color selectRowColor2 = Color.White;
        private void vDocs_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
                e.HighPriority = true;
            }
        }

        private void vDocs_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vDocs_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vGTIN_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vGTIN_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vGTIN_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }
        #endregion
        #region Меню и кнопки
        private void SendDoc(object sender, EventArgs e)
        {
            MessageBox.Show("Отправить документ");
            // TODO: Отправить документ
            //Api.DocumentUpload();
        }
        private void GetDoc(object sender, EventArgs e)
        {
            MessageBox.Show("Получить документ");
            // TODO: Получить документ
            //Api.GetDocument();
        }
        private void GetTiket(object sender, EventArgs e)
        {
            MessageBox.Show("Получить квитанцию / этикетку");
            // TODO: Получить этикетку
            //Api.GetDocumentTicket();
        }
        private void GetMetadata(object sender, EventArgs e)
        {
            MessageBox.Show("Получить мета-данные");
            // TODO: Получить метаданные
            //Api.GetDocMetadata();
        }
        private void btnSerch_Click(object sender, EventArgs e)
        {
            Refresh_Docs();
        }
        private void сформироватьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сформировать документ TW");
            // TODO: Сформировать документ TW
            //Api.GetDocMetadata();
        }
        #endregion
    }
}
