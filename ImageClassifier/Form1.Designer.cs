namespace ImageClassifier
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
            loadImageButton = new Button();
            fileNameViewer = new DataGridView();
            thumbnailViewr = new PictureBox();
            imageName = new Label();
            imageNameBox = new TextBox();
            label1 = new Label();
            filepathLabel = new Label();
            modifyFilenameButton = new Button();
            extensionLabel = new Label();
            readMetadataButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            characterBox = new TextBox();
            seriesBox = new TextBox();
            guitarBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileNameViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thumbnailViewr).BeginInit();
            SuspendLayout();
            // 
            // loadImageButton
            // 
            loadImageButton.Font = new Font("나눔스퀘어 네오 Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            loadImageButton.Location = new Point(539, 442);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(352, 32);
            loadImageButton.TabIndex = 0;
            loadImageButton.Text = "load files";
            loadImageButton.UseCompatibleTextRendering = true;
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // fileNameViewer
            // 
            fileNameViewer.AllowUserToAddRows = false;
            fileNameViewer.AllowUserToDeleteRows = false;
            fileNameViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            fileNameViewer.BackgroundColor = SystemColors.Control;
            fileNameViewer.BorderStyle = BorderStyle.None;
            fileNameViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fileNameViewer.Location = new Point(9, 7);
            fileNameViewer.Name = "fileNameViewer";
            fileNameViewer.ReadOnly = true;
            fileNameViewer.RowTemplate.Height = 25;
            fileNameViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fileNameViewer.Size = new Size(524, 466);
            fileNameViewer.TabIndex = 1;
            fileNameViewer.CellEnter += fileNameViewer_CellEnter;
            // 
            // thumbnailViewr
            // 
            thumbnailViewr.BackColor = SystemColors.Desktop;
            thumbnailViewr.BackgroundImageLayout = ImageLayout.Stretch;
            thumbnailViewr.BorderStyle = BorderStyle.FixedSingle;
            thumbnailViewr.InitialImage = null;
            thumbnailViewr.Location = new Point(539, 7);
            thumbnailViewr.Name = "thumbnailViewr";
            thumbnailViewr.Size = new Size(354, 315);
            thumbnailViewr.TabIndex = 2;
            thumbnailViewr.TabStop = false;
            // 
            // imageName
            // 
            imageName.AutoSize = true;
            imageName.Font = new Font("나눔스퀘어 네오 Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            imageName.Location = new Point(546, 330);
            imageName.Name = "imageName";
            imageName.Size = new Size(64, 13);
            imageName.TabIndex = 3;
            imageName.Text = "filename:";
            // 
            // imageNameBox
            // 
            imageNameBox.Location = new Point(616, 325);
            imageNameBox.Name = "imageNameBox";
            imageNameBox.Size = new Size(137, 23);
            imageNameBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔스퀘어 네오 Regular", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 477);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 5;
            label1.Text = "filepath: ";
            // 
            // filepathLabel
            // 
            filepathLabel.AutoSize = true;
            filepathLabel.Font = new Font("나눔스퀘어 네오 Regular", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            filepathLabel.Location = new Point(60, 477);
            filepathLabel.Name = "filepathLabel";
            filepathLabel.Size = new Size(16, 13);
            filepathLabel.TabIndex = 6;
            filepathLabel.Text = "...";
            // 
            // modifyFilenameButton
            // 
            modifyFilenameButton.Font = new Font("나눔스퀘어 네오 Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            modifyFilenameButton.Location = new Point(808, 325);
            modifyFilenameButton.Name = "modifyFilenameButton";
            modifyFilenameButton.Size = new Size(86, 25);
            modifyFilenameButton.TabIndex = 7;
            modifyFilenameButton.Text = "modify";
            modifyFilenameButton.UseVisualStyleBackColor = true;
            modifyFilenameButton.Click += modifyFilenameButton_Click;
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            extensionLabel.Location = new Point(753, 323);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new Size(35, 21);
            extensionLabel.TabIndex = 8;
            extensionLabel.Text = ".xxx";
            // 
            // readMetadataButton
            // 
            readMetadataButton.Font = new Font("나눔스퀘어 네오 ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            readMetadataButton.Location = new Point(759, 357);
            readMetadataButton.Name = "readMetadataButton";
            readMetadataButton.Size = new Size(135, 82);
            readMetadataButton.TabIndex = 9;
            readMetadataButton.Text = "Insert\r\nMetadata";
            readMetadataButton.UseVisualStyleBackColor = true;
            readMetadataButton.Click += readMetadataButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("나눔스퀘어 네오 Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(540, 359);
            label2.Name = "label2";
            label2.Size = new Size(70, 13);
            label2.TabIndex = 10;
            label2.Text = "character:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔스퀘어 네오 Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(560, 389);
            label3.Name = "label3";
            label3.Size = new Size(49, 13);
            label3.TabIndex = 11;
            label3.Text = "series:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("나눔스퀘어 네오 Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(552, 418);
            label4.Name = "label4";
            label4.Size = new Size(58, 13);
            label4.TabIndex = 12;
            label4.Text = "GUITAR:";
            // 
            // characterBox
            // 
            characterBox.Location = new Point(616, 354);
            characterBox.Name = "characterBox";
            characterBox.Size = new Size(137, 23);
            characterBox.TabIndex = 13;
            // 
            // seriesBox
            // 
            seriesBox.Location = new Point(616, 384);
            seriesBox.Name = "seriesBox";
            seriesBox.Size = new Size(137, 23);
            seriesBox.TabIndex = 14;
            // 
            // guitarBox
            // 
            guitarBox.Location = new Point(616, 413);
            guitarBox.Name = "guitarBox";
            guitarBox.Size = new Size(137, 23);
            guitarBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 500);
            Controls.Add(guitarBox);
            Controls.Add(seriesBox);
            Controls.Add(characterBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(readMetadataButton);
            Controls.Add(extensionLabel);
            Controls.Add(modifyFilenameButton);
            Controls.Add(filepathLabel);
            Controls.Add(label1);
            Controls.Add(imageNameBox);
            Controls.Add(imageName);
            Controls.Add(thumbnailViewr);
            Controls.Add(fileNameViewer);
            Controls.Add(loadImageButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileNameViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)thumbnailViewr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadImageButton;
        private DataGridView fileNameViewer;
        private PictureBox thumbnailViewr;
        private Label imageName;
        private TextBox imageNameBox;
        private Label label1;
        private Label filepathLabel;
        private Button modifyFilenameButton;
        private Label extensionLabel;
        private Button readMetadataButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox characterBox;
        private TextBox seriesBox;
        private TextBox guitarBox;
    }
}