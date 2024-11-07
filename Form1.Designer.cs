namespace AllInOne.NET
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
            this.btnPostToWebhook = new System.Windows.Forms.Button();
            this.btnAllCaps = new System.Windows.Forms.Button();
            this.txtCapitalization = new System.Windows.Forms.TextBox();
            this.btnWriteDataToFile = new System.Windows.Forms.Button();
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.txtCSV1 = new System.Windows.Forms.TextBox();
            this.txtCSV2 = new System.Windows.Forms.TextBox();
            this.txtCSV3 = new System.Windows.Forms.TextBox();
            this.lib1 = new System.Windows.Forms.ListBox();
            this.txtListBoxText = new System.Windows.Forms.TextBox();
            this.btnAddTextToListBox = new System.Windows.Forms.Button();
            this.btnReadDataInFile = new System.Windows.Forms.Button();
            this.btnWriteRegistryValue = new System.Windows.Forms.Button();
            this.btnReadRegistryValue = new System.Windows.Forms.Button();
            this.btnDeleteDataInFile = new System.Windows.Forms.Button();
            this.btnUpdateDataInFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialogue = new System.Windows.Forms.Button();
            this.txtFileDialogue = new System.Windows.Forms.TextBox();
            this.btnChangeBGColor = new System.Windows.Forms.Button();
            this.picChangablePicture = new System.Windows.Forms.PictureBox();
            this.cboImages = new System.Windows.Forms.ComboBox();
            this.txtCSV4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChangablePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPostToWebhook
            // 
            this.btnPostToWebhook.Location = new System.Drawing.Point(23, 27);
            this.btnPostToWebhook.Name = "btnPostToWebhook";
            this.btnPostToWebhook.Size = new System.Drawing.Size(153, 55);
            this.btnPostToWebhook.TabIndex = 0;
            this.btnPostToWebhook.Text = "Post to a Webhook";
            this.btnPostToWebhook.UseVisualStyleBackColor = true;
            this.btnPostToWebhook.Click += new System.EventHandler(this.btnPostToWebhook_Click);
            // 
            // btnAllCaps
            // 
            this.btnAllCaps.Location = new System.Drawing.Point(23, 194);
            this.btnAllCaps.Name = "btnAllCaps";
            this.btnAllCaps.Size = new System.Drawing.Size(153, 54);
            this.btnAllCaps.TabIndex = 1;
            this.btnAllCaps.Text = "Make Textbox Text All Caps";
            this.btnAllCaps.UseVisualStyleBackColor = true;
            this.btnAllCaps.Click += new System.EventHandler(this.btnAllCaps_Click);
            // 
            // txtCapitalization
            // 
            this.txtCapitalization.Location = new System.Drawing.Point(24, 166);
            this.txtCapitalization.Name = "txtCapitalization";
            this.txtCapitalization.Size = new System.Drawing.Size(152, 22);
            this.txtCapitalization.TabIndex = 2;
            // 
            // btnWriteDataToFile
            // 
            this.btnWriteDataToFile.Location = new System.Drawing.Point(436, 86);
            this.btnWriteDataToFile.Name = "btnWriteDataToFile";
            this.btnWriteDataToFile.Size = new System.Drawing.Size(152, 24);
            this.btnWriteDataToFile.TabIndex = 3;
            this.btnWriteDataToFile.Text = "Write Data To A File";
            this.btnWriteDataToFile.UseVisualStyleBackColor = true;
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.Location = new System.Drawing.Point(24, 325);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(154, 47);
            this.btnReadCSV.TabIndex = 4;
            this.btnReadCSV.Text = "Read A CSV File";
            this.btnReadCSV.UseVisualStyleBackColor = true;
            this.btnReadCSV.Click += new System.EventHandler(this.btnReadCSV_Click);
            // 
            // txtCSV1
            // 
            this.txtCSV1.Location = new System.Drawing.Point(24, 378);
            this.txtCSV1.Name = "txtCSV1";
            this.txtCSV1.Size = new System.Drawing.Size(66, 22);
            this.txtCSV1.TabIndex = 5;
            this.txtCSV1.Text = "Combine";
            // 
            // txtCSV2
            // 
            this.txtCSV2.Location = new System.Drawing.Point(96, 379);
            this.txtCSV2.Name = "txtCSV2";
            this.txtCSV2.Size = new System.Drawing.Size(36, 22);
            this.txtCSV2.TabIndex = 6;
            this.txtCSV2.Text = "Text";
            // 
            // txtCSV3
            // 
            this.txtCSV3.Location = new System.Drawing.Point(138, 379);
            this.txtCSV3.Name = "txtCSV3";
            this.txtCSV3.Size = new System.Drawing.Size(40, 22);
            this.txtCSV3.TabIndex = 7;
            this.txtCSV3.Text = "Here";
            // 
            // lib1
            // 
            this.lib1.FormattingEnabled = true;
            this.lib1.ItemHeight = 16;
            this.lib1.Location = new System.Drawing.Point(212, 125);
            this.lib1.Name = "lib1";
            this.lib1.Size = new System.Drawing.Size(188, 148);
            this.lib1.TabIndex = 8;
            // 
            // txtListBoxText
            // 
            this.txtListBoxText.Location = new System.Drawing.Point(212, 97);
            this.txtListBoxText.Name = "txtListBoxText";
            this.txtListBoxText.Size = new System.Drawing.Size(188, 22);
            this.txtListBoxText.TabIndex = 9;
            // 
            // btnAddTextToListBox
            // 
            this.btnAddTextToListBox.Location = new System.Drawing.Point(212, 68);
            this.btnAddTextToListBox.Name = "btnAddTextToListBox";
            this.btnAddTextToListBox.Size = new System.Drawing.Size(188, 23);
            this.btnAddTextToListBox.TabIndex = 10;
            this.btnAddTextToListBox.Text = "Add Text To List Box";
            this.btnAddTextToListBox.UseVisualStyleBackColor = true;
            this.btnAddTextToListBox.Click += new System.EventHandler(this.btnAddTextToListBox_Click);
            // 
            // btnReadDataInFile
            // 
            this.btnReadDataInFile.Location = new System.Drawing.Point(437, 27);
            this.btnReadDataInFile.Name = "btnReadDataInFile";
            this.btnReadDataInFile.Size = new System.Drawing.Size(152, 23);
            this.btnReadDataInFile.TabIndex = 11;
            this.btnReadDataInFile.Text = "Reads Data In File";
            this.btnReadDataInFile.UseVisualStyleBackColor = true;
            // 
            // btnWriteRegistryValue
            // 
            this.btnWriteRegistryValue.Location = new System.Drawing.Point(212, 325);
            this.btnWriteRegistryValue.Name = "btnWriteRegistryValue";
            this.btnWriteRegistryValue.Size = new System.Drawing.Size(188, 47);
            this.btnWriteRegistryValue.TabIndex = 12;
            this.btnWriteRegistryValue.Text = "Write A Registry Value";
            this.btnWriteRegistryValue.UseVisualStyleBackColor = true;
            this.btnWriteRegistryValue.Click += new System.EventHandler(this.btnWriteRegistryValue_Click);
            // 
            // btnReadRegistryValue
            // 
            this.btnReadRegistryValue.Location = new System.Drawing.Point(212, 378);
            this.btnReadRegistryValue.Name = "btnReadRegistryValue";
            this.btnReadRegistryValue.Size = new System.Drawing.Size(188, 47);
            this.btnReadRegistryValue.TabIndex = 13;
            this.btnReadRegistryValue.Text = "Read A Registry Value";
            this.btnReadRegistryValue.UseVisualStyleBackColor = true;
            this.btnReadRegistryValue.Click += new System.EventHandler(this.btnReadRegistryValue_Click);
            // 
            // btnDeleteDataInFile
            // 
            this.btnDeleteDataInFile.Location = new System.Drawing.Point(436, 146);
            this.btnDeleteDataInFile.Name = "btnDeleteDataInFile";
            this.btnDeleteDataInFile.Size = new System.Drawing.Size(152, 23);
            this.btnDeleteDataInFile.TabIndex = 15;
            this.btnDeleteDataInFile.Text = "Deletes Data In File";
            this.btnDeleteDataInFile.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDataInFile
            // 
            this.btnUpdateDataInFile.Location = new System.Drawing.Point(437, 116);
            this.btnUpdateDataInFile.Name = "btnUpdateDataInFile";
            this.btnUpdateDataInFile.Size = new System.Drawing.Size(152, 24);
            this.btnUpdateDataInFile.TabIndex = 14;
            this.btnUpdateDataInFile.Text = "Update Data In A File";
            this.btnUpdateDataInFile.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(437, 57);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(151, 22);
            this.txtFilePath.TabIndex = 16;
            // 
            // btnOpenFileDialogue
            // 
            this.btnOpenFileDialogue.Location = new System.Drawing.Point(436, 216);
            this.btnOpenFileDialogue.Name = "btnOpenFileDialogue";
            this.btnOpenFileDialogue.Size = new System.Drawing.Size(189, 32);
            this.btnOpenFileDialogue.TabIndex = 17;
            this.btnOpenFileDialogue.Text = "Use the Open File Dialogue";
            this.btnOpenFileDialogue.UseVisualStyleBackColor = true;
            // 
            // txtFileDialogue
            // 
            this.txtFileDialogue.Location = new System.Drawing.Point(436, 250);
            this.txtFileDialogue.Name = "txtFileDialogue";
            this.txtFileDialogue.Size = new System.Drawing.Size(100, 22);
            this.txtFileDialogue.TabIndex = 18;
            // 
            // btnChangeBGColor
            // 
            this.btnChangeBGColor.Location = new System.Drawing.Point(436, 367);
            this.btnChangeBGColor.Name = "btnChangeBGColor";
            this.btnChangeBGColor.Size = new System.Drawing.Size(188, 46);
            this.btnChangeBGColor.TabIndex = 19;
            this.btnChangeBGColor.Text = "Use the Color Dialogue to Change BG Color";
            this.btnChangeBGColor.UseVisualStyleBackColor = true;
            // 
            // picChangablePicture
            // 
            this.picChangablePicture.Image = global::AllInOne.NET.Properties.Resources.SSINC_LOGO;
            this.picChangablePicture.Location = new System.Drawing.Point(631, 68);
            this.picChangablePicture.Name = "picChangablePicture";
            this.picChangablePicture.Size = new System.Drawing.Size(140, 142);
            this.picChangablePicture.TabIndex = 20;
            this.picChangablePicture.TabStop = false;
            // 
            // cboImages
            // 
            this.cboImages.FormattingEnabled = true;
            this.cboImages.Location = new System.Drawing.Point(631, 25);
            this.cboImages.Name = "cboImages";
            this.cboImages.Size = new System.Drawing.Size(121, 24);
            this.cboImages.TabIndex = 21;
            // 
            // txtCSV4
            // 
            this.txtCSV4.Location = new System.Drawing.Point(24, 407);
            this.txtCSV4.Name = "txtCSV4";
            this.txtCSV4.Size = new System.Drawing.Size(154, 22);
            this.txtCSV4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCSV4);
            this.Controls.Add(this.cboImages);
            this.Controls.Add(this.picChangablePicture);
            this.Controls.Add(this.btnChangeBGColor);
            this.Controls.Add(this.txtFileDialogue);
            this.Controls.Add(this.btnOpenFileDialogue);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnDeleteDataInFile);
            this.Controls.Add(this.btnUpdateDataInFile);
            this.Controls.Add(this.btnReadRegistryValue);
            this.Controls.Add(this.btnWriteRegistryValue);
            this.Controls.Add(this.btnReadDataInFile);
            this.Controls.Add(this.btnAddTextToListBox);
            this.Controls.Add(this.txtListBoxText);
            this.Controls.Add(this.lib1);
            this.Controls.Add(this.txtCSV3);
            this.Controls.Add(this.txtCSV2);
            this.Controls.Add(this.txtCSV1);
            this.Controls.Add(this.btnReadCSV);
            this.Controls.Add(this.btnWriteDataToFile);
            this.Controls.Add(this.txtCapitalization);
            this.Controls.Add(this.btnAllCaps);
            this.Controls.Add(this.btnPostToWebhook);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picChangablePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostToWebhook;
        private System.Windows.Forms.Button btnAllCaps;
        private System.Windows.Forms.TextBox txtCapitalization;
        private System.Windows.Forms.Button btnWriteDataToFile;
        private System.Windows.Forms.Button btnReadCSV;
        private System.Windows.Forms.TextBox txtCSV1;
        private System.Windows.Forms.TextBox txtCSV2;
        private System.Windows.Forms.TextBox txtCSV3;
        private System.Windows.Forms.ListBox lib1;
        private System.Windows.Forms.TextBox txtListBoxText;
        private System.Windows.Forms.Button btnAddTextToListBox;
        private System.Windows.Forms.Button btnReadDataInFile;
        private System.Windows.Forms.Button btnWriteRegistryValue;
        private System.Windows.Forms.Button btnReadRegistryValue;
        private System.Windows.Forms.Button btnDeleteDataInFile;
        private System.Windows.Forms.Button btnUpdateDataInFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpenFileDialogue;
        private System.Windows.Forms.TextBox txtFileDialogue;
        private System.Windows.Forms.Button btnChangeBGColor;
        private System.Windows.Forms.PictureBox picChangablePicture;
        private System.Windows.Forms.ComboBox cboImages;
        private System.Windows.Forms.TextBox txtCSV4;
    }
}

