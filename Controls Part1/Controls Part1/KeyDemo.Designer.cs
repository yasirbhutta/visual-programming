
namespace Controls_Part1
{
    partial class KeyDemo
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
            this.keyInfoLabel = new System.Windows.Forms.Label();
            this.charLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyInfoLabel
            // 
            this.keyInfoLabel.AutoSize = true;
            this.keyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.keyInfoLabel.Location = new System.Drawing.Point(181, 135);
            this.keyInfoLabel.Name = "keyInfoLabel";
            this.keyInfoLabel.Size = new System.Drawing.Size(100, 37);
            this.keyInfoLabel.TabIndex = 0;
            this.keyInfoLabel.Text = "label1";
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLabel.ForeColor = System.Drawing.Color.Maroon;
            this.charLabel.Location = new System.Drawing.Point(184, 58);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(85, 29);
            this.charLabel.TabIndex = 1;
            this.charLabel.Text = "label1";
            // 
            // KeyDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.keyInfoLabel);
            this.Name = "KeyDemo";
            this.Text = "KeyDemo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDemo_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyInfoLabel;
        private System.Windows.Forms.Label charLabel;
    }
}