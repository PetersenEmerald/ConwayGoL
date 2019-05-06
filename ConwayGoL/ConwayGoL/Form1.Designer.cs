namespace ConwayGoL
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
            this.startButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cellNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1605, 495);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 139);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1605, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 114);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cycle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cycleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1318, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please insert initial cell number between 0 - 9999:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cellNumber
            // 
            this.cellNumber.AcceptsReturn = true;
            this.cellNumber.AcceptsTab = true;
            this.cellNumber.Location = new System.Drawing.Point(1823, 285);
            this.cellNumber.MaxLength = 999;
            this.cellNumber.Name = "cellNumber";
            this.cellNumber.Size = new System.Drawing.Size(100, 31);
            this.cellNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1965, 1069);
            this.Controls.Add(this.cellNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cellNumber;
    }
}

