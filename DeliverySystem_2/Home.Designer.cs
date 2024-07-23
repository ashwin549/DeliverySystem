namespace DeliverySystem_2
{
    partial class Home
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            A_but = new Button();
            L_but = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(309, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 40);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(140, 114);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 1;
            label2.Text = "Login as...";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(324, 182);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(126, 32);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "EMPLOYEE";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(324, 262);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 32);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "DRIVER";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // A_but
            // 
            A_but.Location = new Point(30, 386);
            A_but.Name = "A_but";
            A_but.Size = new Size(94, 38);
            A_but.TabIndex = 4;
            A_but.Text = "Admin";
            A_but.UseVisualStyleBackColor = true;
            A_but.Click += A_but_Click;
            // 
            // L_but
            // 
            L_but.Location = new Point(659, 379);
            L_but.Name = "L_but";
            L_but.Size = new Size(117, 52);
            L_but.TabIndex = 5;
            L_but.Text = "Login";
            L_but.UseVisualStyleBackColor = true;
            L_but.Click += L_but_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(L_but);
            Controls.Add(A_but);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button A_but;
        private Button L_but;
    }
}