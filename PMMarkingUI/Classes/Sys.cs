using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.StyleFormatConditions;
using DevExpress.XtraEditors.Repository;

namespace Sys
{
    /// <summary>
    /// Sys.[Окраска и выделение строк]
    /// </summary>
    public class SelectRow
    {
        #region Свойства
        Color selectRowColor1 = System.Drawing.SystemColors.MenuHighlight;//Color.Wheat;
        Color selectRowColor2 = Color.White;
        Color foreColor = Color.White;
        public int rowHandle { get; set; }
        #endregion
        #region Конструкторы
        public SelectRow(int rowHandle = GridControl.InvalidRowHandle)
        {
            this.rowHandle = rowHandle;
        }
        #endregion
        #region Методы
        public void RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle)
            {
                e.Appearance.BackColor = selectRowColor1;
                e.Appearance.ForeColor = foreColor;
                // Градиент
                //e.Appearance.BackColor2 = selectRowColor2;
                e.HighPriority = true;
            }
        }

        public void RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle)
            {
                e.Appearance.BackColor = selectRowColor1;
                e.Appearance.ForeColor = foreColor;
                // Градиент
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        public void CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == rowHandle)
            {
                e.Appearance.BackColor = selectRowColor1;
                // Градиент
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        /// <summary>
        /// Окрас строки по Click/DoubleClick указанной GridView
        /// </summary>
        /// <param name="sender">GridView</param>
        /// <param name="e">DXMouseEventArgs</param>
        public void ColorRow(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo hitInfo = view.CalcHitInfo(ea.Location);
            if (hitInfo.InRowCell)
            {
                ColorRow(sender, hitInfo.RowHandle);
            }
        }

        /// <summary>
        /// Автоматическое переключение CheckBox в строке, если указан ColumnEdit = RepositoryItemCheckEdit + Окрас строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RowCellClick(object sender, EventArgs e)
        {
            ColorRow(sender, e);

            GridView view = sender as GridView;
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo hitInfo = view.CalcHitInfo(ea.Location);
            if (hitInfo.InRowCell && /*view.OptionsBehavior.Editable &&*/ !view.OptionsBehavior.ReadOnly)
            {
                if (hitInfo.Column.ColumnEdit != null && hitInfo.RowInfo.RowKey != null)
                {
                    if (
                        hitInfo.Column.ColumnEdit.Editable && // Редактируемое
                        !hitInfo.Column.ReadOnly && // Не только для чтения
                        (hitInfo.RowInfo.RowKey is DataRow) // Данные имеют вид DataRow
                    )
                    {
                        Type ceType = hitInfo.Column.ColumnEdit.GetType();
                        if (ceType == typeof(RepositoryItemCheckEdit))
                        {
                            var ce = (hitInfo.Column.ColumnEdit as RepositoryItemCheckEdit);
                            try
                            {
                                DataRow row = (hitInfo.RowInfo.RowKey as DataRow);
                                if (row != null)
                                {
                                    row[hitInfo.Column.FieldName] =
                                    ((int)row[hitInfo.Column.FieldName] != (int)ce.ValueChecked)
                                    ? ce.ValueChecked
                                    : ce.ValueUnchecked;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Окрас строки по FocusedRowChange указанной GridView
        /// </summary>
        /// <param name="sender">GridView</param>
        /// <param name="e">DXMouseEventArgs</param>
        public void ColorRow(object sender, FocusedRowChangedEventArgs e)
        {
            ColorRow(sender, e.FocusedRowHandle);
        }

        /// <summary>
        /// Окрас строки указанной GridView
        /// </summary>
        /// <param name="sender">GridView</param>
        /// <param name="iRowHandle">Index строки</param>
        public void ColorRow(object sender, int iRowHandle)
        {
            GridView view = sender as GridView;
            rowHandle = iRowHandle;
            view.LayoutChanged();
        }

        /// <summary>
        /// Окрас при нажатии на кнопку "Enter" указанной GridView
        /// </summary>
        /// <param name="sender">GridView</param>
        /// <param name="e">e.KeyChar == (char)13</param>
        public void ColorRow(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ColorRow(sender, (sender as GridView).GetSelectedRows()[0]);
            }
        }
        #endregion
    }

    /// <summary>
    /// Sys.[Работа с колонками и фильтрами]
    /// </summary>
    public static class GridColumns
    {
        public static void CreateFormatRules(GridView View, string Name, string ColName, string Expression, bool isGreen)
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

        public static void CreateFormatRules(TreeList View, string Name, string ColName, string Expression, bool isGreen)
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
    }

    /// <summary>
    /// Sys.[Работа с данными]
    /// </summary>
    public static class Data
    {
        /// <summary>
        /// Завершение редактирования с сохранением изменений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ImmediatePost(object sender, EventArgs e)
        {
            var baseEdit = sender as DevExpress.XtraEditors.BaseEdit;
            var gridView = ((baseEdit.Parent as GridControl).FocusedView as GridView);
            gridView.PostEditor(); // Сохраняет значение активного редактора в источнике данных без закрытия и позволяет пользователю продолжить изменение значения
            //gridView.UpdateCurrentRow(); // Вроде как сохраняет все значения строки
            gridView.ActiveEditor.Hide();
            gridView.Focus();
        }
    }
}
