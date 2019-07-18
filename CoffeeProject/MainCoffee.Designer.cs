namespace CoffeeProject
{
    partial class MainCoffee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCoffee));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.listCoffee = new System.Windows.Forms.ListBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.picCoffee = new System.Windows.Forms.PictureBox();
            this.backgroundCF = new System.Windows.Forms.PictureBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsCoffee = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbName);
            this.splitContainer1.Panel1.Controls.Add(this.picCoffee);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.backgroundCF);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAccount);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.listCoffee);
            this.splitContainer1.Panel2.Controls.Add(this.btnProceed);
            this.splitContainer1.Panel2.Controls.Add(this.txtFilter);
            this.splitContainer1.Size = new System.Drawing.Size(650, 488);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.TotalPrice);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 149);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(323, 17);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(85, 13);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "labelPrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price Each:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add To Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(303, 66);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(105, 25);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "label2";
            // 
            // amountBox
            // 
            this.amountBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.amountBox.Location = new System.Drawing.Point(308, 43);
            this.amountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(120, 20);
            this.amountBox.TabIndex = 3;
            this.amountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountBox.ValueChanged += new System.EventHandler(this.amountBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(3, 3);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(222, 146);
            this.txtDesc.TabIndex = 0;
            // 
            // listCoffee
            // 
            this.listCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCoffee.FormattingEnabled = true;
            this.listCoffee.ItemHeight = 24;
            this.listCoffee.Location = new System.Drawing.Point(3, 75);
            this.listCoffee.Name = "listCoffee";
            this.listCoffee.Size = new System.Drawing.Size(193, 340);
            this.listCoffee.TabIndex = 3;
            this.listCoffee.SelectedValueChanged += new System.EventHandler(this.listCoffee_SelectedValueChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(3, 441);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(192, 35);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed to Order";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.AcceptsReturn = true;
            this.txtFilter.Location = new System.Drawing.Point(27, 49);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(168, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // lbName
            // 
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Image = global::CoffeeProject.Properties.Resources.Cafe_background_1;
            this.lbName.Location = new System.Drawing.Point(117, 279);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(219, 39);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "coffeeName";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCoffee
            // 
            this.picCoffee.Location = new System.Drawing.Point(150, 145);
            this.picCoffee.Name = "picCoffee";
            this.picCoffee.Size = new System.Drawing.Size(166, 122);
            this.picCoffee.TabIndex = 2;
            this.picCoffee.TabStop = false;
            // 
            // backgroundCF
            // 
            this.backgroundCF.Image = global::CoffeeProject.Properties.Resources.Cafe_background_1;
            this.backgroundCF.Location = new System.Drawing.Point(0, 3);
            this.backgroundCF.Name = "backgroundCF";
            this.backgroundCF.Size = new System.Drawing.Size(449, 333);
            this.backgroundCF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundCF.TabIndex = 0;
            this.backgroundCF.TabStop = false;
            // 
            // btnAccount
            // 
            this.btnAccount.BackgroundImage = global::CoffeeProject.Properties.Resources._219377_200;
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.Location = new System.Drawing.Point(146, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(40, 40);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Tag = "Account Information";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeProject.Properties.Resources.f9bb81e576c1a361c61a8c08945b2c48_search_icon_by_vexels;
            this.pictureBox1.Location = new System.Drawing.Point(3, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 488);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainCoffee";
            this.Text = "MainCoffee";
            this.Load += new System.EventHandler(this.MainCoffee_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCoffee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picCoffee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.PictureBox backgroundCF;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.BindingSource bsCoffee;
        private System.Windows.Forms.ListBox listCoffee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAccount;
    }
}