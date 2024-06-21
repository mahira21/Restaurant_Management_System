namespace ResManaged3.UI.Elements
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbFoodPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(205, 1);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 1);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1, 279);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(1, 279);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(204, 1);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(204, 1);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1, 278);
            this.pnlRight.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.lblPriceTag);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pbFoodPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(203, 278);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.btnAddToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(26, 240);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(150, 30);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            this.btnAddToCart.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.btnAddToCart.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblPriceTag.Location = new System.Drawing.Point(90, 219);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(29, 17);
            this.lblPriceTag.TabIndex = 4;
            this.lblPriceTag.Text = "$25";
            this.lblPriceTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPriceTag.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.lblPriceTag.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(3, 153);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(14, 4, 10, 4);
            this.lblDescription.Size = new System.Drawing.Size(197, 57);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDescription.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.lblDescription.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(14, 4, 10, 4);
            this.lblTitle.Size = new System.Drawing.Size(197, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "American Hamburger With Extra Cheeze";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // pbFoodPic
            // 
            this.pbFoodPic.BackColor = System.Drawing.Color.White;
            this.pbFoodPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFoodPic.Image = ((System.Drawing.Image)(resources.GetObject("pbFoodPic.Image")));
            this.pbFoodPic.Location = new System.Drawing.Point(3, 4);
            this.pbFoodPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbFoodPic.Name = "pbFoodPic";
            this.pbFoodPic.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbFoodPic.Size = new System.Drawing.Size(197, 104);
            this.pbFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodPic.TabIndex = 0;
            this.pbFoodPic.TabStop = false;
            this.pbFoodPic.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pbFoodPic.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12, 7, 6, 7);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(205, 280);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbFoodPic;
        private System.Windows.Forms.Label lblPriceTag;
        private System.Windows.Forms.Button btnAddToCart;
    }
}
