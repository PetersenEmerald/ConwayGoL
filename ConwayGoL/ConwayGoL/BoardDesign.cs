using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace ConwayGoL
{
    class BoardDesign : Form
    {
        static readonly int populationArea = Convert.ToInt32(ConfigurationManager.AppSettings["populationArea"]);
        static readonly int cellDimensions = Convert.ToInt32(ConfigurationManager.AppSettings["cellDimensions"]);

        //Create the initial board's dimensions.
        static public void DrawSectionOfBoard(Color drawColor, Graphics graphicToBeDrawn)
        {
            for (int x = 0; x < populationArea; x = x + cellDimensions)
            {
                for (int y = 0; y < populationArea; y = y + cellDimensions)
                {
                    DrawSection(drawColor, graphicToBeDrawn, x, y);
                }
            }
        }

        static public void DrawSection(Color color, Graphics graphicToBeDrawn, int x, int y)
        {
            //Colors inside of cell.
            Brush inUseColor = new SolidBrush(color);
            Rectangle locationOfCell = new Rectangle(x, y, cellDimensions, cellDimensions);
            Region areaToColor = new Region(locationOfCell);
            graphicToBeDrawn.FillRegion(inUseColor, areaToColor);
            String cellKey = x.ToString() + y.ToString();

            //Used to show which rectangle refers to which cell.
            graphicToBeDrawn.DrawString(cellKey, new Font("Tahoma", 8), Brushes.Black, locationOfCell);

            //Creates border around cell.
            Pen penColor = new Pen(Color.Black, 1);
            graphicToBeDrawn.DrawRectangle(penColor, locationOfCell);

        }
    }
}
