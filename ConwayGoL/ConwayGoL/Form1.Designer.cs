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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.cycleButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.title = new System.Windows.Forms.TextBox();
            this.titlePlay = new System.Windows.Forms.TextBox();
            this.step1 = new System.Windows.Forms.TextBox();
            this.step2 = new System.Windows.Forms.TextBox();
            this.titleRules = new System.Windows.Forms.TextBox();
            this.rule1 = new System.Windows.Forms.TextBox();
            this.rule2 = new System.Windows.Forms.TextBox();
            this.rule3 = new System.Windows.Forms.TextBox();
            this.rule4 = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.developer = new System.Windows.Forms.TextBox();
            this.titleColour = new System.Windows.Forms.TextBox();
            this.colour1 = new System.Windows.Forms.TextBox();
            this.colour2 = new System.Windows.Forms.TextBox();
            this.colour3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 206);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(78, 56);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cycleButton
            // 
            this.cycleButton.Location = new System.Drawing.Point(104, 206);
            this.cycleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cycleButton.Name = "cycleButton";
            this.cycleButton.Size = new System.Drawing.Size(78, 56);
            this.cycleButton.TabIndex = 2;
            this.cycleButton.Text = "Cycle";
            this.cycleButton.UseVisualStyleBackColor = true;
            this.cycleButton.Click += new System.EventHandler(this.cycleButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.ForeColor = System.Drawing.Color.DarkGreen;
            this.title.Location = new System.Drawing.Point(280, 1);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 20);
            this.title.TabIndex = 5;
            this.title.Text = "Conway\'s Game of Life";
            this.title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // titlePlay
            // 
            this.titlePlay.Location = new System.Drawing.Point(280, 39);
            this.titlePlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titlePlay.Name = "titlePlay";
            this.titlePlay.Size = new System.Drawing.Size(75, 20);
            this.titlePlay.TabIndex = 6;
            this.titlePlay.Text = "How to Play:";
            this.titlePlay.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // step1
            // 
            this.step1.Location = new System.Drawing.Point(298, 64);
            this.step1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(242, 20);
            this.step1.TabIndex = 7;
            this.step1.Text = "Click Start to create initial cells.";
            this.step1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // step2
            // 
            this.step2.Location = new System.Drawing.Point(298, 83);
            this.step2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(242, 20);
            this.step2.TabIndex = 8;
            this.step2.Text = "Click Cycle to start the next birth and death cycle.";
            // 
            // titleRules
            // 
            this.titleRules.Location = new System.Drawing.Point(280, 116);
            this.titleRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleRules.Name = "titleRules";
            this.titleRules.Size = new System.Drawing.Size(52, 20);
            this.titleRules.TabIndex = 9;
            this.titleRules.Text = "Rules:";
            this.titleRules.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // rule1
            // 
            this.rule1.Location = new System.Drawing.Point(298, 140);
            this.rule1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(298, 20);
            this.rule1.TabIndex = 10;
            this.rule1.Text = "A dead cell becomes alive when it has three neighbors.";
            this.rule1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // rule2
            // 
            this.rule2.Location = new System.Drawing.Point(298, 160);
            this.rule2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rule2.Name = "rule2";
            this.rule2.Size = new System.Drawing.Size(298, 20);
            this.rule2.TabIndex = 11;
            this.rule2.Text = "A cell survives if it has 2 or 3 neighbors.";
            this.rule2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // rule3
            // 
            this.rule3.Location = new System.Drawing.Point(298, 179);
            this.rule3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rule3.Name = "rule3";
            this.rule3.Size = new System.Drawing.Size(298, 20);
            this.rule3.TabIndex = 12;
            this.rule3.Text = "A cell dies if it has less than 2 neighbors due to isolation.";
            // 
            // rule4
            // 
            this.rule4.Location = new System.Drawing.Point(298, 198);
            this.rule4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rule4.Name = "rule4";
            this.rule4.Size = new System.Drawing.Size(298, 20);
            this.rule4.TabIndex = 13;
            this.rule4.Text = "A cell dies if it has 4 or more neighbors due to overpopulation.";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(109, 343);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(426, 20);
            this.description.TabIndex = 14;
            this.description.Text = "Conway\'s Game of Life is a zero player game modeling population growth and declin" +
    "e.";
            this.description.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // developer
            // 
            this.developer.Location = new System.Drawing.Point(222, 362);
            this.developer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(175, 20);
            this.developer.TabIndex = 15;
            this.developer.Text = "Code Written by Emerald Petersen";
            this.developer.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // titleColour
            // 
            this.titleColour.Location = new System.Drawing.Point(280, 234);
            this.titleColour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleColour.Name = "titleColour";
            this.titleColour.Size = new System.Drawing.Size(118, 20);
            this.titleColour.TabIndex = 16;
            this.titleColour.Text = "Cell Colour Meaning:";
            // 
            // colour1
            // 
            this.colour1.Location = new System.Drawing.Point(298, 259);
            this.colour1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colour1.Name = "colour1";
            this.colour1.Size = new System.Drawing.Size(298, 20);
            this.colour1.TabIndex = 17;
            this.colour1.Text = "Green cells represent live cell state.";
            // 
            // colour2
            // 
            this.colour2.Location = new System.Drawing.Point(298, 278);
            this.colour2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colour2.Name = "colour2";
            this.colour2.Size = new System.Drawing.Size(298, 20);
            this.colour2.TabIndex = 18;
            this.colour2.Text = "Red cells represent dead cells that were once alive.";
            this.colour2.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // colour3
            // 
            this.colour3.Location = new System.Drawing.Point(298, 297);
            this.colour3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colour3.Name = "colour3";
            this.colour3.Size = new System.Drawing.Size(298, 20);
            this.colour3.TabIndex = 19;
            this.colour3.Text = "Cells that are not green or red have not been used in game.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.colour3);
            this.Controls.Add(this.colour2);
            this.Controls.Add(this.colour1);
            this.Controls.Add(this.titleColour);
            this.Controls.Add(this.developer);
            this.Controls.Add(this.description);
            this.Controls.Add(this.rule4);
            this.Controls.Add(this.rule3);
            this.Controls.Add(this.rule2);
            this.Controls.Add(this.rule1);
            this.Controls.Add(this.titleRules);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.titlePlay);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cycleButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life - C# Implementation with Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cycleButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox titlePlay;
        private System.Windows.Forms.TextBox step1;
        private System.Windows.Forms.TextBox step2;
        private System.Windows.Forms.TextBox titleRules;
        private System.Windows.Forms.TextBox rule1;
        private System.Windows.Forms.TextBox rule2;
        private System.Windows.Forms.TextBox rule3;
        private System.Windows.Forms.TextBox rule4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox developer;
        private System.Windows.Forms.TextBox titleColour;
        private System.Windows.Forms.TextBox colour1;
        private System.Windows.Forms.TextBox colour2;
        private System.Windows.Forms.TextBox colour3;
    }
}

