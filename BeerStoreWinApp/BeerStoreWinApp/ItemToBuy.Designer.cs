namespace BeerStoreWinApp
{
    partial class ItemToBuy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.domainUpDown_quantity = new System.Windows.Forms.DomainUpDown();
            this.label_name = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // button_addToCart
            // 
            this.button_addToCart.Location = new System.Drawing.Point(47, 249);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(132, 23);
            this.button_addToCart.TabIndex = 2;
            this.button_addToCart.Text = "Add To Cart";
            this.button_addToCart.UseVisualStyleBackColor = true;
            this.button_addToCart.Click += new System.EventHandler(this.button_addBeerToCart_Click);
            // 
            // domainUpDown_quantity
            // 
            this.domainUpDown_quantity.Items.Add("1");
            this.domainUpDown_quantity.Items.Add("2");
            this.domainUpDown_quantity.Items.Add("3");
            this.domainUpDown_quantity.Items.Add("4");
            this.domainUpDown_quantity.Items.Add("5");
            this.domainUpDown_quantity.Items.Add("6");
            this.domainUpDown_quantity.Items.Add("7");
            this.domainUpDown_quantity.Items.Add("8");
            this.domainUpDown_quantity.Items.Add("9");
            this.domainUpDown_quantity.Items.Add("10");
            this.domainUpDown_quantity.Location = new System.Drawing.Point(124, 216);
            this.domainUpDown_quantity.Name = "domainUpDown_quantity";
            this.domainUpDown_quantity.ReadOnly = true;
            this.domainUpDown_quantity.Size = new System.Drawing.Size(55, 22);
            this.domainUpDown_quantity.TabIndex = 3;
            this.domainUpDown_quantity.Text = "0";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(32, 21);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(21, 147);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ReadOnly = true;
            this.richTextBox_description.Size = new System.Drawing.Size(185, 63);
            this.richTextBox_description.TabIndex = 6;
            this.richTextBox_description.Text = "";
            // 
            // ItemToBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.domainUpDown_quantity);
            this.Controls.Add(this.button_addToCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ItemToBuy";
            this.Size = new System.Drawing.Size(235, 285);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addToCart;
        private System.Windows.Forms.DomainUpDown domainUpDown_quantity;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.RichTextBox richTextBox_description;
    }
}
