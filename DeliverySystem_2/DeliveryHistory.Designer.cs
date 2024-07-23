namespace DeliverySystem_2
{
    partial class DeliveryHistory
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
            b_but = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(316, 40);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 0;
            label1.Text = "VIEW TABLES";
            // 
            // b_but
            // 
            b_but.Location = new Point(45, 366);
            b_but.Name = "b_but";
            b_but.Size = new Size(104, 51);
            b_but.TabIndex = 1;
            b_but.Text = "Back";
            b_but.UseVisualStyleBackColor = true;
            b_but.Click += b_but_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DELIVERY", "OFFICE", "PARCEL", "EMPLOYEE", "DRIVER", "DISTANCE", "DRIVER_PNO", "MODIFICATION_LOG", "DEL_LOG", "USES", "VEHICLE", "VIEWS" });
            comboBox1.Location = new Point(338, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Table:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 188);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(524, 103);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "get table";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeliveryHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(b_but);
            Controls.Add(label1);
            Name = "DeliveryHistory";
            Text = "DeliveryHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button b_but;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}