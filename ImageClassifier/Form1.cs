using System.Text;

namespace ImageClassifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileNameViewer.ColumnCount = 2;
            fileNameViewer.Columns[0].Name = "FileName";
            fileNameViewer.Columns[1].Name = "Extension";
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string FolderName;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderName = fbd.SelectedPath;
                filepathLabel.Text = FolderName;
            }
            else return;

            DirectoryInfo di = new DirectoryInfo(FolderName);

            fileNameViewer.Rows.Clear();
            foreach (FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".jpg") == 0 || File.Extension.ToLower().CompareTo(".png") == 0)
                {
                    String FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);

                    fileNameViewer.Rows.Add(FileNameOnly, Path.GetExtension(File.Name));
                }
            }

            if (fileNameViewer.Rows.Count == 0)
            {
                if (thumbnailViewr.Image != null)
                {
                    thumbnailViewr.Image.Dispose();
                    thumbnailViewr.Image = null;
                }
                imageNameBox.Text = String.Empty;
                MessageBox.Show("There is no image File!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Utility util = new Utility();
            util.LoadSelectedImagae(fileNameViewer, thumbnailViewr, filepathLabel, extensionLabel, imageNameBox);
        }

        private void modifyFilenameButton_Click(object sender, EventArgs e)
        {

            if (fileNameViewer.Rows.Count == 0 || imageNameBox.Text == string.Empty)
            {
                MessageBox.Show("There is no image File!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string oldfile = filepathLabel.Text + "\\" +
                fileNameViewer.SelectedRows[0].Cells[0].Value.ToString() + extensionLabel.Text;

            string newfile = filepathLabel.Text + "\\" + imageNameBox.Text + extensionLabel.Text;

            thumbnailViewr.Image.Dispose();
            if (File.Exists(oldfile))
            {
                System.IO.File.Move(oldfile, newfile);
                thumbnailViewr.Image = Image.FromFile(filepathLabel.Text + "\\" + imageNameBox.Text + extensionLabel.Text);
            }
            else
            {
                MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fileNameViewer.SelectedRows[0].Cells[0].Value = imageNameBox.Text;
        }

        private void fileNameViewer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Utility util = new();
                util.LoadSelectedImagae(fileNameViewer, thumbnailViewr, filepathLabel, extensionLabel, imageNameBox);
                util.ClearTextBox(characterBox, seriesBox, guitarBox);
            }
            catch { }
        }

        public string str2hex(string strData)
        {
            string resultHex = string.Empty;
            byte[] arr_byteStr = Encoding.Default.GetBytes(strData);

            foreach (byte byteStr in arr_byteStr)
                resultHex += string.Format("{0:X2}", byteStr);

            return resultHex;
        }


        //metadata생성할 파일을 제작한다.
        private void readMetadataButton_Click(object sender, EventArgs e)
        {
            //exception handling - file does not exist
            if (fileNameViewer.Rows.Count == 0)
            {
                MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filename;
            byte[] bytestr;

            //create test.bin file
            FileStream fs = new FileStream(filepathLabel.Text + "\\test.bin", FileMode.Create);

            //write
            for (int i = 0; i < fileNameViewer.Rows.Count; i++)
            {
                filename = "filename: " + fileNameViewer.Rows[i].Cells[0].Value.ToString() + "\n";
                bytestr = Encoding.UTF8.GetBytes(filename);
                fs.Write(bytestr);
            }

            fs.Close();

        }
    }
}
