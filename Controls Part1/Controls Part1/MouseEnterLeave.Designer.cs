
namespace Controls_Part1
{
    partial class MouseEnterLeave
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
            this.SuspendLayout();
            // 
            // MouseEnterLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MouseEnterLeave";
            this.Text = "MouseEnterLeave";
            this.MouseEnter += new System.EventHandler(this.MouseEnterLeave_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MouseEnterLeave_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MouseEnterLeave_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}