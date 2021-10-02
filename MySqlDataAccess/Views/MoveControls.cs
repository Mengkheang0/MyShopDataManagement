using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlDataAccess.Views
{
    public class MoveControls
    {
        private Point OldLc, NewLc;
        private bool _move;
        private Control frm;
        private int mx, my, bx, by;
        public void MoveForm(Control f)
        {
            foreach (Control item in f.Controls)
            {
                frm = f;
                item.MouseDown += Item_MouseDown;
                item.MouseMove += Item_MouseMove;
                item.MouseUp += Item_MouseUp;
                Console.WriteLine(item);
            }
        }

        private void Item_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move)
            {
                mx = Cursor.Position.X - bx;
                my = Cursor.Position.Y - by;
                frm.Location = new Point(mx, my);
                frm.Update();
            }
        }

        private void Item_MouseUp(object sender, MouseEventArgs e)
        {
            _move = false;
        }

        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            _move = true;
            OldLc = e.Location;
            bx = Cursor.Position.X - frm.Bounds.X;
            by = Cursor.Position.Y - frm.Bounds.Y;
        }
    }
}
