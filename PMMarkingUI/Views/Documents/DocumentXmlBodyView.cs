using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using ProfitMed.Firebird;
using ProfitMed.DataContract;
using ProfitMedServiceClient;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Views
{
    public partial class DocumentXmlBodyView : UserControl
    {
        public string xmlBody { get; private set; }
        public DocumentXmlBodyView()
        {
            InitializeComponent();
            //scXmlBody.SplitterDistance = 0;
            scXmlBody.Panel1Collapsed = true;
        }

        private void cbxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            tbXmlBody.WordWrap = (sender as CheckBox).Checked;
        }

        #region Отрисовка дерева документа
        /// <summary>
        /// Отрисовка дерева документа
        /// </summary>
        /// <param name="xmlBody"></param>
        public void BuildXmlTree(string xmlBody = null)
        {
            this.xmlBody = xmlBody;
            twXmlBody.Nodes.Clear();
            //scXmlBody.SplitterDistance = 0;
            //scXmlBody.Panel1Collapsed = true;
            scXmlBody.Panel2Collapsed = true;

            if (String.IsNullOrEmpty(xmlBody))
            {
                tbXmlBody.Text = "";                
                this.xmlBody = "";
                return;
            }
            try
            {
                tbXmlBody.Text = xmlBody;
                rtbXmlBody.Text = xmlBody;
                //tbXmlBody.Lines = xmlBody.Replace("\n", "^").Replace(Environment.NewLine, "^").Split('^');
                FormatRichTextBoxXML();

                tsmiShowAdditional_Click(null, null);
                /*this.Cursor = Cursors.WaitCursor;

                // SECTION 1. Create a DOM Document and load the XML data into it.
                XmlDocument dom = new XmlDocument();
                using (TextReader sr = new StringReader(xmlBody))
                {
                    dom.Load(sr);
                }

                // SECTION 2. Initialize the TreeView control.
                twXmlBody.BeginUpdate();
                twXmlBody.Nodes.Clear();
                twXmlBody.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = twXmlBody.Nodes[0];

                // SECTION 3. Populate the TreeView with the DOM nodes.
                AddNode(dom.DocumentElement, tNode);
                twXmlBody.ExpandAll();
                twXmlBody.EndUpdate();
                //twXmlBody.Nodes[0].EnsureVisible();
                //twXmlBody.Nodes[0].ExpandAll();
                */
            }            
            catch (XmlException xmlEx)
            {
                //MessageBox.Show(xmlEx.Message);
                twXmlBody.Nodes.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //this.Cursor = Cursors.Default;
            }
        }

        Color specialCharColor = Color.Blue;   //  Color for special characters
        Color escapeColor = Color.Orchid;      //  Color for escape sequences
        Color elementColor = Color.DarkRed;    //  Color for Xml elements
        Color attributeColor = Color.Red;      //  Color for Xml attributes
        Color valueColor = Color.DarkBlue;     //  Color for attribute values
        Color commentColor = Color.DarkGreen;  //  Color for Xml comments
        private void FormatRichTextBoxXML()
        {
            Application.DoEvents();
            PMMarkingUI.Classes.XML.RichTextDrawing.StopRedraw(rtbXmlBody);

            //  Tokenize the Xml string
            List<PMMarkingUI.Classes.XML.XmlToken> tokens = PMMarkingUI.Classes.XML.XmlTokenizer.Tokenize(rtbXmlBody.Text);
            foreach (PMMarkingUI.Classes.XML.XmlToken token in tokens)
            {
                rtbXmlBody.Select(token.Index, token.Text.Length);
                switch (token.Type)
                {
                    case PMMarkingUI.Classes.XML.XmlTokenType.None:
                        rtbXmlBody.SelectionColor = rtbXmlBody.ForeColor;
                        break;
                    case PMMarkingUI.Classes.XML.XmlTokenType.SpecialChar:
                        rtbXmlBody.SelectionColor = specialCharColor;
                        break;
                    case PMMarkingUI.Classes.XML.XmlTokenType.Escape:
                        rtbXmlBody.SelectionColor = escapeColor;
                        break;
                    case PMMarkingUI.Classes.XML.XmlTokenType.Element:
                        rtbXmlBody.SelectionColor = elementColor;
                        break;
                    case PMMarkingUI.Classes.XML.XmlTokenType.Attribute:
                        rtbXmlBody.SelectionColor = attributeColor;
                        break;
                    case PMMarkingUI.Classes.XML.XmlTokenType.Value:
                        rtbXmlBody.SelectionColor = valueColor;
                        break;
                    case PMMarkingUI.Classes.XML.XmlTokenType.Comment:
                        rtbXmlBody.SelectionColor = commentColor;
                        break;
                }
            }
            PMMarkingUI.Classes.XML.RichTextDrawing.RestoreRedraw(rtbXmlBody);
        }

        static string GetAttributeText(XmlNode inXmlNode, string name)
        {
            XmlAttribute attr = (inXmlNode.Attributes == null ? null : inXmlNode.Attributes[name]);
            return attr == null ? null : attr.Value;
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                XmlNodeList nodeList = inXmlNode.ChildNodes;
                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    XmlNode xNode = inXmlNode.ChildNodes[i];
                    string text = GetAttributeText(xNode, "name");
                    if (string.IsNullOrEmpty(text))
                        text = xNode.Name;
                    inTreeNode.Nodes.Add(new TreeNode(text));
                    TreeNode tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // If the node has an attribute "name", use that.  Otherwise display the entire text of the node.
                string text = GetAttributeText(inXmlNode, "name");
                if (string.IsNullOrEmpty(text))
                    text = (inXmlNode.OuterXml).Trim();
                if (inTreeNode.Text != text)
                    inTreeNode.Text = text;
                inTreeNode.Nodes.Clear();
            }
        }
        #endregion

        private void tsmiShowAdditional_Click(object sender, EventArgs e)
        {
            scXmlBody.SplitterDistance = (int)(this.Width / 2);
            //scXmlBody.Panel1Collapsed = !scXmlBody.Panel1Collapsed;
            tsmiShowAdditional.Text = (scXmlBody.Panel1Collapsed) ? "Скрыть XML текст" : "Показать XML текст";
        }

        private void tsmiCopyXmlToBoof_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbXmlBody.Text);
                //MessageBox.Show("Текст скопирован");
            }
            catch { }
        }

        private void tsmiSaveXmlToFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, tbXmlBody.Text);
                    MessageBox.Show("Файл сохранен");
                }
            }
            catch { }
        }

        private void twXmlBody_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.BeginEdit();
        }

        private void twXmlBody_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            e.CancelEdit = true;
        }

        private void cbxFormatXml_CheckedChanged(object sender, EventArgs e)
        {
            rtbXmlBody.Visible = cbxFormatXml.Checked;
            tbXmlBody.Visible = !cbxFormatXml.Checked;
        }
    }
}
