namespace DeliverySystem_2
{
    partial class Emp2
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
            Req_but = new Button();
            Quit_but = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(105, 51);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "OFFICE NO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(105, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "DELIVERIES";
            // 
            // Req_but
            // 
            Req_but.Location = new Point(79, 370);
            Req_but.Name = "Req_but";
            Req_but.Size = new Size(109, 43);
            Req_but.TabIndex = 2;
            Req_but.Text = "Request";
            Req_but.UseVisualStyleBackColor = true;
            Req_but.Click += Req_but_Click;
            // 
            // Quit_but
            // 
            Quit_but.Location = new Point(617, 370);
            Quit_but.Name = "Quit_but";
            Quit_but.Size = new Size(111, 43);
            Quit_but.TabIndex = 3;
            Quit_but.Text = "Quit";
            Quit_but.UseVisualStyleBackColor = true;
            Quit_but.Click += Quit_but_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 217);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 43);
            label3.Name = "label3";
            label3.Size = new Size(83, 44);
            label3.TabIndex = 5;
            label3.Text = "LABEL3\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(597, 90);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 6;
            button1.Text = "ACCEPT delivery";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Emp2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(Quit_but);
            Controls.Add(Req_but);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Emp2";
            Text = "Emp2";
            Load += Emp2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Req_but;
        private Button Quit_but;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button1;
    }
}