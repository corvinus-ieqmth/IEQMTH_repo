
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
            this.buttonToSave = new System.Windows.Forms.Button();
            this.buttonToDelete = new System.Windows.Forms.Button();
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
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
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
            this.button.Click += new System.EventHandler(this.button_Click);
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
            // buttonToSave
            // 
            this.buttonToSave.Location = new System.Drawing.Point(397, 409);
            this.buttonToSave.Name = "buttonToSave";
            this.buttonToSave.Size = new System.Drawing.Size(201, 23);
            this.buttonToSave.TabIndex = 6;
            this.buttonToSave.Text = "button1";
            this.buttonToSave.UseVisualStyleBackColor = true;
            this.buttonToSave.Click += new System.EventHandler(this.buttonToSave_Click);
            // 
            // buttonToDelete
            // 
            this.buttonToDelete.Location = new System.Drawing.Point(421, 176);
            this.buttonToDelete.Name = "buttonToDelete";
            this.buttonToDelete.Size = new System.Drawing.Size(177, 60);
            this.buttonToDelete.TabIndex = 7;
            this.buttonToDelete.Text = "button1";
            this.buttonToDelete.UseVisualStyleBackColor = true;
            this.buttonToDelete.Click += new System.EventHandler(this.buttonToDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.buttonToDelete);
            this.Controls.Add(this.buttonToSave);
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
        private System.Windows.Forms.Button buttonToSave;
        private System.Windows.Forms.Button buttonToDelete;
    }
}

