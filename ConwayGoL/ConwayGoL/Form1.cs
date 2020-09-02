using System;
using System.Windows.Forms;
using System.Drawing;


namespace ConwayGoL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;

            //Design Initial Board
            Graphics drawBoard = this.CreateGraphics();
            BoardDesign.DrawSectionOfBoard(Color.AntiqueWhite, drawBoard);

            //Populate Initial Cells
            Graphics liveCellInitial = this.CreateGraphics();
            LiveCells.CreateInitialState(liveCellInitial);
        }

        private void cycleButton_Click(object sender, EventArgs e)
        {
            Graphics populateCells = this.CreateGraphics();
            LiveCells.CycleState(populateCells);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void textBox6_TextChanged(object sender, EventArgs e) { }

        private void textBox9_TextChanged(object sender, EventArgs e) { }

        private void textBox10_TextChanged(object sender, EventArgs e) { }

        private void textBox13_TextChanged(object sender, EventArgs e) { }
    }
}
