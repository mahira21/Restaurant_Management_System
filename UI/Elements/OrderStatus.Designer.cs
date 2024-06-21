namespace ResManaged3.UI.Elements
{
    partial class OrderStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlBottom2 = new System.Windows.Forms.Panel();
            this.pnlDiv1 = new System.Windows.Forms.Panel();
            this.pnlDiv2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(700, 1);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 39);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 85);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(700, 15);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlBottom2
            // 
            this.pnlBottom2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom2.Location = new System.Drawing.Point(0, 84);
            this.pnlBottom2.Name = "pnlBottom2";
            this.pnlBottom2.Size = new System.Drawing.Size(700, 1);
            this.pnlBottom2.TabIndex = 3;
            // 
            // pnlDiv1
            // 
            this.pnlDiv1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDiv1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiv1.Location = new System.Drawing.Point(0, 40);
            this.pnlDiv1.Name = "pnlDiv1";
            this.pnlDiv1.Size = new System.Drawing.Size(700, 1);
            this.pnlDiv1.TabIndex = 4;
            // 
            // pnlDiv2
            // 
            this.pnlDiv2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDiv2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDiv2.Location = new System.Drawing.Point(0, 83);
            this.pnlDiv2.Name = "pnlDiv2";
            this.pnlDiv2.Size = new System.Drawing.Size(700, 1);
            this.pnlDiv2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(165, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDiv2);
            this.Controls.Add(this.pnlDiv1);
            this.Controls.Add(this.pnlBottom2);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OrderStatus";
            this.Size = new System.Drawing.Size(700, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlBottom2;
        private System.Windows.Forms.Panel pnlDiv1;
        private System.Windows.Forms.Panel pnlDiv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
