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
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.title = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(25, 396);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(157, 107);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 107);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cycle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cycleButton_Click);
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
            this.title.Location = new System.Drawing.Point(540, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(237, 31);
            this.title.TabIndex = 5;
            this.title.Text = "Conway\'s Game of Life";
            this.title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "How to Play:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(595, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(481, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Click Start to create initial cells.";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(595, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(481, 31);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Click Cycle to start the next birth and death cycle.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(559, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Rules:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(595, 270);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(592, 31);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "A dead cell becomes alive when it has three neighbors.";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(595, 307);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(592, 31);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "A cell survives if it has 2 or 3 neighbors.";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(595, 344);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(592, 31);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "A cell dies if it has less than 2 neighbors due to isolation.";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(595, 381);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(592, 31);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "A cell dies if it has 4 or more neighbors due to overpopulation.";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(218, 659);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(847, 31);
            this.textBox9.TabIndex = 14;
            this.textBox9.Text = "Conway\'s Game of Life is a zero player game modeling population growth and declin" +
    "e.";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(445, 696);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(346, 31);
            this.textBox10.TabIndex = 15;
            this.textBox10.Text = "Code Written by Emerald Petersen";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(559, 450);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(232, 31);
            this.textBox11.TabIndex = 16;
            this.textBox11.Text = "Cell Colour Meaning:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(595, 498);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(592, 31);
            this.textBox12.TabIndex = 17;
            this.textBox12.Text = "Green cells represent live cell state.";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(595, 535);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(592, 31);
            this.textBox13.TabIndex = 18;
            this.textBox13.Text = "Red cells represent dead cells that were once alive.";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(595, 572);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(592, 31);
            this.textBox14.TabIndex = 19;
            this.textBox14.Text = "Cells that are not green or red have not been used in game.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 778);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life - C# Implementation with Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
    }
}

