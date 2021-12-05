using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMarkingUI.Views
{
    public partial class GtinInfoView : UserControl
    {
        public GtinInfoView()
        {
            InitializeComponent();
            this.Text = "Реестр производимых ЛП";
            Tag = true;
        }

        private void tsmi851_Click(object sender, EventArgs e)
        {
            //8.5.1.Метод для получения информации из реестра производимых организацией ЛП
        }

        private void tsmi852_Click(object sender, EventArgs e)
        {
            //8.5.2. Метод для получения детальной информации о производимом организацией ЛП
        }

        private void tsmi853_Click(object sender, EventArgs e)
        {
            //8.5.3. Метод для поиска публичной информации в реестре производимых ЛП
        }

        private void tsmi854_Click(object sender, EventArgs e)
        {
            //8.5.4 Метод для получения информации о производимом ЛП
        }
    }
}
