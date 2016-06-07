namespace BeerStoreWinApp
{
    partial class StuffToBuy
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Beer = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Munchies = new System.Windows.Forms.TabPage();
            this.button_viewCart = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_Beer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_Beer);
            this.tabControl.Controls.Add(this.tabPage_Munchies);
            this.tabControl.Location = new System.Drawing.Point(0, 58);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(696, 492);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Beer
            // 
            this.tabPage_Beer.AutoScroll = true;
            this.tabPage_Beer.Controls.Add(this.label1);
            this.tabPage_Beer.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Beer.Name = "tabPage_Beer";
            this.tabPage_Beer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Beer.Size = new System.Drawing.Size(688, 463);
            this.tabPage_Beer.TabIndex = 0;
            this.tabPage_Beer.Text = "Beer";
            this.tabPage_Beer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose from our large selection of beers";
            // 
            // tabPage_Munchies
            // 
            this.tabPage_Munchies.AutoScroll = true;
            this.tabPage_Munchies.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Munchies.Name = "tabPage_Munchies";
            this.tabPage_Munchies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Munchies.Size = new System.Drawing.Size(688, 463);
            this.tabPage_Munchies.TabIndex = 1;
            this.tabPage_Munchies.Text = "Munchies";
            this.tabPage_Munchies.UseVisualStyleBackColor = true;
            // 
            // button_viewCart
            // 
            this.button_viewCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_viewCart.Location = new System.Drawing.Point(505, 12);
            this.button_viewCart.Name = "button_viewCart";
            this.button_viewCart.Size = new System.Drawing.Size(167, 52);
            this.button_viewCart.TabIndex = 1;
            this.button_viewCart.Text = "View Shopping Cart";
            this.button_viewCart.UseVisualStyleBackColor = true;
            this.button_viewCart.Click += new System.EventHandler(this.button_viewCart_Click);
            // 
            // StuffToBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 549);
            this.Controls.Add(this.button_viewCart);
            this.Controls.Add(this.tabControl);
            this.Name = "StuffToBuy";
            this.Text = "StuffToBuy";
            this.tabControl.ResumeLayout(false);
            this.tabPage_Beer.ResumeLayout(false);
            this.tabPage_Beer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Beer;
        private System.Windows.Forms.TabPage tabPage_Munchies;
        private System.Windows.Forms.Button button_viewCart;
        private System.Windows.Forms.Label label1;
    }
}