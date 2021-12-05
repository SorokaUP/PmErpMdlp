namespace PMMarkingUI.Forms
{
    partial class frmCounteragentVerifyFinish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gData = new DevExpress.XtraGrid.GridControl();
            this.vData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colINN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricbxBool = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colPackNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxBool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gData
            // 
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(0, 0);
            this.gData.MainView = this.vData;
            this.gData.Name = "gData";
            this.gData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbxBool});
            this.gData.Size = new System.Drawing.Size(547, 216);
            this.gData.TabIndex = 8;
            this.gData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vData});
            // 
            // vData
            // 
            this.vData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINN,
            this.colResponse,
            this.colPackNum});
            this.vData.GridControl = this.gData;
            this.vData.Name = "vData";
            this.vData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowIncrementalSearch = true;
            this.vData.OptionsBehavior.Editable = false;
            this.vData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.vData.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.vData.OptionsView.ColumnAutoWidth = false;
            this.vData.OptionsView.ShowFooter = true;
            this.vData.OptionsView.ShowGroupPanel = false;
            // 
            // colINN
            // 
            this.colINN.Caption = "ИНН";
            this.colINN.FieldName = "INN";
            this.colINN.Name = "colINN";
            this.colINN.Visible = true;
            this.colINN.VisibleIndex = 0;
            this.colINN.Width = 193;
            // 
            // colResponse
            // 
            this.colResponse.Caption = "Обработан";
            this.colResponse.ColumnEdit = this.ricbxBool;
            this.colResponse.FieldName = "IS_RESPONSE";
            this.colResponse.Name = "colResponse";
            this.colResponse.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IS_RESPONSE", "{0:#.##}")});
            this.colResponse.Visible = true;
            this.colResponse.VisibleIndex = 1;
            // 
            // ricbxBool
            // 
            this.ricbxBool.AutoHeight = false;
            this.ricbxBool.DisplayValueChecked = "1";
            this.ricbxBool.DisplayValueGrayed = "-1";
            this.ricbxBool.DisplayValueUnchecked = "0";
            this.ricbxBool.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.ricbxBool.Name = "ricbxBool";
            this.ricbxBool.ValueChecked = 1;
            this.ricbxBool.ValueGrayed = -1;
            this.ricbxBool.ValueUnchecked = 0;
            // 
            // colPackNum
            // 
            this.colPackNum.Caption = "Номер пакета";
            this.colPackNum.FieldName = "PACK_NUM";
            this.colPackNum.Name = "colPackNum";
            this.colPackNum.Visible = true;
            this.colPackNum.VisibleIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Location = new System.Drawing.Point(0, 272);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(547, 33);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Принять";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.Location = new System.Drawing.Point(0, 0);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(547, 52);
            this.tbMessage.TabIndex = 11;
            this.tbMessage.Text = "Некое описание ответа";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tbMessage);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gData);
            this.scMain.Size = new System.Drawing.Size(547, 272);
            this.scMain.SplitterDistance = 52;
            this.scMain.TabIndex = 12;
            // 
            // frmCounteragentVerifyFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 305);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.btnOk);
            this.Name = "frmCounteragentVerifyFinish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнено";
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxBool)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gData;
        private DevExpress.XtraGrid.Views.Grid.GridView vData;
        private DevExpress.XtraGrid.Columns.GridColumn colINN;
        private DevExpress.XtraGrid.Columns.GridColumn colResponse;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricbxBool;
        private DevExpress.XtraGrid.Columns.GridColumn colPackNum;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.SplitContainer scMain;
    }
}