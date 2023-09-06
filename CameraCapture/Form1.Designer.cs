namespace CameraCapture
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
            this.comboBoxWebcamList = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLive = new System.Windows.Forms.PictureBox();
            this.pictureBoxSavedImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSavedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxWebcamList
            // 
            this.comboBoxWebcamList.FormattingEnabled = true;
            this.comboBoxWebcamList.Location = new System.Drawing.Point(30, 23);
            this.comboBoxWebcamList.Name = "comboBoxWebcamList";
            this.comboBoxWebcamList.Size = new System.Drawing.Size(95, 21);
            this.comboBoxWebcamList.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(131, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(83, 26);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(220, 19);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(83, 26);
            this.buttonCapture.TabIndex = 2;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(309, 19);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(83, 26);
            this.buttonSaveImage.TabIndex = 3;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(705, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(83, 26);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLive, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxSavedImage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 387);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBoxLive
            // 
            this.pictureBoxLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLive.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLive.Name = "pictureBoxLive";
            this.pictureBoxLive.Size = new System.Drawing.Size(373, 381);
            this.pictureBoxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLive.TabIndex = 0;
            this.pictureBoxLive.TabStop = false;
            // 
            // pictureBoxSavedImage
            // 
            this.pictureBoxSavedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSavedImage.Location = new System.Drawing.Point(382, 3);
            this.pictureBoxSavedImage.Name = "pictureBoxSavedImage";
            this.pictureBoxSavedImage.Size = new System.Drawing.Size(373, 381);
            this.pictureBoxSavedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSavedImage.TabIndex = 1;
            this.pictureBoxSavedImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxWebcamList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSavedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWebcamList;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLive;
        private System.Windows.Forms.PictureBox pictureBoxSavedImage;
    }
}

