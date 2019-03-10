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
            Random randomNumber = new Random();

            //int liveCells = randomNumber.Next(1, homeArea / homeDimensions);
            int liveCells = 100;

            for (int numberOfCells = 0; numberOfCells < liveCells; numberOfCells++)
            {
                int x = randomNumber.Next(0, homeArea / homeDimensions) * homeDimensions;
                int y = randomNumber.Next(0, homeArea / homeDimensions) * homeDimensions;

                CellCreator(homeDimensions, liveCellInitial, x, y);
            }
        }

        static public void CycleState(int homeArea, int homeDimensions, Graphics populateCells)
        {
            int numberOfCells = homeArea;
            int neighbors = 0;

            for (int x = 0; x < numberOfCells; x++)
            {
                for (int y = 0; y < numberOfCells; y++)
                {
                    int[] coord = { x, y };
                    neighbors = NumberOfNeighbors(coord);
                    if ((string)livingCells[coord] == "1")
                    {
                        if (neighbors < 2)
                        {
                            CellKiller(homeDimensions, populateCells, x, y);
                        }
                        if (neighbors > 3)
                        {
                            CellKiller(homeDimensions, populateCells, x, y);
                        }
                    }
                    if ((string)livingCells[coord] == "0" || (string)livingCells[coord] == null)
                    {
                        if (neighbors == 3)
                        {
                            PopulateCell(coord);
                        }
                    }
                }
            }

        }

        static private void CellCreator(int homeDimensions, Graphics liveCellInitial, int x, int y)
        {
            int[] coord = { x, y };
            Pen liveCellCreator = new Pen(Color.Green, 2);

            PopulateCell(coord);

            if (Int32.Parse(livingCells[coord].ToString()) == 1)
            {
                BoardDesign.DrawSection(homeDimensions, liveCellCreator, liveCellInitial, x, y);
            }
        }

        static private void CellKiller(int homeDimensions, Graphics killZone, int x, int y)
        {
            int[] coord = { x, y };
            Pen liveCellCreator = new Pen(Color.Red, 2);

            PopulateCell(coord);

            if (Int32.Parse(livingCells[coord].ToString()) == 1)
            {
                BoardDesign.DrawSection(homeDimensions, liveCellCreator, killZone, x, y);
            }
        }

        static public void PopulateCell(int[] coord)
        {

            if (!livingCells.ContainsKey(coord))
            {
                livingCells.Add(coord, 1);
            }
            else
            {
                livingCells.Add(coord, 0);

            }
        }

        static private int NumberOfNeighbors(int[] coord)
        {
            int neighborCount = 0;

            if (livingCells.ContainsKey(coord))
            {
                for (int i = -1; i < 2; i++)
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
