using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.StyleFormatConditions;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Classes
{
    public static class Extension
    {
        public static void SetReadOnly(this DevExpress.XtraVerticalGrid.Rows.VGridRows Rows)
        {
            foreach (DevExpress.XtraVerticalGrid.Rows.EditorRow row in Rows)
            {
                row.Properties.ReadOnly = true;
                SetReadOnly(row.ChildRows);
            }
        }

        public static void CombineWithForOneRow(this DataTable DtMain, DataTable DtSlave)
        {
            foreach (DataColumn col in DtSlave.Columns)
            {
                DtMain.Columns.Add(col.ColumnName.ToUpper(), col.DataType);
                if (DtMain.Rows.Count > 0)
                    DtMain.Rows[0][col.ColumnName.ToUpper()] = DtSlave.Rows[0][col.ColumnName];
            }
        }

        public static int GetDataSourceRowIndex(this DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            int data_id = -1;
            try
            {
                int view_id = view.GetSelectedRows()[0];
                data_id = view.GetDataSourceRowIndex(view_id);
            }
            catch
            {
                data_id = -1;
            }
            return data_id;
        }

        public static DataRow GetDataSourceRow(this DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            return node.TreeList.GetDataRow(node.Id);
        }

        public static DataRow GetDataSourceRow(this DevExpress.XtraTreeList.TreeList treeList)
        {
            if (treeList.FocusedNode != null)
                return treeList.GetDataRow(treeList.FocusedNode.Id);
            else
                return null;
        }

        public static DataRow GetDataSourceRow(this DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            int[] s = view.GetSelectedRows();
            if (s.Length == 0)
                return null;
            int rowHandle = s[0];
            return view.GetDataRow(rowHandle);
        }

        public static List<DataRow> GetDataSourceRowsByFilter(this GridView view, string FieldName, object Value)
        {
            List<DataRow> res = new List<DataRow>();
            if (view.GridControl.DataSource is DataTable)
            {
                foreach (DataRow row in (view.GridControl.DataSource as DataTable).Rows)
                {
                    try
                    {
                        if ((int)row[FieldName] == (int)Value)
                            res.Add(row);
                    }
                    catch { }
                }
            }
            else
            {
                throw new Exception("Тип данных должен быть DataTable");
            }
            return res;
        }

        public static int GetHitInfo_RowHandle(this DevExpress.XtraGrid.Views.Grid.GridView view, System.EventArgs e)
        {
            DevExpress.Utils.DXMouseEventArgs ea = e as DevExpress.Utils.DXMouseEventArgs;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = view.CalcHitInfo(ea.Location);
            if (hitInfo.InRowCell && !hitInfo.InGroupRow)
                return hitInfo.RowHandle;
            return -1;
        }

        public static object GetVal(this DevExpress.XtraVerticalGrid.VGridControl vgc, string Name, bool isNeedPref = false)
        {
            Name = (isNeedPref) ? "row" + Name : Name;
            return vgc.Rows[Name].Properties.Value;
        }

        public static void CheckBoxesPost(this GridView view)
        {
            foreach (GridColumn item in view.Columns)
            {
                GridColumn gc = item as GridColumn;
                if (gc.ColumnEdit != null)
                    if (gc.ColumnEdit is RepositoryItemCheckEdit)
                    {
                        (gc.ColumnEdit as RepositoryItemCheckEdit).EditValueChanged += ImmediatePost;
                    }
            }
        }

        public static void ImmediatePost(object sender, EventArgs e)
        {
            GridView gridView = null;
            if (sender is DevExpress.XtraEditors.BaseEdit)
                gridView = (((sender as DevExpress.XtraEditors.BaseEdit).Parent as GridControl).FocusedView as GridView);
            else
            if (sender is ToolStripMenuItem)
                gridView = ((((sender as ToolStripMenuItem).Owner as MenuStrip).Parent as GridControl).FocusedView as GridView);
            else
                return;
            if (!gridView.IsEditing)
                return;

            gridView.PostEditor();
            gridView.UpdateCurrentRow();
            gridView.CloseEditor();
            gridView.Focus();
        }

        public static void SetFilter(this DevExpress.XtraGrid.Views.Grid.GridView view, List<SerchColumn> Cols, string ColName, string SerchText)
        {
            // Подтираем все фильтры, которые установлены в cbSerchColumn
            foreach (SerchColumn cn in Cols)
            {
                view.Columns[cn.Name].FilterInfo = new ColumnFilterInfo();
            }

            if (string.IsNullOrEmpty(SerchText) || string.IsNullOrWhiteSpace(SerchText))
            {
                view.Columns[ColName].FilterInfo = new ColumnFilterInfo();
                return;
            }

            view.Columns[ColName].FilterInfo =
                new ColumnFilterInfo($"[{ColName}] LIKE '{SerchText}'"); // https://documentation.devexpress.com/WindowsForms/3013/Controls-and-Libraries/Data-Grid/Examples/Filtering/How-to-Apply-a-Filter-to-a-Column
        }

        public static void SetFilter(this DevExpress.XtraGrid.Views.Grid.GridView view, string ColName, string SerchText)
        {
            if (string.IsNullOrEmpty(SerchText) || string.IsNullOrWhiteSpace(SerchText))
            {
                view.Columns[ColName].FilterInfo = new ColumnFilterInfo();
                return;
            }

            view.Columns[ColName].FilterInfo =
                new ColumnFilterInfo($"[{ColName}] = '{SerchText}'"); // https://documentation.devexpress.com/WindowsForms/3013/Controls-and-Libraries/Data-Grid/Examples/Filtering/How-to-Apply-a-Filter-to-a-Column
        }

        public static void SetFilter(this DevExpress.XtraGrid.Views.Grid.GridView view, string ColName, List<string> SerchText)
        {
            string text = "";

            if (SerchText.Count == 0)
            {
                view.Columns[ColName].FilterInfo = new ColumnFilterInfo();
                return;
            }
            foreach (string item in SerchText)
            {
                if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
                    continue;

                text += (string.IsNullOrEmpty(text) ? "" : ",") + "'" + item + "'";
            }            

            view.Columns[ColName].FilterInfo =
                new ColumnFilterInfo($"[{ColName}] in ({text})"); // https://documentation.devexpress.com/WindowsForms/3013/Controls-and-Libraries/Data-Grid/Examples/Filtering/How-to-Apply-a-Filter-to-a-Column
        }

        public static void SetFilter(this DevExpress.XtraTreeList.TreeList view, string ColName, List<string> SerchText)
        {
            string text = "";

            if (SerchText.Count == 0)
            {
                view.Columns[ColName].FilterInfo = new DevExpress.XtraTreeList.Columns.TreeListColumnFilterInfo("");
                return;
            }
            foreach (string item in SerchText)
            {
                if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
                    continue;

                text += (string.IsNullOrEmpty(text) ? "" : ",") + "'" + item + "'";
            }

            view.Columns[ColName].FilterInfo =
                new DevExpress.XtraTreeList.Columns.TreeListColumnFilterInfo($"[{ColName}] in ({text})"); // https://documentation.devexpress.com/WindowsForms/3013/Controls-and-Libraries/Data-Grid/Examples/Filtering/How-to-Apply-a-Filter-to-a-Column
        }

        public static void ClearFilter(this DevExpress.XtraTreeList.TreeList view)
        {
            foreach (var c in view.Columns)
            {
                c.FilterInfo = new DevExpress.XtraTreeList.Columns.TreeListColumnFilterInfo("");
            }
        }

        public static void CreateGroupFolders(this TreeList tlFolders, DataTable Folders, int Concept)
        {
            int IndexColID = tlFolders.Columns["tlcID"].AbsoluteIndex;
            int IndexColNAME = tlFolders.Columns["tlcNAME"].AbsoluteIndex;

            tlFolders.Nodes.Clear();
            TreeListNode rootNode = tlFolders.Nodes.Add();
            rootNode.SetValue(IndexColID, 0);
            rootNode.SetValue(IndexColNAME, "<ВСЕ ГРУППЫ>");

            // Заполняем первый уровень
            foreach (DataRow row in Folders.Rows)
            {
                int LPARENT = (int)row["LPARENT"];
                int LID = (int)row["LID"];
                string LNAME = row["LNAME"].ToString();

                if (LPARENT == Concept)
                {
                    TreeListNode node = tlFolders.Nodes.Add();
                    node.SetValue(IndexColID, LID);
                    node.SetValue(IndexColNAME, LNAME);

                    row["IS_CREATED"] = 1;
                }
            }

            int rowCreatedCount = 0;
            int LastrowCreatedCount = 0;
            do
            {
                LastrowCreatedCount = rowCreatedCount;
                rowCreatedCount = 0;
                // Заполняем второй и последующие уровни
                foreach (DataRow row in Folders.Rows)
                {
                    int LPARENT = (int)row["LPARENT"];
                    int LID = (int)row["LID"];
                    string LNAME = row["LNAME"].ToString();

                    // Пропускаем уже созданные или не определенные
                    if ((int)row["IS_CREATED"] == 1)// || LPARENT == 0)
                    {
                        rowCreatedCount++;
                        continue;
                    }

                    // Просматриваем первый уровень
                    bool isCreated = CreateGroupFolder(tlFolders.Nodes, row, IndexColID, IndexColNAME, LPARENT, LID, LNAME);
                    if (isCreated)
                        rowCreatedCount++;
                }

                // В случае, когда последний проход и текущий принесли один и тот же результат
                // То есть, если никак не удалось привязать одиночные группы - просто выходим
                if (LastrowCreatedCount > 0 && LastrowCreatedCount == rowCreatedCount)
                    break;
            }
            while (rowCreatedCount != Folders.Rows.Count);
        }

        private static bool CreateGroupFolder(TreeListNodes Nodes, DataRow row, int IndexColID, int IndexColNAME, int LPARENT, int LID, string LNAME)
        {
            // Просматриваем первый уровень
            foreach (TreeListNode CurrNode in Nodes)
            {
                // Формируем второй уровень
                if (LPARENT == (int)CurrNode.GetValue(IndexColID))
                {
                    TreeListNode node = CurrNode.Nodes.Add();
                    node.SetValue(IndexColID, LID);
                    node.SetValue(IndexColNAME, LNAME);

                    row["IS_CREATED"] = 1;
                    return true;
                }
                else
                {
                    if (CurrNode.Nodes.Count > 0)
                    {
                        bool isCreated = CreateGroupFolder(CurrNode.Nodes, row, IndexColID, IndexColNAME, LPARENT, LID, LNAME);
                        if (isCreated)
                            return true;
                    }
                }
            }

            return false;
        }

        public static void GridSelectAll(this GridControl c, string colName, int flag)
        {
            DataTable table = ((DataView)c.MainView.DataSource).Table;
            DataView filteredDataView = new DataView(table);
            filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere((c.MainView as GridView).ActiveFilterCriteria);
            foreach (DataRowView rowv in filteredDataView)
            {
                rowv[colName] = flag;
            }
        }

        public static List<DataRow> GetSelected (this DataRowCollection Rows, string ColName = "HANDLE_SELECT", int val = 1)
        {
            List<DataRow> res = new List<DataRow>();

            if (Rows.Count > 0)
            {
                DataColumnCollection cols = Rows[0].Table.Columns;
                if (cols[ColName] != null)
                {
                    if (cols[ColName].DataType != typeof(int))
                        return res;
                }
                else
                    return res;
            }
            else
                return res;
            
            foreach (DataRow row in Rows)
            {
                if ((int)row[ColName] == val)
                    res.Add(row);
            }
            return res;
        }

        public static DataTable ToDataTable<T>(this List<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        public static void SetDefaultGridViewOptions(this GridView view)
        {
            Sys.SelectRow sysRow = new Sys.SelectRow();
            view.CustomDrawCell += sysRow.CustomDrawCell;
            view.FocusedRowChanged += sysRow.ColorRow;
            view.KeyPress += sysRow.ColorRow;
            view.RowCellClick += sysRow.RowCellClick; 
            view.RowCellStyle += sysRow.RowCellStyle;
            view.RowStyle += sysRow.RowStyle;
            view.MouseWheel += ViewMouseWheelFontSize;
            view.GridControl.ContextMenu = GridControlContextMenu(view);
            view.CheckBoxesPost();

            // Восстановить настройки таблицы
            view.GridControl.ContextMenu.MenuItems[1].PerformClick();

            view.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
            view.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
            view.OptionsBehavior.AllowIncrementalSearch = true;
            view.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDownFocused;
            view.OptionsBehavior.AllowIncrementalSearch = true;
            view.OptionsSelection.EnableAppearanceFocusedCell = false;
            view.OptionsSelection.EnableAppearanceFocusedRow = false;
            view.OptionsView.ColumnAutoWidth = false;
        }

        public static ContextMenu GridControlContextMenu(GridView view)
        {
            ContextMenu res = new ContextMenu();
            string xmlDir = $@"{Application.StartupPath}\xml\";
            string xmlFileName = $@"{Additional.GetParentToControl(view.GridControl).Name}_{view.Name}";
            string xmlFile = $@"{xmlDir}{xmlFileName}.xml";
            string xmlFileDef = $@"{xmlDir}{xmlFileName}_default.xml";
            try
            {
                if (!System.IO.Directory.Exists(xmlDir))
                    System.IO.Directory.CreateDirectory(xmlDir);
                view.SaveLayoutToXml(xmlFileDef);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            MenuItem miSave = new MenuItem();
            miSave.Text = "Сохранить настройки таблицы";
            miSave.Click += (object sender, EventArgs e) => {
                view.GridViewLayout("Save", xmlFile);
            };

            MenuItem miRestore = new MenuItem();
            miRestore.Text = "Восстановить настройки таблицы";
            miRestore.Click += (object sender, EventArgs e) => {
                view.GridViewLayout("Restore", xmlFile);
            };

            MenuItem miReset = new MenuItem();
            miReset.Text = "Сбросить настройки таблицы до значений по умолчанию";
            miReset.Click += (object sender, EventArgs e) => {
                view.GridViewLayout("Restore", xmlFileDef);
            };

            res.MenuItems.AddRange(new MenuItem[] { miSave, miRestore, miReset });            

            return res;
        }

        public static void GridViewLayout(this GridView view, string mode, string file)
        {
            switch (mode)
                {
                    case "Save":
                        try
                        {
                            view.SaveLayoutToXml(file);
                        }
                        catch { }
                        break;

                    case "Restore":
                        try
                        {
                            if (System.IO.File.Exists(file))
                                view.RestoreLayoutFromXml(file);
                        }
                        catch { }
                        break;

                    default:
                        return;
                        //throw new Exception("не определен режим работы");
                }
        }

        public static void ViewMouseWheelFontSize(object sender, MouseEventArgs e)
        {
            if (sender is GridView)
            {
                if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftCtrl))
                {
                    Font f = (sender as GridView).Appearance.Row.Font;
                    int i = (e.Delta > 0) ? 1 : -1;
                    if ((f.Size + i >= 5) && (f.Size + i <= 24))
                        (sender as GridView).Appearance.Row.Font = new Font(f.FontFamily, f.Size + i);
                }
            }
        }

        public static void CreateFormatRules(this GridView View, string Name, string ColName, string Expression, bool isGreen)
        {
            if (View.FormatRules[Name] != null)
                return;

            FormatConditionRuleExpression FCRE = new FormatConditionRuleExpression();
            FCRE.Expression = Expression;
            FCRE.PredefinedName = (isGreen) ? "Green Fill, Green Text" : "Red Fill, Red Text";
            FCRE.AllowAnimation = DefaultBoolean.False;

            GridFormatRule GFR = new GridFormatRule();
            GFR.Column = View.Columns[ColName];
            GFR.Name = Name;
            GFR.Rule = FCRE;
            GFR.ApplyToRow = true;
            View.FormatRules.Add(GFR);
        }

        public static void CreateFormatRules(this GridView View, string Name, string ColName, string Expression, Color BackColor, Color ForeColor)
        {
            if (View.FormatRules[Name] != null)
                return;

            FormatConditionRuleExpression FCRE = new FormatConditionRuleExpression();
            FCRE.Expression = Expression;
            FCRE.Appearance.BackColor = BackColor;
            FCRE.Appearance.ForeColor = ForeColor;
            FCRE.AllowAnimation = DefaultBoolean.False;

            GridFormatRule GFR = new GridFormatRule();
            GFR.Column = View.Columns[ColName];
            GFR.Name = Name;
            GFR.Rule = FCRE;
            GFR.ApplyToRow = true;
            View.FormatRules.Add(GFR);
        }

        public static void CreateFormatRules(this TreeList View, string Name, string ColName, string Expression, bool isGreen)
        {
            if (View.FormatRules[Name] != null)
                return;

            FormatConditionRuleExpression FCRE = new FormatConditionRuleExpression();
            FCRE.Expression = Expression;
            FCRE.PredefinedName = (isGreen) ? "Green Fill, Green Text" : "Red Fill, Red Text";
            FCRE.AllowAnimation = DefaultBoolean.False;

            TreeListFormatRule TLFR = new TreeListFormatRule();
            TLFR.Column = View.Columns[ColName];
            TLFR.Name = Name;
            TLFR.Rule = FCRE;
            TLFR.ApplyToRow = true;
            View.FormatRules.Add(TLFR);
        }

        public static List<DataRow> GetFilteredRows(this GridView view)
        {
            List<DataRow> res = new List<DataRow>();
            DataTable table = ((DataView)view.DataSource).Table;
            DataView filteredDataView = new DataView(table);
            filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(view.ActiveFilterCriteria);
            foreach (DataRowView rowv in filteredDataView)
            {
                res.Add(rowv.Row);
            }
            return res;
        }

        /// <summary>
        /// Установить строки VGridControl в ReadOnly
        /// </summary>
        /// <param name="ctrl"></param>
        public static void SetReadOnlyVGridRows(this VGridControl ctrl)
        {
            foreach (BaseRow row in ctrl.Rows)
            {
                SetReadOnlyVGridRows_Child(row);
            }
        }
        /// <summary>
        /// Установить дочерние строки VGridControl в ReadOnly
        /// </summary>
        /// <param name="row"></param>
        private static void SetReadOnlyVGridRows_Child(BaseRow row)
        {
            if (row.ChildRows.Count == 0)
            {
                row.Properties.AllowEdit = true;
                row.Properties.ReadOnly = true;
            }
            else
            {
                foreach (BaseRow ChildRow in row.ChildRows)
                {
                    SetReadOnlyVGridRows_Child(ChildRow);
                    ChildRow.Properties.AllowEdit = true;
                    ChildRow.Properties.ReadOnly = true;
                }
            }
        }
    }
}
