using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;

namespace ConwayGoL
{
    class LiveCells
    {
        static Hashtable cells = new Hashtable();
        static readonly int populationArea = Convert.ToInt32(ConfigurationManager.AppSettings["populationArea"]);
        static readonly int cellDimensions = Convert.ToInt32(ConfigurationManager.AppSettings["cellDimensions"]);

        //Initializes the data for all initial cells, alive or dead.
        static public void CreateCellBodies()
        {
            for (int x = 0; x < populationArea; x = x + cellDimensions)
            {
                for (int y = 0; y < populationArea; y = y + cellDimensions)
                {
                    cells.Add(x + ", " + y, 0);
                }
            }
        }

        static public void CreateInitialState(Graphics liveCellInitial)
        {
            CreateCellBodies();

            Random randomNumber = new Random();

            //int liveCells = randomNumber.Next(1, populationArea / cellDimensions);
            int liveCells = 100;

            for (int numberOfCells = 0; numberOfCells < liveCells; numberOfCells++)
            {
                int x = randomNumber.Next(0, populationArea / cellDimensions) * cellDimensions;
                int y = randomNumber.Next(0, populationArea / cellDimensions) * cellDimensions;

                CellCreator(liveCellInitial, x, y);
            }
        }

        static public void CycleState(Graphics populateCells)
        {
            //Go through all cells on board, alive or dead.
            for (int x = 0; x < populationArea; x = x + 10)
            {
                for (int y = 0; y < populationArea; y = y + 10)
                {

                    int[] coord = { x, y };
                    String cellCoord = x + ", " + y;

                    int neighbors = NumberOfNeighbors(coord);

                    //If the cell is alive.
                    if ((int)cells[cellCoord] == 1)
                    {
                        //Condition One: If the cell has less than two neighbors, the cell dies.
                        if (neighbors < 2)
                        {
                            CellKiller(populateCells, x, y);
                        }
                        //Condition Two: If the cell has more than three neighbors, the cell dies.
                        if (neighbors > 3)
                        {
                            CellKiller(populateCells, x, y);
                        }
                    }

                    //If the cell is dead.
                    if ((int)cells[cellCoord] == 0)
                    {
                        //Condition Three: If a dead cell has three neighbors, it comes to life.
                        if (neighbors == 3)
                        {
                            PopulateCell(populateCells, x, y);
                        }
                    }                    
                }
            }

        }

        static private void CellCreator(Graphics liveCellInitial, int x, int y)
        {
            PopulateCell(liveCellInitial, x, y);

            int currCell = (int)cells[x + ", " + y];

            if (currCell == 1)
            {
                BoardDesign.DrawSection(Color.Green, liveCellInitial, x, y);
            }
        }

        static private void CellKiller(Graphics killZone, int x, int y)
        {
            cells[x + ", " + y] = 0;

            BoardDesign.DrawSection(Color.Red, killZone, x, y);

        }

        static public void PopulateCell(Graphics liveZone, int x, int y)
        {

            cells[x + ", " + y] = 1;
            BoardDesign.DrawSection(Color.Red, liveZone, x, y);


        }

        static private int NumberOfNeighbors(int[] coord)
        {
            int neighborCount = 0;
        
            for(int neighborX = -1; neighborX < 2; neighborX++)
            {
                for(int neighborY = -1; neighborY < 2; neighborY++)
                {
                    if(neighborX != 0 && neighborY != 0)
                    {
                        int currentNeighborX = (neighborX * 10) + coord[0];
                        int currentNeighborY = (neighborY * 10) + coord[1];

                        if(currentNeighborX > -1 && currentNeighborX < populationArea &&
                            currentNeighborY > -1 && currentNeighborY < populationArea)
                        {
                            String currentNeighbor = currentNeighborX + ", " + currentNeighborY;
                            if ((int)cells[currentNeighbor] == 1)
                            {
                                neighborCount++;
                            }
                        }
                    }
                }
            }
            
            return neighborCount;
        }
    }
}
