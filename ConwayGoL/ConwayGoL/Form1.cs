using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
