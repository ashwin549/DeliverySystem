namespace DeliverySystem_2
{
    partial class AdminLogin
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
            Sub_but = new Button();
            B_but = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Sub_but
            // 
            Sub_but.Location = new Point(660, 379);
            Sub_but.Name = "Sub_but";
            Sub_but.Size = new Size(94, 50);
            Sub_but.TabIndex = 0;
            Sub_but.Text = "Submit";
            Sub_but.UseVisualStyleBackColor = true;
            Sub_but.Click += Sub_but_Click;
            // 
            // B_but
            // 
            B_but.Location = new Point(39, 379);
            B_but.Name = "B_but";
            B_but.Size = new Size(94, 50);
            B_but.TabIndex = 1;
            B_but.Text = "Back";
            B_but.UseVisualStyleBackColor = true;
            B_but.Click += B_but_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(282, 37);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 2;
            label1.Text = "ADMIN LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(224, 146);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 3;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(224, 237);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(401, 233);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(137, 27);
            textBox2.TabIndex = 6;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(B_but);
            Controls.Add(Sub_but);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sub_but;
        private Button B_but;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}