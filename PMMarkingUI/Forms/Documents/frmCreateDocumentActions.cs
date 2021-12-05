using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Classes;

namespace PMMarkingUI.Forms
{
    public partial class frmCreateDocumentActions : Form
    {
        private string mode;
        private List<int> docs_id;
        private int doc_type;
        public int ResDocId { get; private set; }
        public List<ParentAndChild> ResDocsId { get; private set; }

        /// <summary>
        /// Выбор действия при создании дочернего документа
        /// </summary>
        /// <param name="doc_id">ID документа из таблицы tbl_document</param>
        /// <param name="mode">accept | decline</param>
        public frmCreateDocumentActions(List<int> docs_id, string mode)
        {
            InitializeComponent();
            this.docs_id = docs_id;
            this.mode = mode;
            this.ResDocId = 0;
            this.ResDocsId = new List<ParentAndChild>();
            CanClose = false;
            this.FormClosing -= Form_Closing;

            switch (this.mode)
            {
                case "accept":
                    this.Text = $"ПОДТВЕРДИТЬ";
                    break;

                case "decline":
                    this.Text = $"ОТКЛОНИТЬ";
                    break;

                default:
                    MessageBox.Show("Не удалось определить режим работы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CanClose = true;
                    this.Close();
                    return;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Go(rgActions.SelectedIndex);
        }

        private void Go(int selectedItem = -1)
        {
            if (selectedItem < 0)
            {
                MessageBox.Show($"Действие для типа документа {this.doc_type} не настроено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CanClose = true;
                this.Close();
                return;
            }
            int ResDocId = 0;
            ActionSettings Action = null;
            try
            {
                Action = (ActionSettings)rgActions.Properties.Items[selectedItem].Tag;
                if (!Action.isActive)
                {
                    MessageBox.Show("К сожалению, выбранный метод на данный момент не доступен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResDocId = 0;
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                if (Action.isAdmin)
                {
                    frmTextBox frmPass = new frmTextBox("Требуется административный пароль", "Пароль", "", true);
                    frmPass.ShowDialog();
                    if ((frmPass.Data ?? "") != Sys.Global.AdminPassword)
                    {
                        this.ResDocId = 0;
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти выбранное действие! Операция прервана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CanClose = true;
                this.Close();
                return;
            }
            using (frmProccess process = new frmProccess())
            {
                process.progressBarControl.Properties.Maximum = docs_id.Count();
                process.Show();                
                foreach (int doc_id in this.docs_id)
                {
                    switch (Action.id)
                    {
                        case 8: // 335 - Таможенное оформление
                            Forms.Documents.frmDocument335 frm335 = new Documents.frmDocument335(doc_id);
                            if (frm335.ShowDialog() == DialogResult.Cancel)
                            {
                                this.ResDocId = 0;
                                DialogResult = DialogResult.Cancel;
                                this.Close();
                            }
                            break;
                    }

                    ResDocId = PMMarkingUI.Classes.Additional.DocumentAction(doc_id, Action.id);
                    this.ResDocsId.Add(new ParentAndChild { parent = doc_id, child = ResDocId });
                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }
                process.Close();
            }
            // Для одного запрошенного документа возвращаем созданный ID документа
            if (this.docs_id.Count == 1)
                this.ResDocId = ResDocId;
            DialogResult = (this.ResDocId > 0) ? DialogResult.OK : DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void rgActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
        }

        private void GetActions()
        {
            DataTable data = new DataTable();
            switch (this.mode)
            {
                case "accept":
                    this.Text = $"ПОДТВЕРДИТЬ ({this.doc_type})";
                    data = DAO.GetDocumentActions(0, 0, this.doc_type, 1);
                    break;

                case "decline":
                    this.Text = $"ОТКЛОНИТЬ ({this.doc_type})";
                    data = DAO.GetDocumentActions(0, 0, this.doc_type, -1);                    
                    break;

                default:
                    MessageBox.Show("Не удалось определить режим работы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CanClose = true;
                    this.Close();
                    return;
            }

            if (data.Rows.Count == 0)
                Go(-1);

            // Заполняем список действий
            foreach (DataRow row in data.Rows)
            {
                rgActions.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem()
                {
                    Description = row["NAME"].ToString(),
                    Value = (int)row["ID"],
                    Tag = new ActionSettings {
                        id = (int)row["ID"],
                        isActive = ((int)row["IS_ACTIVE"] == 1),
                        isAdmin = ((int)row["IS_ADMIN"] == 1)
                    }
                });
            }            

            // Перестраховка
            // Если выбор вариантов содержит хотя бы одно действие - активируем кнопку
            if (rgActions.Properties.Items.Count > 0)
                btnOk.Enabled = false;
        }

        bool CanClose;
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (CanClose)
            {
                DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }

            this.Dispose();
        }

        private void frmCreateDocumentActions_Shown(object sender, EventArgs e)
        {
            if (this.docs_id.Count == 0)
            {
                MessageBox.Show("Ни одного документа не передано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CanClose = true;
                this.Close();
                return;
            }
            // Для одиночного документа
            if (this.docs_id.Count == 1)
            {
                // Получаем тип документа
                int tDoc_Type = DAO.GetDocumentTypeById(docs_id[0]);
                // Если пришел ошибочный тип документа
                if (tDoc_Type <= 0)
                {
                    MessageBox.Show("Не удалось определить документ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CanClose = true;
                    this.Close();
                    return;
                }
                else
                {
                    this.doc_type = tDoc_Type;
                }
            }
            // Для группы документов проверяем тип всех переданных - должен быть один на всех
            if (this.docs_id.Count > 1)
            {
                List<int> newDocs_id = new List<int>();
                bool isError = false;
                bool isFirst = true;
                int doc_type = -1;
                foreach (int doc_id in docs_id)
                {
                    // Получаем тип документа
                    int tDoc_Type = DAO.GetDocumentTypeById(doc_id);
                    // Если пришел ошибочный тип документа пропускаем
                    if (tDoc_Type <= 0)
                        continue;
                    // Заполняем список на отработку уникальными документами
                    if (!newDocs_id.Contains(doc_id))
                        newDocs_id.Add(doc_id);
                    else
                        continue;

                    if (isFirst)
                    {
                        doc_type = tDoc_Type;
                        isFirst = false;
                    }
                    else
                    {
                        // Сверяем типы документов
                        if (doc_type != tDoc_Type)
                        {
                            isError = true;
                            break;
                        }
                    }
                }
                if (isError)
                {
                    MessageBox.Show("У группы документов различатся тип документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CanClose = true;
                    this.Close();
                    return;
                }
                if (newDocs_id.Count == 0)
                {
                    MessageBox.Show("Документов удовлетворяющих условиям нет (тип документа указан | уникальные документы)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CanClose = true;
                    this.Close();
                    return;
                }
                this.docs_id = newDocs_id;
                this.doc_type = doc_type;
            }
            GetActions();
        }

        private class ActionSettings
        {
            public int id { get; set; }
            public bool isActive { get; set; }
            public bool isAdmin { get; set; }
        }
    }
}
