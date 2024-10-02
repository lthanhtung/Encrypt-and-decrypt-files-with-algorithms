using System.Security.Cryptography;

namespace Bai3._12._4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxAlgorithm.SelectedIndex = 1;  // Chọn DES làm mặc định
        }
        // Mã hóa File
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = textBoxKey.Text;
                string IV = textBoxIV.Text;
                string inputFile = textBoxInputFile.Text;
                string outputFile = textBoxOutputFile.Text;

                byte[] key = StringToByte(Key);
                byte[] iv = StringToByte(IV);

                using (SymmetricAlgorithm algorithm = GetAlgorithm())
                {
                    algorithm.Key = key;
                    algorithm.IV = iv;

                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    using (CryptoStream cs = new CryptoStream(fsOutput, algorithm.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        fsInput.CopyTo(cs);
                    }
                }

                MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Giải mã File
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = textBoxKey.Text;
                string IV = textBoxIV.Text;
                string inputFile = textBoxInputFile.Text;
                string outputFile = textBoxOutputFile.Text;

                byte[] key = StringToByte(Key);
                byte[] iv = StringToByte(IV);

                using (SymmetricAlgorithm algorithm = GetAlgorithm())
                {
                    algorithm.Key = key;
                    algorithm.IV = iv;

                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    using (CryptoStream cs = new CryptoStream(fsInput, algorithm.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cs.CopyTo(fsOutput);
                    }
                }

                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Lấy thuật toán để mã hóa dựa trên lựa chọn của người dùng
        private SymmetricAlgorithm GetAlgorithm()
        {
            switch (comboBoxAlgorithm.SelectedItem.ToString())
            {
                case "AES":
                    return Aes.Create();
                case "DES":
                    return DES.Create();
                case "TripleDES":
                    return TripleDES.Create();
                default:
                    return DES.Create();
            }
        }
        // Chuyển đổi Hex string sang byte
        private static byte[] StringToByte(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        // Sinh Khóa và IV
        private void buttonGenerateKeyIV_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetAlgorithm())
            {
                textBoxKey.Text = BitConverter.ToString(algorithm.Key).Replace("-", "");
                textBoxIV.Text = BitConverter.ToString(algorithm.IV).Replace("-", "");
            }
        }
        // Lưu Khóa và IV vào File
        private void buttonSaveKeyIV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Chọn nơi lưu khóa và IV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, $"{textBoxKey.Text}\n{textBoxIV.Text}");
                    MessageBox.Show("Khóa và IV đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // Nạp Khóa và IV từ 1 File
        private void buttonLoadKeyIV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn tệp để tải khóa và IV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] keyIV = File.ReadAllLines(openFileDialog.FileName);
                        textBoxKey.Text = keyIV[0];
                        textBoxIV.Text = keyIV[1];
                        MessageBox.Show("Khóa và IV đã được tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải khóa và IV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Chọn Input File
        private void buttonSelectInputFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxInputFile.Text = openFileDialog.FileName;
                }
            }
        }
        //Chọn Output File
        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutputFile.Text = saveFileDialog.FileName;
                }
            }
        }
    }
}
