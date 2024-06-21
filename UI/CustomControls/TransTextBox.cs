using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.CustomControls
{
    class TransTextBox : TextBox
    {
        Color bottomBorderColor = Color.Black;
        Label bottomBorder = new Label();
        public Color BottomBorderColor
        {
            get { return bottomBorderColor; }
            set
            {
                bottomBorderColor = value;
                bottomBorder.BackColor = BottomBorderColor;
                Invalidate();
            }
        }
        




        public TransTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw, true);
            bottomBorder.Height = 1;
            bottomBorder.Dock = DockStyle.Bottom;
            bottomBorder.BackColor = BottomBorderColor;

            Controls.Add(bottomBorder);

            


            BorderStyle = System.Windows.Forms.BorderStyle.None;


            AutoSize = false; //Allows you to change height to have bottom padding

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            base.OnKeyUp(e);
        }


    }
}
