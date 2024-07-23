namespace DeliverySystem_2
{
    partial class Admin2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            B_but = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(266, 34);
            button1.Name = "button1";
            button1.Size = new Size(240, 55);
            button1.TabIndex = 0;
            button1.Text = "VIEW TABLES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 116);
            button2.Name = "button2";
            button2.Size = new Size(240, 58);
            button2.TabIndex = 1;
            button2.Text = "UPDATE DRIVERS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 200);
            button3.Name = "button3";
            button3.Size = new Size(240, 59);
            button3.TabIndex = 2;
            button3.Text = "UPDATE OFFICES";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(266, 288);
            button4.Name = "button4";
            button4.Size = new Size(240, 61);
            button4.TabIndex = 3;
            button4.Text = "UPDATE EMPLOYEE";
            button4.UseVisualStyleBackColor = true;
            // 
            // B_but
            // 
            B_but.Location = new Point(48, 371);
            B_but.Name = "B_but";
            B_but.Size = new Size(94, 46);
            B_but.TabIndex = 4;
            B_but.Text = "Back";
            B_but.UseVisualStyleBackColor = true;
            B_but.Click += B_but_Click;
            // 
            // Admin2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B_but);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Admin2";
            Text = "Admin2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button B_but;
    }
}