using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            for(int x = 0; x < homeArea; x = x + homeDimensions)
            {
                for(int y = 0; y < homeArea; y = y + homeDimensions)
                {
                    drawBoard.DrawRectangle(boardCreator, x, y, homeDimensions, homeDimensions);
                }

            }

        }
    }
}
