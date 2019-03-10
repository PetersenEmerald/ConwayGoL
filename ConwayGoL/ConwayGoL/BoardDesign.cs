using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ConwayGoL
{
    class BoardDesign : Form
    {
        
        static public void DrawSectionOfBoard(int homeDimensions, int homeArea, Pen penStyle, Graphics graphicToBeDrawn)
        {
            for (int x = 0; x < homeArea; x = x + homeDimensions)
            {
                for (int y = 0; y < homeArea; y = y + homeDimensions)
                {
                    DrawSection(homeDimensions, penStyle, graphicToBeDrawn, x, y);
                }
            }
        }

        private void DrawLiveCell(int homeDimensions, int homeArea, Pen penStyle, Graphics graphicToBeDrawn, bool drawBoard)
        {
            Random randomLocation = new Random();
            int cellStateLocationX = randomLocation.Next(0, homeArea / homeDimensions);
            int cellStateLocationY = randomLocation.Next(0, homeArea / homeDimensions);

            LiveCells.PopulateCell(cellStateLocationX, cellStateLocationY);

            DrawSection(homeDimensions, penStyle, graphicToBeDrawn,
                cellStateLocationX * homeDimensions,
                cellStateLocationY * homeDimensions);
        }

        static public void DrawSection(int homeDimensions, Pen penStyle, Graphics graphicToBeDrawn, int x, int y)
        {
            graphicToBeDrawn.DrawRectangle(penStyle, x, y, homeDimensions, homeDimensions);

        }
    }
}
