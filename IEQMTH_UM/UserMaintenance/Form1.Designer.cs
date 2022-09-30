
namespace UserMaintenance
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(325, 420);
            this.listBox.TabIndex = 0;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(368, 35);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(46, 17);
            this.labelTop.TabIndex = 1;
            this.labelTop.Text = "label1";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(371, 69);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(46, 17);
            this.labelLow.TabIndex = 2;
            this.labelLow.Text = "label2";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(387, 120);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(227, 50);
            this.button.TabIndex = 3;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            // 
            // textBoxTop
            // 
            this.textBoxTop.Location = new System.Drawing.Point(421, 35);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.Size = new System.Drawing.Size(177, 22);
            this.textBoxTop.TabIndex = 4;
            // 
            // textBoxLow
            // 
            this.textBoxLow.Location = new System.Drawing.Point(421, 69);
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(177, 22);
            this.textBoxLow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.textBoxLow);
            this.Controls.Add(this.textBoxTop);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxTop;
        private System.Windows.Forms.TextBox textBoxLow;
    }
}

