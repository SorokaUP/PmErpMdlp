namespace PMMarkingUI.Views.Filters
{
    partial class GridFilterView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSerchColumn = new System.Windows.Forms.ComboBox();
            this.tbSerchText = new System.Windows.Forms.TextBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.cbxSerch_Like = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.cbSerchColumn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSerchText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSerch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxSerch_Like, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 45);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // cbSerchColumn
            // 
            this.cbSerchColumn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSerchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerchColumn.FormattingEnabled = true;
            this.cbSerchColumn.Location = new System.Drawing.Point(0, 0);
            this.cbSerchColumn.Margin = new System.Windows.Forms.Padding(0);
            this.cbSerchColumn.Name = "cbSerchColumn";
            this.cbSerchColumn.Size = new System.Drawing.Size(150, 21);
            this.cbSerchColumn.TabIndex = 0;
            // 
            // tbSerchText
            // 
            this.tbSerchText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSerchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSerchText.Location = new System.Drawing.Point(150, 0);
            this.tbSerchText.Margin = new System.Windows.Forms.Padding(0);
            this.tbSerchText.MaxLength = 255;
            this.tbSerchText.Name = "tbSerchText";
            this.tbSerchText.Size = new System.Drawing.Size(370, 21);
            this.tbSerchText.TabIndex = 1;
            this.tbSerchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSerchText_KeyDown);
            // 
            // btnSerch
            // 
            this.btnSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerch.Location = new System.Drawing.Point(520, 0);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(102, 21);
            this.btnSerch.TabIndex = 2;
            this.btnSerch.Text = "Искать";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // cbxSerch_Like
            // 
            this.cbxSerch_Like.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxSerch_Like.Location = new System.Drawing.Point(153, 24);
            this.cbxSerch_Like.Name = "cbxSerch_Like";
            this.cbxSerch_Like.Size = new System.Drawing.Size(104, 18);
            this.cbxSerch_Like.TabIndex = 3;
            this.cbxSerch_Like.Text = "Текст внутри";
            this.cbxSerch_Like.UseVisualStyleBackColor = true;
            // 
            // GridFilterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GridFilterView";
            this.Size = new System.Drawing.Size(622, 45);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbSerchColumn;
        private System.Windows.Forms.TextBox tbSerchText;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.CheckBox cbxSerch_Like;
    }
}
