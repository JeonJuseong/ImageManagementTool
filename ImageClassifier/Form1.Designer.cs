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
            ((System.ComponentModel.ISupportInitialize)(this.fileNameViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailViewr)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(26, 25);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(78, 44);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "로드";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // fileNameViewer
            // 
            this.fileNameViewer.AllowUserToAddRows = false;
            this.fileNameViewer.AllowUserToDeleteRows = false;
            this.fileNameViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileNameViewer.Location = new System.Drawing.Point(133, 25);
            this.fileNameViewer.Name = "fileNameViewer";
            this.fileNameViewer.ReadOnly = true;
            this.fileNameViewer.RowTemplate.Height = 25;
            this.fileNameViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileNameViewer.Size = new System.Drawing.Size(316, 379);
            this.fileNameViewer.TabIndex = 1;
            this.fileNameViewer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.fileNameViewer_CellEnter);
            // 
            // thumbnailViewr
            // 
            this.thumbnailViewr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.thumbnailViewr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thumbnailViewr.InitialImage = null;
            this.thumbnailViewr.Location = new System.Drawing.Point(514, 25);
            this.thumbnailViewr.Name = "thumbnailViewr";
            this.thumbnailViewr.Size = new System.Drawing.Size(242, 237);
            this.thumbnailViewr.TabIndex = 2;
            this.thumbnailViewr.TabStop = false;
            // 
            // imageName
            // 
            this.imageName.AutoSize = true;
            this.imageName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imageName.Location = new System.Drawing.Point(514, 274);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(62, 21);
            this.imageName.TabIndex = 3;
            this.imageName.Text = "사진명:";
            // 
            // imageNameBox
            // 
            this.imageNameBox.Location = new System.Drawing.Point(582, 274);
            this.imageNameBox.Name = "imageNameBox";
            this.imageNameBox.Size = new System.Drawing.Size(137, 23);
            this.imageNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "filepath: ";
            // 
            // filepathLabel
            // 
            this.filepathLabel.AutoSize = true;
            this.filepathLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filepathLabel.Location = new System.Drawing.Point(184, 407);
            this.filepathLabel.Name = "filepathLabel";
            this.filepathLabel.Size = new System.Drawing.Size(16, 15);
            this.filepathLabel.TabIndex = 6;
            this.filepathLabel.Text = "...";
            // 
            // modifyFilenameButton
            // 
            this.modifyFilenameButton.Location = new System.Drawing.Point(670, 303);
            this.modifyFilenameButton.Name = "modifyFilenameButton";
            this.modifyFilenameButton.Size = new System.Drawing.Size(86, 28);
            this.modifyFilenameButton.TabIndex = 7;
            this.modifyFilenameButton.Text = "파일명 수정";
            this.modifyFilenameButton.UseVisualStyleBackColor = true;
            this.modifyFilenameButton.Click += new System.EventHandler(this.modifyFilenameButton_Click);
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extensionLabel.Location = new System.Drawing.Point(719, 272);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(35, 21);
            this.extensionLabel.TabIndex = 8;
            this.extensionLabel.Text = ".xxx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}