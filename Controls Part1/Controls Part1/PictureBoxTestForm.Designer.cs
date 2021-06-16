
namespace Controls_Part1
{
    partial class PictureBoxTestForm
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
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.displayNextImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(32, 62);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(756, 363);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // displayNextImage
            // 
            this.displayNextImage.Location = new System.Drawing.Point(324, 24);
            this.displayNextImage.Name = "displayNextImage";
            this.displayNextImage.Size = new System.Drawing.Size(75, 23);
            this.displayNextImage.TabIndex = 1;
            this.displayNextImage.Text = "Next Image";
            this.displayNextImage.UseVisualStyleBackColor = true;
            this.displayNextImage.Click += new System.EventHandler(this.displayNextImage_Click);
            // 
            // PictureBoxTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayNextImage);
            this.Controls.Add(this.imagePictureBox);
            this.Name = "PictureBoxTestForm";
            this.Text = "PictureBoxTestForm";
            this.Load += new System.EventHandler(this.PictureBoxTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button displayNextImage;
    }
}