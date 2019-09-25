namespace DienTruong_Ver5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DienTich = new System.Windows.Forms.TextBox();
            this.SetQ = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DauDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Button();
            this.Measure = new DienTruong_Ver5.ButtonCircle();
            this.NegativeCharges = new DienTruong_Ver5.ButtonCircle();
            this.PositiveCharges = new DienTruong_Ver5.ButtonCircle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DienTich);
            this.panel1.Controls.Add(this.SetQ);
            this.panel1.Location = new System.Drawing.Point(12, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 123);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 156);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điện Tích (Đơn vị: nC)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DienTich
            // 
            this.DienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienTich.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DienTich.Location = new System.Drawing.Point(18, 60);
            this.DienTich.Name = "DienTich";
            this.DienTich.Size = new System.Drawing.Size(91, 20);
            this.DienTich.TabIndex = 1;
            this.DienTich.Text = "10";
            // 
            // SetQ
            // 
            this.SetQ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SetQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SetQ.Location = new System.Drawing.Point(17, 86);
            this.SetQ.Name = "SetQ";
            this.SetQ.Size = new System.Drawing.Size(92, 28);
            this.SetQ.TabIndex = 0;
            this.SetQ.Text = "Nhập";
            this.SetQ.UseVisualStyleBackColor = false;
            this.SetQ.Click += new System.EventHandler(this.SetQ_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DauDo);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 92);
            this.panel4.TabIndex = 11;
            // 
            // DauDo
            // 
            this.DauDo.Location = new System.Drawing.Point(13, 52);
            this.DauDo.Name = "DauDo";
            this.DauDo.ReadOnly = true;
            this.DauDo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DauDo.Size = new System.Drawing.Size(100, 20);
            this.DauDo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đầu Đo Điện Trường (Đơn vị: V/m)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Reset);
            this.panel3.Location = new System.Drawing.Point(12, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 95);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reset";
            // 
            // Reset
            // 
            this.Reset.BackgroundImage = global::DienTruong_Ver5.Properties.Resources._11112321;
            this.Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Location = new System.Drawing.Point(41, 30);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(45, 45);
            this.Reset.TabIndex = 12;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Information
            // 
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(10, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(75, 26);
            this.Information.TabIndex = 14;
            this.Information.Text = "Thông tin";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // Measure
            // 
            this.Measure.BackgroundImage = global::DienTruong_Ver5.Properties.Resources.Measure;
            this.Measure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Measure.FlatAppearance.BorderSize = 0;
            this.Measure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Measure.Location = new System.Drawing.Point(23, 155);
            this.Measure.Name = "Measure";
            this.Measure.Size = new System.Drawing.Size(15, 15);
            this.Measure.TabIndex = 10;
            this.Measure.UseVisualStyleBackColor = true;
            this.Measure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Measure_MouseDown);
            this.Measure.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Measure_MouseUp);
            // 
            // NegativeCharges
            // 
            this.NegativeCharges.BackgroundImage = global::DienTruong_Ver5.Properties.Resources.NegativeCharges;
            this.NegativeCharges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NegativeCharges.FlatAppearance.BorderSize = 0;
            this.NegativeCharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NegativeCharges.Location = new System.Drawing.Point(108, 149);
            this.NegativeCharges.Name = "NegativeCharges";
            this.NegativeCharges.Size = new System.Drawing.Size(21, 21);
            this.NegativeCharges.TabIndex = 6;
            this.NegativeCharges.UseVisualStyleBackColor = true;
            this.NegativeCharges.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NegativeCharges_MouseDown);
            this.NegativeCharges.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NegativeCharges_MouseUp);
            // 
            // PositiveCharges
            // 
            this.PositiveCharges.BackgroundImage = global::DienTruong_Ver5.Properties.Resources.PositiveCharges;
            this.PositiveCharges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PositiveCharges.FlatAppearance.BorderSize = 0;
            this.PositiveCharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositiveCharges.Location = new System.Drawing.Point(64, 149);
            this.PositiveCharges.Name = "PositiveCharges";
            this.PositiveCharges.Size = new System.Drawing.Size(21, 21);
            this.PositiveCharges.TabIndex = 5;
            this.PositiveCharges.UseVisualStyleBackColor = true;
            this.PositiveCharges.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PositiveCharges_MouseDown);
            this.PositiveCharges.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PositiveCharges_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(149, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 480);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Nhập 1 - 100000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(776, 504);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Measure);
            this.Controls.Add(this.NegativeCharges);
            this.Controls.Add(this.PositiveCharges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "    ĐIỆN TRƯỜNG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DienTich;
        private System.Windows.Forms.Button SetQ;
        private System.Windows.Forms.Label label1;
        private ButtonCircle PositiveCharges;
        private ButtonCircle NegativeCharges;
        private System.Windows.Forms.Panel panel2;
        private ButtonCircle Measure;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DauDo;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Label label4;
    }
}

