
namespace GiftFactory
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.CarButton = new System.Windows.Forms.Button();
            this.BallButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.PresentButton = new System.Windows.Forms.Button();
            this.presentColor1Button = new System.Windows.Forms.Button();
            this.presentColor2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 257);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 181);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // CarButton
            // 
            this.CarButton.Location = new System.Drawing.Point(12, 78);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(118, 61);
            this.CarButton.TabIndex = 1;
            this.CarButton.Text = "Car";
            this.CarButton.UseVisualStyleBackColor = true;
            this.CarButton.Click += new System.EventHandler(this.CarButton_Click);
            // 
            // BallButton
            // 
            this.BallButton.Location = new System.Drawing.Point(175, 78);
            this.BallButton.Name = "BallButton";
            this.BallButton.Size = new System.Drawing.Size(126, 65);
            this.BallButton.TabIndex = 2;
            this.BallButton.Text = "Ball";
            this.BallButton.UseVisualStyleBackColor = true;
            this.BallButton.Click += new System.EventHandler(this.BallButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming Next";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Crimson;
            this.colorButton.Location = new System.Drawing.Point(175, 149);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(126, 30);
            this.colorButton.TabIndex = 4;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // PresentButton
            // 
            this.PresentButton.Location = new System.Drawing.Point(324, 78);
            this.PresentButton.Name = "PresentButton";
            this.PresentButton.Size = new System.Drawing.Size(126, 65);
            this.PresentButton.TabIndex = 5;
            this.PresentButton.Text = "Present";
            this.PresentButton.UseVisualStyleBackColor = true;
            this.PresentButton.Click += new System.EventHandler(this.PresentButton_Click);
            // 
            // presentColor1Button
            // 
            this.presentColor1Button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.presentColor1Button.Location = new System.Drawing.Point(324, 149);
            this.presentColor1Button.Name = "presentColor1Button";
            this.presentColor1Button.Size = new System.Drawing.Size(126, 30);
            this.presentColor1Button.TabIndex = 6;
            this.presentColor1Button.UseVisualStyleBackColor = false;
            this.presentColor1Button.Click += new System.EventHandler(this.presentColor1Button_Click);
            // 
            // presentColor2Button
            // 
            this.presentColor2Button.BackColor = System.Drawing.Color.OliveDrab;
            this.presentColor2Button.Location = new System.Drawing.Point(324, 185);
            this.presentColor2Button.Name = "presentColor2Button";
            this.presentColor2Button.Size = new System.Drawing.Size(126, 30);
            this.presentColor2Button.TabIndex = 7;
            this.presentColor2Button.UseVisualStyleBackColor = false;
            this.presentColor2Button.Click += new System.EventHandler(this.presentColor2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.presentColor2Button);
            this.Controls.Add(this.presentColor1Button);
            this.Controls.Add(this.PresentButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BallButton);
            this.Controls.Add(this.CarButton);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button CarButton;
        private System.Windows.Forms.Button BallButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button PresentButton;
        private System.Windows.Forms.Button presentColor1Button;
        private System.Windows.Forms.Button presentColor2Button;
    }
}

