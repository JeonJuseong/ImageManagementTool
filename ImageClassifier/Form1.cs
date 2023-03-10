using System.Reflection.Metadata.Ecma335;

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

        private void loadSelectedImagae()
        {
            if (thumbnailViewr.Image != null)
                thumbnailViewr.Image.Dispose();

            imageNameBox.Text = fileNameViewer.SelectedRows[0].Cells[0].Value.ToString();
            extensionLabel.Text = fileNameViewer.SelectedRows[0].Cells[1].Value.ToString();

            thumbnailViewr.Image = Image.FromFile(filepathLabel.Text + "\\" + imageNameBox.Text + extensionLabel.Text);
            thumbnailViewr.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            String FolderName = String.Empty;  //FolderName에 폴더명을 입력

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderName = fbd.SelectedPath;
                filepathLabel.Text = FolderName;
            }
            else return;

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName);

            fileNameViewer.Rows.Clear();
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".jpg") == 0 || File.Extension.ToLower().CompareTo(".png") == 0)
                {
                    String FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);

                    fileNameViewer.Rows.Add(FileNameOnly, Path.GetExtension(File.Name));
                }
            }

            if (fileNameViewer.Rows.Count == 0)
            {
                if(thumbnailViewr.Image != null)
                {
                    thumbnailViewr.Image.Dispose();
                    thumbnailViewr.Image = null;
                }
                imageNameBox.Text = String.Empty;
                MessageBox.Show("There is no image File!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadSelectedImagae();
        }

        private void modifyFilenameButton_Click(object sender, EventArgs e)
        {

            if(fileNameViewer.Rows.Count == 0 || imageNameBox.Text == string.Empty)
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
                loadSelectedImagae();
            }
            catch { }
           
        }
    }
}