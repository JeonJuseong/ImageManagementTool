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
            this.loadImageButton = new System.Windows.Forms.Button();
            this.fileNameViewer = new System.Windows.Forms.DataGridView();
            this.thumbnailViewr = new System.Windows.Forms.PictureBox();
            this.imageName = new System.Windows.Forms.Label();
            this.imageNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filepathLabel = new System.Windows.Forms.Label();
            this.modifyFilenameButton = new System.Windows.Forms.Button();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.readMetadataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailViewr)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImageButton
            // 
            this.loadImageButton.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadImageButton.Location = new System.Drawing.Point(539, 442);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(352, 32);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "load files";
            this.loadImageButton.UseCompatibleTextRendering = true;
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // fileNameViewer
            // 
            this.fileNameViewer.AllowUserToAddRows = false;
            this.fileNameViewer.AllowUserToDeleteRows = false;
            this.fileNameViewer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.fileNameViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileNameViewer.Location = new System.Drawing.Point(9, 7);
            this.fileNameViewer.Name = "fileNameViewer";
            this.fileNameViewer.ReadOnly = true;
            this.fileNameViewer.RowTemplate.Height = 25;
            this.fileNameViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileNameViewer.Size = new System.Drawing.Size(524, 466);
            this.fileNameViewer.TabIndex = 1;
            this.fileNameViewer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.fileNameViewer_CellEnter);
            // 
            // thumbnailViewr
            // 
            this.thumbnailViewr.BackColor = System.Drawing.SystemColors.Desktop;
            this.thumbnailViewr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thumbnailViewr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailViewr.InitialImage = null;
            this.thumbnailViewr.Location = new System.Drawing.Point(539, 7);
            this.thumbnailViewr.Name = "thumbnailViewr";
            this.thumbnailViewr.Size = new System.Drawing.Size(354, 315);
            this.thumbnailViewr.TabIndex = 2;
            this.thumbnailViewr.TabStop = false;
            // 
            // imageName
            // 
            this.imageName.AutoSize = true;
            this.imageName.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imageName.Location = new System.Drawing.Point(546, 330);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(64, 13);
            this.imageName.TabIndex = 3;
            this.imageName.Text = "filename:";
            // 
            // imageNameBox
            // 
            this.imageNameBox.Location = new System.Drawing.Point(616, 325);
            this.imageNameBox.Name = "imageNameBox";
            this.imageNameBox.Size = new System.Drawing.Size(137, 23);
            this.imageNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "filepath: ";
            // 
            // filepathLabel
            // 
            this.filepathLabel.AutoSize = true;
            this.filepathLabel.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filepathLabel.Location = new System.Drawing.Point(60, 477);
            this.filepathLabel.Name = "filepathLabel";
            this.filepathLabel.Size = new System.Drawing.Size(16, 13);
            this.filepathLabel.TabIndex = 6;
            this.filepathLabel.Text = "...";
            // 
            // modifyFilenameButton
            // 
            this.modifyFilenameButton.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modifyFilenameButton.Location = new System.Drawing.Point(808, 325);
            this.modifyFilenameButton.Name = "modifyFilenameButton";
            this.modifyFilenameButton.Size = new System.Drawing.Size(86, 25);
            this.modifyFilenameButton.TabIndex = 7;
            this.modifyFilenameButton.Text = "modify";
            this.modifyFilenameButton.UseVisualStyleBackColor = true;
            this.modifyFilenameButton.Click += new System.EventHandler(this.modifyFilenameButton_Click);
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extensionLabel.Location = new System.Drawing.Point(753, 323);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(35, 21);
            this.extensionLabel.TabIndex = 8;
            this.extensionLabel.Text = ".xxx";
            // 
            // readMetadataButton
            // 
            this.readMetadataButton.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readMetadataButton.Location = new System.Drawing.Point(759, 357);
            this.readMetadataButton.Name = "readMetadataButton";
            this.readMetadataButton.Size = new System.Drawing.Size(135, 82);
            this.readMetadataButton.TabIndex = 9;
            this.readMetadataButton.Text = "Insert\r\nMetadata";
            this.readMetadataButton.UseVisualStyleBackColor = true;
            this.readMetadataButton.Click += new System.EventHandler(this.readMetadataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(540, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "character:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(560, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "series:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(552, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "GUITAR:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(616, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 23);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(616, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 23);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(616, 413);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 23);
            this.textBox3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 500);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readMetadataButton);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.modifyFilenameButton);
            this.Controls.Add(this.filepathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageNameBox);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.thumbnailViewr);
            this.Controls.Add(this.fileNameViewer);
            this.Controls.Add(this.loadImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileNameViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailViewr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}