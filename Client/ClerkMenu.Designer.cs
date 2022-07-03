namespace Client
{
    partial class MyClerkMenu
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
            this.back_button = new System.Windows.Forms.Button();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.IsAdmin_check = new System.Windows.Forms.CheckBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Select_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.apply_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(614, 232);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(78, 23);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 23);
            this.Name_txt.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 26);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(78, 52);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(100, 23);
            this.Phone_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(78, 81);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(100, 23);
            this.Address_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(78, 110);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(100, 23);
            this.UserName_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(78, 139);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(100, 23);
            this.Password_txt.TabIndex = 9;
            // 
            // IsAdmin_check
            // 
            this.IsAdmin_check.AutoSize = true;
            this.IsAdmin_check.Location = new System.Drawing.Point(78, 168);
            this.IsAdmin_check.Name = "IsAdmin_check";
            this.IsAdmin_check.Size = new System.Drawing.Size(62, 19);
            this.IsAdmin_check.TabIndex = 11;
            this.IsAdmin_check.Text = "Admin";
            this.IsAdmin_check.UseVisualStyleBackColor = true;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(93, 203);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 12;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Select_button
            // 
            this.Select_button.Location = new System.Drawing.Point(93, 232);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(75, 23);
            this.Select_button.TabIndex = 13;
            this.Select_button.Text = "Select";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(275, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(495, 191);
            this.dataGridView2.TabIndex = 15;
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(695, 232);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 16;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // MyClerkMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.IsAdmin_check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.back_button);
            this.Text = "Clerk Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back_button;
        private TextBox Name_txt;
        private Label Name;
        private Label label2;
        private TextBox Phone_txt;
        private Label label3;
        private TextBox Address_txt;
        private Label label4;
        private TextBox UserName_txt;
        private Label label5;
        private TextBox Password_txt;
        private CheckBox IsAdmin_check;
        private Button Add_button;
        private Button Select_button;
        private DataGridView dataGridView2;
        private Button apply_button;
    }
}