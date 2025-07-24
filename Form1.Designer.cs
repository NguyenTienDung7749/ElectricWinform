namespace WaterBillWinformTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbname = new TextBox();
            tbcccd = new TextBox();
            tbpeople = new TextBox();
            tbwaterlast = new TextBox();
            tbwaterthis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbcustomer = new ComboBox();
            label6 = new Label();
            listView1 = new ListView();
            btncaculator = new Button();
            btnsave = new Button();
            tbbill = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // tbname
            // 
            tbname.Location = new Point(114, 28);
            tbname.Name = "tbname";
            tbname.Size = new Size(281, 27);
            tbname.TabIndex = 0;
            // 
            // tbcccd
            // 
            tbcccd.Location = new Point(114, 87);
            tbcccd.Name = "tbcccd";
            tbcccd.Size = new Size(281, 27);
            tbcccd.TabIndex = 1;
            // 
            // tbpeople
            // 
            tbpeople.Location = new Point(169, 204);
            tbpeople.Name = "tbpeople";
            tbpeople.Size = new Size(226, 27);
            tbpeople.TabIndex = 2;
            // 
            // tbwaterlast
            // 
            tbwaterlast.Location = new Point(169, 257);
            tbwaterlast.Name = "tbwaterlast";
            tbwaterlast.Size = new Size(226, 27);
            tbwaterlast.TabIndex = 3;
            // 
            // tbwaterthis
            // 
            tbwaterthis.Location = new Point(169, 308);
            tbwaterthis.Name = "tbwaterthis";
            tbwaterthis.Size = new Size(226, 27);
            tbwaterthis.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Ho Va Ten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 90);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 7;
            label3.Text = "So Nguoi Trong GD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 260);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 8;
            label4.Text = "So Dien Thang Truoc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 311);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 9;
            label5.Text = "So Dien Thang Nay";
            // 
            // cbbcustomer
            // 
            cbbcustomer.FormattingEnabled = true;
            cbbcustomer.Items.AddRange(new object[] { "Ho Gia Dinh", "Kinh Doanh", "Cong Ty" });
            cbbcustomer.Location = new Point(155, 146);
            cbbcustomer.Name = "cbbcustomer";
            cbbcustomer.Size = new Size(240, 28);
            cbbcustomer.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 149);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 11;
            label6.Text = "Loai Khach Hang";
            // 
            // listView1
            // 
            listView1.Location = new Point(420, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(655, 494);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btncaculator
            // 
            btncaculator.Location = new Point(53, 425);
            btncaculator.Name = "btncaculator";
            btncaculator.Size = new Size(302, 29);
            btncaculator.TabIndex = 13;
            btncaculator.Text = "Tinh Tien Nuoc";
            btncaculator.UseVisualStyleBackColor = true;
            btncaculator.Click += btncaculator_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(53, 477);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(302, 29);
            btnsave.TabIndex = 14;
            btnsave.Text = "Luu Thong Tin";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // tbbill
            // 
            tbbill.Location = new Point(155, 365);
            tbbill.Name = "tbbill";
            tbbill.ReadOnly = true;
            tbbill.Size = new Size(240, 27);
            tbbill.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 368);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 16;
            label7.Text = "Hoa Don Nuoc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 524);
            Controls.Add(label7);
            Controls.Add(tbbill);
            Controls.Add(btnsave);
            Controls.Add(btncaculator);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(cbbcustomer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbwaterthis);
            Controls.Add(tbwaterlast);
            Controls.Add(tbpeople);
            Controls.Add(tbcccd);
            Controls.Add(tbname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbname;
        private TextBox tbcccd;
        private TextBox tbpeople;
        private TextBox tbwaterlast;
        private TextBox tbwaterthis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbbcustomer;
        private Label label6;
        private ListView listView1;
        private Button btncaculator;
        private Button btnsave;
        private TextBox tbbill;
        private Label label7;
    }
}
