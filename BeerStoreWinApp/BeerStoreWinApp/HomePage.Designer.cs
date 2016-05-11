namespace BeerStoreWinApp
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.button_shopForBeer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_shopForBeer
            // 
            this.button_shopForBeer.Location = new System.Drawing.Point(756, 20);
            this.button_shopForBeer.Name = "button_shopForBeer";
            this.button_shopForBeer.Size = new System.Drawing.Size(155, 40);
            this.button_shopForBeer.TabIndex = 0;
            this.button_shopForBeer.Text = "Shop For Beer";
            this.button_shopForBeer.UseVisualStyleBackColor = true;
            this.button_shopForBeer.Click += new System.EventHandler(this.button_shopForBeer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Where everyone in the galaxy shops";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(756, 66);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(155, 41);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 519);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_shopForBeer);
            this.Name = "HomePage";
            this.Text = "Storm Trooper Beer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_shopForBeer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
    }
}

