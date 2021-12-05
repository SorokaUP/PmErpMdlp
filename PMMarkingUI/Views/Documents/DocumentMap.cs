using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;

namespace PMMarkingUI.Views
{
    public partial class DocumentMap : UserControl
    {
        /*
            0 - стрелка вправо
            1 - стрелка вправо-вниз
            2 - ожидание
            3 - финиш
        */

        public DocumentMap(int ShemaNum) // (int doc_id)
        {
            InitializeComponent();
            DataTable shema = DAO.GetShemaMap(ShemaNum);

            int LocationX = 10;
            int LocationY = 10;
            int LocationStep = 10;
            Label pShema = new Label();
            PictureBox iNext = new PictureBox();

            PictureBox start = CreateImage(Properties.Resources.shema_start, LocationX, LocationY);
            LocationX = start.Location.X + start.Width + LocationStep;
            foreach (DataRow row in shema.Rows)
            {
                if ((int)row["PARENT"] == 0)
                {
                    pShema = CreateShema(row["SHEMA_FROM"].ToString(), LocationX, LocationY);
                    pShema.Tag = (int)row["ID"];
                    iNext = CreateImage(Properties.Resources.arrow_right, LocationX + pShema.Width + LocationStep, LocationY);
                    LocationX = iNext.Location.X + iNext.Width + LocationStep;

                    pShema = CreateShema(row["SHEMA_TO"].ToString(), LocationX, LocationY);
                    iNext = CreateImage(Properties.Resources.arrow_right, LocationX + pShema.Width + LocationStep, LocationY);
                    LocationX = iNext.Location.X + iNext.Width + LocationStep;
                }
            }
            PictureBox finish = CreateImage(Properties.Resources.finish, LocationX, LocationY);

            LocationY += pShema.Height + LocationStep;
            foreach (DataRow row in shema.Rows)
            {
                if ((int)row["PARENT"] != 0)
                {
                    pShema = CreateShema(row["SHEMA_TO"].ToString(), LocationX, LocationY);
                    pShema.Tag = (int)row["ID"];
                    iNext = CreateImage(Properties.Resources.arrow_right, LocationX + pShema.Width + LocationStep, LocationY);
                    LocationX = iNext.Location.X + iNext.Width + LocationStep;
                }
            }

            /*switch (ShemaNum)
            {
                case 601:
                    PictureBox start = CreateImage(Properties.Resources.shema_start, 10, 10);
                    Label p601 = CreateShema("601", start.Location.X + start.Width + 10, start.Location.Y);
                    PictureBox i601next = CreateImage(Properties.Resources.arrow_right, p601.Location.X + p601.Width + 10, p601.Location.Y);
                    PictureBox i601more = CreateImage(Properties.Resources.arrow_right_down, p601.Location.X + 10, p601.Location.Y + p601.Height + 10);
                    Label p220 = CreateShema("220", i601more.Location.X + i601more.Width + 10, i601more.Location.Y);
                    PictureBox i220next = CreateImage(Properties.Resources.arrow_right, p220.Location.X + p220.Width + 10, p220.Location.Y);
                    Label p912 = CreateShema("912", i220next.Location.X + i220next.Width + 10, i220next.Location.Y);

                    Label p701 = CreateShema("701", i601next.Location.X + i601next.Width + 10, start.Location.Y);
                    PictureBox i701next = CreateImage(Properties.Resources.arrow_right, p701.Location.X + p701.Width + 10, p701.Location.Y);
                    Label p431 = CreateShema("431", i701next.Location.X + i701next.Width + 10, start.Location.Y);
                    PictureBox finish = CreateImage(Properties.Resources.finish, p431.Location.X + p431.Width + 10, start.Location.Y);
                    break;
            }*/
        }

        private Label CreateShema(string Text, int X, int Y)
        {
            Label l = new Label();
            l.Parent = this;
            l.AutoSize = false;
            l.Location = new Point(X, Y);
            l.Size = new Size(50, 30);
            l.Text = Text;
            l.BorderStyle = BorderStyle.FixedSingle;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Font = new Font(l.Font.FontFamily, 10);

            return l;
        }

        private PictureBox CreateImage(Image img, int X, int Y)
        {
            PictureBox p = new PictureBox();
            p.Parent = this;
            //i701.Image = imgIcons.Images[3];
            p.Image = img;
            p.Location = new Point(X, Y);
            p.Size = new Size(30, 30);

            return p;
        }
    }
}
