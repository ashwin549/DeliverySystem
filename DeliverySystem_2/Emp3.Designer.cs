namespace DeliverySystem_2
{
    partial class Emp3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(280, 25);
            label1.Name = "label1";
            label1.Size = new Size(217, 41);
            label1.TabIndex = 0;
            label1.Text = "NEW DELIVERY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(236, 102);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 1;
            label2.Text = "To :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(236, 151);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 2;
            label3.Text = "PARCEL DETAILS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 198);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Weight :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 246);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Safety :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 293);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 5;
            label6.Text = "Size :";
            // 
            // button1
            // 
            button1.Location = new Point(36, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(308, 345);
            button2.Name = "button2";
            button2.Size = new Size(110, 44);
            button2.TabIndex = 7;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(308, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "Fragile", "Flammable", "Hazardous", "Corrosive", "Radioactive", "Volatile", "Electrical", "Temperature-sensitive", "Reactive", "Sharp", "Toxic", "Perishable", "Explosive" });
            comboBox2.Location = new Point(308, 246);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 28);
            comboBox2.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 27);
            textBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 198);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 12;
            label7.Text = "kg";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 294);
            label8.Name = "label8";
            label8.Size = new Size(22, 20);
            label8.TabIndex = 13;
            label8.Text = "m";
            // 
            // Emp3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Emp3";
            Text = "Emp3";
            Load += Emp3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
    }
}