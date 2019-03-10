using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConwayGoL
{
    class LiveCells
    {
        static Hashtable livingCells = new Hashtable();

        static public void RandomizeInitialState(int homeDimensions, int homeArea, Graphics liveCellInitial)
        {
            Pen liveCellCreator = new Pen(Color.Green, 2);
            Random randomNumber = new Random();

            int liveCells = randomNumber.Next(1, homeArea / homeDimensions);
            int x = randomNumber.Next(0, homeArea / homeDimensions) * homeDimensions;
            int y = randomNumber.Next(0, homeArea / homeDimensions) * homeDimensions;
            PopulateCell(x, y);

            for (int numberOfCells = 0; numberOfCells < liveCells; numberOfCells++)
            {
                BoardDesign.DrawSection(homeDimensions, liveCellCreator, liveCellInitial, x, y);
            }
        }

        static public void PopulateCell(int x, int y)
        {
            int[] cellCoordinates = { x, y };

            livingCells.Add(cellCoordinates, 1);
        }


        private void KillCells(int[] coord)
        {
                livingCells.Remove(coord);
        }

        private int NumberOfNeighbors(int[] coord)
        {
            int neighborCount = 0;

            if(livingCells.ContainsKey(coord))
            {
                for(int i = -1; i < 2; i++)
                {
                    int[] neighbor1 = { coord[0] + i, coord[1] - 1 };
                    int[] neighbor2 = { coord[0] + i, coord[1] };
                    int[] neighbor3 = { coord[0] + i, coord[1] + 1 };

                    if (livingCells.ContainsKey(neighbor1))
                    {
                        neighborCount++;
                    }
                    if (livingCells.ContainsKey(neighbor2) && !neighbor2.Equals(coord))
                    {
                        neighborCount++;
                    }
                    if (livingCells.ContainsKey(neighbor3))
                    {
                        neighborCount++;
                    }
                }
            }

            return neighborCount;
        }
    }
}
