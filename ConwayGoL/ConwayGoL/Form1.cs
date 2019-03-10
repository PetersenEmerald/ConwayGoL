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
            Graphics drawBoard = this.CreateGraphics();

            Pen boardCreator = new Pen(Color.Black, 1);
            int homeDimensions = 10;
            int homeArea = 200;

            BoardDesign.DrawSectionOfBoard(homeDimensions, homeArea, boardCreator, drawBoard);

            Graphics liveCellInitial = this.CreateGraphics();
            LiveCells.RandomizeInitialState(homeDimensions, homeArea, liveCellInitial);
        }

        private void cycleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
