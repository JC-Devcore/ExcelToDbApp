namespace ExcelToDbApplication
{
    partial class DatabaseSetting
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
            if (disposing && (components != null)) {
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
            this.textDatabaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.textMdfSize = new System.Windows.Forms.TextBox();
            this.textMdfMaxSize = new System.Windows.Forms.TextBox();
            this.textMdfFileGrowth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textLdfFileGrowth = new System.Windows.Forms.TextBox();
            this.textLdfMaxSize = new System.Windows.Forms.TextBox();
            this.textLdfSize = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDatabaseName
            // 
            this.textDatabaseName.Location = new System.Drawing.Point(155, 44);
            this.textDatabaseName.Name = "textDatabaseName";
            this.textDatabaseName.Size = new System.Drawing.Size(320, 22);
            this.textDatabaseName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Path";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(155, 84);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(320, 22);
            this.textPath.TabIndex = 3;
            // 
            // textMdfSize
            // 
            this.textMdfSize.Location = new System.Drawing.Point(102, 39);
            this.textMdfSize.Name = "textMdfSize";
            this.textMdfSize.Size = new System.Drawing.Size(76, 22);
            this.textMdfSize.TabIndex = 4;
            // 
            // textMdfMaxSize
            // 
            this.textMdfMaxSize.Location = new System.Drawing.Point(102, 67);
            this.textMdfMaxSize.Name = "textMdfMaxSize";
            this.textMdfMaxSize.Size = new System.Drawing.Size(76, 22);
            this.textMdfMaxSize.TabIndex = 5;
            // 
            // textMdfFileGrowth
            // 
            this.textMdfFileGrowth.Location = new System.Drawing.Point(102, 95);
            this.textMdfFileGrowth.Name = "textMdfFileGrowth";
            this.textMdfFileGrowth.Size = new System.Drawing.Size(76, 22);
            this.textMdfFileGrowth.TabIndex = 6;
            this.textMdfFileGrowth.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "File Growth";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textMdfFileGrowth);
            this.groupBox1.Controls.Add(this.textMdfMaxSize);
            this.groupBox1.Controls.Add(this.textMdfSize);
            this.groupBox1.Location = new System.Drawing.Point(33, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 163);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Database File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textLdfFileGrowth);
            this.groupBox2.Controls.Add(this.textLdfMaxSize);
            this.groupBox2.Controls.Add(this.textLdfSize);
            this.groupBox2.Location = new System.Drawing.Point(282, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 163);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Database File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "File Growth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Size";
            // 
            // textLdfFileGrowth
            // 
            this.textLdfFileGrowth.Location = new System.Drawing.Point(102, 95);
            this.textLdfFileGrowth.Name = "textLdfFileGrowth";
            this.textLdfFileGrowth.Size = new System.Drawing.Size(76, 22);
            this.textLdfFileGrowth.TabIndex = 6;
            this.textLdfFileGrowth.Text = "10";
            this.textLdfFileGrowth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textLdfMaxSize
            // 
            this.textLdfMaxSize.Location = new System.Drawing.Point(102, 67);
            this.textLdfMaxSize.Name = "textLdfMaxSize";
            this.textLdfMaxSize.Size = new System.Drawing.Size(76, 22);
            this.textLdfMaxSize.TabIndex = 5;
            // 
            // textLdfSize
            // 
            this.textLdfSize.Location = new System.Drawing.Point(102, 39);
            this.textLdfSize.Name = "textLdfSize";
            this.textLdfSize.Size = new System.Drawing.Size(76, 22);
            this.textLdfSize.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(378, 307);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 28);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // DatabaseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 342);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDatabaseName);
            this.Name = "DatabaseSetting";
            this.Text = "Database Setting";
            this.Load += new System.EventHandler(this.DatabaseSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textMdfSize;
        private System.Windows.Forms.TextBox textMdfMaxSize;
        private System.Windows.Forms.TextBox textMdfFileGrowth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textLdfFileGrowth;
        private System.Windows.Forms.TextBox textLdfMaxSize;
        private System.Windows.Forms.TextBox textLdfSize;
        private System.Windows.Forms.Button btnCreate;
    }
}