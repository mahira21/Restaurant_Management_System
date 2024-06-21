namespace ResManaged3.UI.Elements
{
    partial class CartItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPriceEach = new System.Windows.Forms.Label();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(35, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 1);
            this.panel1.TabIndex = 0;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.ForeColor = System.Drawing.Color.DimGray;
            this.lblItemName.Location = new System.Drawing.Point(127, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(280, 69);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(407, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 69);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceEach
            // 
            this.lblPriceEach.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceEach.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPriceEach.ForeColor = System.Drawing.Color.DimGray;
            this.lblPriceEach.Location = new System.Drawing.Point(499, 0);
            this.lblPriceEach.Name = "lblPriceEach";
            this.lblPriceEach.Size = new System.Drawing.Size(92, 69);
            this.lblPriceEach.TabIndex = 4;
            this.lblPriceEach.Text = "Price Each";
            this.lblPriceEach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPriceTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblPriceTotal.Location = new System.Drawing.Point(591, 0);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(92, 69);
            this.lblPriceTotal.TabIndex = 5;
            this.lblPriceTotal.Text = "Price Total";
            this.lblPriceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblCode.Location = new System.Drawing.Point(35, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(92, 69);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Code";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(85)))), ((int)(((byte)(35)))));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CartItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPriceEach);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblPriceTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(683, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPriceEach;
        private System.Windows.Forms.Label lblPriceTotal;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button button2;
    }
}
