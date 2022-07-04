namespace Client
{
    partial class MainMenu
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
            this.Clerk_But = new System.Windows.Forms.Button();
            this.Cake_button = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clerk_But
            // 
            this.Clerk_But.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clerk_But.Location = new System.Drawing.Point(47, 39);
            this.Clerk_But.Name = "Clerk_But";
            this.Clerk_But.Size = new System.Drawing.Size(197, 44);
            this.Clerk_But.TabIndex = 0;
            this.Clerk_But.Text = "Clerk";
            this.Clerk_But.UseVisualStyleBackColor = true;
            this.Clerk_But.Click += new System.EventHandler(this.Clerk_But_Click);
            // 
            // Cake_button
            // 
            this.Cake_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cake_button.Location = new System.Drawing.Point(47, 98);
            this.Cake_button.Name = "Cake_button";
            this.Cake_button.Size = new System.Drawing.Size(197, 44);
            this.Cake_button.TabIndex = 1;
            this.Cake_button.Text = "Cake";
            this.Cake_button.UseVisualStyleBackColor = true;
            this.Cake_button.Click += new System.EventHandler(this.Cake_button_Click);
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer.Location = new System.Drawing.Point(47, 159);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(197, 44);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(47, 351);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(197, 44);
            this.Back.TabIndex = 3;
            this.Back.Text = "Log Out";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 420);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Cake_button);
            this.Controls.Add(this.Clerk_But);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Clerk_But;
        private Button Cake_button;
        private Button Customer;
        private Button Back;
    }
}