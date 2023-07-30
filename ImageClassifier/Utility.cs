namespace ImageClassifier
{
    internal class Utility
    {
        public void ClearTextBox(TextBox characterBox, TextBox seriesBox, TextBox guitarBox)
        {
            characterBox.Clear();
            seriesBox.Clear();
            guitarBox.Clear();
        }

        public void LoadSelectedImagae(DataGridView fileNameViewer, PictureBox thumbnailViewr, Label filepathLabel, Label extensionLabel, TextBox imageNameBox)
        {
            if (thumbnailViewr.Image != null)
                thumbnailViewr.Image.Dispose();

            imageNameBox.Text = fileNameViewer.SelectedRows[0].Cells[0].Value.ToString();
            extensionLabel.Text = fileNameViewer.SelectedRows[0].Cells[1].Value.ToString();

            thumbnailViewr.Image = Image.FromFile(filepathLabel.Text + "\\" + imageNameBox.Text + extensionLabel.Text);
            thumbnailViewr.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
