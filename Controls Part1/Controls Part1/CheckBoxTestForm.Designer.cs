
namespace Controls_Part1
{
    partial class CheckBoxTestForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.messageDisplay = new System.Windows.Forms.Label();
            this.messageDisplay2 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // messageDisplay
            // 
            this.messageDisplay.AutoSize = true;
            this.messageDisplay.Location = new System.Drawing.Point(334, 49);
            this.messageDisplay.Name = "messageDisplay";
            this.messageDisplay.Size = new System.Drawing.Size(50, 13);
            this.messageDisplay.TabIndex = 1;
            this.messageDisplay.Text = "Checked";
            // 
            // messageDisplay2
            // 
            this.messageDisplay2.AutoSize = true;
            this.messageDisplay2.Location = new System.Drawing.Point(334, 83);
            this.messageDisplay2.Name = "messageDisplay2";
            this.messageDisplay2.Size = new System.Drawing.Size(66, 13);
            this.messageDisplay2.TabIndex = 2;
            this.messageDisplay2.Text = "Check State";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(129, 211);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(138, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "watch the font style change";
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(132, 309);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.boldCheckBox.TabIndex = 4;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(309, 309);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(47, 17);
            this.italicCheckBox.TabIndex = 5;
            this.italicCheckBox.Text = "italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(97, 127);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "To check checked property";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CheckBoxTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.messageDisplay2);
            this.Controls.Add(this.messageDisplay);
            this.Controls.Add(this.checkBox1);
            this.Name = "CheckBoxTestForm";
            this.Text = "CheckBoxTestForm";
            this.Load += new System.EventHandler(this.CheckBoxTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label messageDisplay;
        private System.Windows.Forms.Label messageDisplay2;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}