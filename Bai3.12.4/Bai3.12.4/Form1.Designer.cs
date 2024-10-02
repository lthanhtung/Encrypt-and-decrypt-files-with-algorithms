namespace Bai3._12._4
{
    partial class MainForm
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
            comboBoxAlgorithm = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxKey = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxIV = new TextBox();
            buttonGenerateKeyIV = new Button();
            buttonSaveKeyIV = new Button();
            buttonLoadKeyIV = new Button();
            label5 = new Label();
            textBoxInputFile = new TextBox();
            label6 = new Label();
            textBoxOutputFile = new TextBox();
            buttonSelectInputFile = new Button();
            buttonSelectOutputFile = new Button();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            comboBoxAlgorithm.FormattingEnabled = true;
            comboBoxAlgorithm.Items.AddRange(new object[] { "AES", "DES", "TripleDES", "Rijndael" });
            comboBoxAlgorithm.Location = new Point(218, 18);
            comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            comboBoxAlgorithm.Size = new Size(159, 28);
            comboBoxAlgorithm.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 23);
            label1.Name = "label1";
            label1.Size = new Size(372, 23);
            label1.TabIndex = 1;
            label1.Text = "Thông tin khóa: 256 bit Thông tin block: 128 bit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 2;
            label2.Text = "Chọn thuật toán mã hóa";
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(162, 64);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(593, 27);
            textBoxKey.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 4;
            label3.Text = "Khóa (dạng hexa)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 6;
            label4.Text = "IV (dạng hexa)";
            // 
            // textBoxIV
            // 
            textBoxIV.Location = new Point(162, 110);
            textBoxIV.Name = "textBoxIV";
            textBoxIV.Size = new Size(593, 27);
            textBoxIV.TabIndex = 5;
            // 
            // buttonGenerateKeyIV
            // 
            buttonGenerateKeyIV.Location = new Point(625, 159);
            buttonGenerateKeyIV.Name = "buttonGenerateKeyIV";
            buttonGenerateKeyIV.Size = new Size(131, 35);
            buttonGenerateKeyIV.TabIndex = 9;
            buttonGenerateKeyIV.Text = "Sinh Khóa && IV";
            buttonGenerateKeyIV.UseVisualStyleBackColor = true;
            buttonGenerateKeyIV.Click += buttonGenerateKeyIV_Click;
            // 
            // buttonSaveKeyIV
            // 
            buttonSaveKeyIV.Location = new Point(425, 159);
            buttonSaveKeyIV.Name = "buttonSaveKeyIV";
            buttonSaveKeyIV.Size = new Size(140, 35);
            buttonSaveKeyIV.TabIndex = 10;
            buttonSaveKeyIV.Text = "Lưu Khóa && IV";
            buttonSaveKeyIV.UseVisualStyleBackColor = true;
            buttonSaveKeyIV.Click += buttonSaveKeyIV_Click;
            // 
            // buttonLoadKeyIV
            // 
            buttonLoadKeyIV.Location = new Point(219, 159);
            buttonLoadKeyIV.Name = "buttonLoadKeyIV";
            buttonLoadKeyIV.Size = new Size(141, 35);
            buttonLoadKeyIV.TabIndex = 11;
            buttonLoadKeyIV.Text = "Nạp Khóa && IV";
            buttonLoadKeyIV.UseVisualStyleBackColor = true;
            buttonLoadKeyIV.Click += buttonLoadKeyIV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 13;
            label5.Text = "File ban đầu";
            // 
            // textBoxInputFile
            // 
            textBoxInputFile.Location = new Point(162, 238);
            textBoxInputFile.Name = "textBoxInputFile";
            textBoxInputFile.Size = new Size(467, 27);
            textBoxInputFile.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 295);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 15;
            label6.Text = "File mã hóa";
            // 
            // textBoxOutputFile
            // 
            textBoxOutputFile.Location = new Point(162, 294);
            textBoxOutputFile.Name = "textBoxOutputFile";
            textBoxOutputFile.Size = new Size(467, 27);
            textBoxOutputFile.TabIndex = 14;
            // 
            // buttonSelectInputFile
            // 
            buttonSelectInputFile.Location = new Point(635, 234);
            buttonSelectInputFile.Name = "buttonSelectInputFile";
            buttonSelectInputFile.Size = new Size(131, 35);
            buttonSelectInputFile.TabIndex = 16;
            buttonSelectInputFile.Text = "Chọn File";
            buttonSelectInputFile.UseVisualStyleBackColor = true;
            buttonSelectInputFile.Click += buttonSelectInputFile_Click;
            // 
            // buttonSelectOutputFile
            // 
            buttonSelectOutputFile.Location = new Point(635, 290);
            buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            buttonSelectOutputFile.Size = new Size(131, 35);
            buttonSelectOutputFile.TabIndex = 17;
            buttonSelectOutputFile.Text = "Chọn File";
            buttonSelectOutputFile.UseVisualStyleBackColor = true;
            buttonSelectOutputFile.Click += buttonSelectOutputFile_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(219, 359);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(141, 35);
            buttonEncrypt.TabIndex = 19;
            buttonEncrypt.Text = "Mã hóa";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(425, 359);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(140, 35);
            buttonDecrypt.TabIndex = 18;
            buttonDecrypt.Text = "Giải mã";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEncrypt);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonSelectOutputFile);
            Controls.Add(buttonSelectInputFile);
            Controls.Add(label6);
            Controls.Add(textBoxOutputFile);
            Controls.Add(label5);
            Controls.Add(textBoxInputFile);
            Controls.Add(buttonLoadKeyIV);
            Controls.Add(buttonSaveKeyIV);
            Controls.Add(buttonGenerateKeyIV);
            Controls.Add(label4);
            Controls.Add(textBoxIV);
            Controls.Add(label3);
            Controls.Add(textBoxKey);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxAlgorithm);
            Name = "MainForm";
            Text = "Bai 3.12.4";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAlgorithm;
        private Label label1;
        private Label label2;
        private TextBox textBoxKey;
        private Label label3;
        private Label label4;
        private TextBox textBoxIV;
        private Button buttonGenerateKeyIV;
        private Button buttonSaveKeyIV;
        private Button buttonLoadKeyIV;
        private Label label5;
        private TextBox textBoxInputFile;
        private Label label6;
        private TextBox textBoxOutputFile;
        private Button buttonSelectInputFile;
        private Button buttonSelectOutputFile;
        private Button buttonEncrypt;
        private Button buttonDecrypt;
    }
}
