namespace Client
{
    partial class OrderMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.count_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_add_button = new System.Windows.Forms.Button();
            this.Apply_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Add_Order_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hour_txt = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.ordernumber_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ordercode_txt = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.output_csv_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(280, 188);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(347, 160);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // count_txt
            // 
            this.count_txt.Location = new System.Drawing.Point(104, 55);
            this.count_txt.Name = "count_txt";
            this.count_txt.Size = new System.Drawing.Size(121, 23);
            this.count_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product:";
            // 
            // product_add_button
            // 
            this.product_add_button.Location = new System.Drawing.Point(129, 84);
            this.product_add_button.Name = "product_add_button";
            this.product_add_button.Size = new System.Drawing.Size(75, 23);
            this.product_add_button.TabIndex = 6;
            this.product_add_button.Text = "Add";
            this.product_add_button.UseVisualStyleBackColor = true;
            this.product_add_button.Click += new System.EventHandler(this.product_add_button_Click);
            // 
            // Apply_button
            // 
            this.Apply_button.Location = new System.Drawing.Point(552, 371);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(75, 23);
            this.Apply_button.TabIndex = 7;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = true;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(390, 371);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 223);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // Add_Order_button
            // 
            this.Add_Order_button.Location = new System.Drawing.Point(129, 252);
            this.Add_Order_button.Name = "Add_Order_button";
            this.Add_Order_button.Size = new System.Drawing.Size(75, 23);
            this.Add_Order_button.TabIndex = 10;
            this.Add_Order_button.Text = "Add";
            this.Add_Order_button.UseVisualStyleBackColor = true;
            this.Add_Order_button.Click += new System.EventHandler(this.Add_Order_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer:";
            // 
            // Hour_txt
            // 
            this.Hour_txt.Location = new System.Drawing.Point(104, 190);
            this.Hour_txt.Name = "Hour_txt";
            this.Hour_txt.Size = new System.Drawing.Size(121, 23);
            this.Hour_txt.TabIndex = 13;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(129, 113);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_button.TabIndex = 14;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(129, 350);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(75, 23);
            this.select_button.TabIndex = 15;
            this.select_button.Text = "select";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // ordernumber_txt
            // 
            this.ordernumber_txt.Location = new System.Drawing.Point(104, 291);
            this.ordernumber_txt.Name = "ordernumber_txt";
            this.ordernumber_txt.Size = new System.Drawing.Size(121, 23);
            this.ordernumber_txt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Order Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Order Code";
            // 
            // ordercode_txt
            // 
            this.ordercode_txt.Location = new System.Drawing.Point(104, 320);
            this.ordercode_txt.Name = "ordercode_txt";
            this.ordercode_txt.Size = new System.Drawing.Size(121, 23);
            this.ordercode_txt.TabIndex = 19;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(129, 142);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 20;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // output_csv_button
            // 
            this.output_csv_button.Location = new System.Drawing.Point(471, 371);
            this.output_csv_button.Name = "output_csv_button";
            this.output_csv_button.Size = new System.Drawing.Size(75, 23);
            this.output_csv_button.TabIndex = 21;
            this.output_csv_button.Text = "Export";
            this.output_csv_button.UseVisualStyleBackColor = true;
            this.output_csv_button.Click += new System.EventHandler(this.output_csv_button_Click);
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 423);
            this.Controls.Add(this.output_csv_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.ordercode_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ordernumber_txt);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Hour_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add_Order_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Apply_button);
            this.Controls.Add(this.product_add_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderMenu";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private TextBox count_txt;
        private Label label1;
        private Label label2;
        private Button product_add_button;
        private Button Apply_button;
        private Button back_button;
        private ComboBox comboBox2;
        private Button Add_Order_button;
        private Label label3;
        private Label label4;
        private TextBox Hour_txt;
        private Button Remove_button;
        private Button select_button;
        private TextBox ordernumber_txt;
        private Label label5;
        private Label label6;
        private TextBox ordercode_txt;
        private Button update_button;
        private Button output_csv_button;
    }
}