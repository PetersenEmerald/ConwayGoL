﻿using System;
using System.Linq;
using System.Drawing;
using System.Configuration;
using System.Collections.Generic;

namespace ConwayGoL
{
    class LiveCells
    {
        static CellTable cellTable = new CellTable();

        static readonly int populationArea = Convert.ToInt32(ConfigurationManager.AppSettings["populationArea"]);
        static readonly int cellDimensions = Convert.ToInt32(ConfigurationManager.AppSettings["cellDimensions"]);

        //Initializes the data for all initial cells, alive or dead.
        static public void CreateCellBodies()
        {
            for (int x = 0; x < populationArea; x = x + cellDimensions)
            {
                for (int y = 0; y < populationArea; y = y + cellDimensions)
                {
                    int cellKey = Convert.ToInt32(string.Format("{0}{1}", x, y));
                    cellTable.Add(cellKey, 0);
                }
            }
        }

        static public void CreateInitialState(Graphics liveCellInitial)
        {
            CreateCellBodies();

            Random randomNumber = new Random();

            int liveCells = 100;

            for (int numberOfCells = 0; numberOfCells < liveCells; numberOfCells++)
            {
                int x = randomNumber.Next(0, populationArea / cellDimensions) * cellDimensions;
                int y = randomNumber.Next(0, populationArea / cellDimensions) * cellDimensions;
                int cellKey = Convert.ToInt32(string.Format("{0}{1}", x, y));

                CellCreator(liveCellInitial, cellKey, x, y);
            }
        }

        //Gather information required to determine next cycle state of all cells.
        static public void CycleState(Graphics populateCells)
        {
            List<int[,]> liveCells = new List<int[,]>();
            List<int[,]> deadCells = new List<int[,]>();

            //Go through all cells on board, alive or dead.
            for (int x = 0; x < populationArea; x = x + cellDimensions)
            {
                for (int y = 0; y < populationArea; y = y + cellDimensions)
                {
                    int[,] coord = new int[,] { { x, y } };
                    int cellKey = Convert.ToInt32(string.Format("{0}{1}", x, y));

                    int neighbors = NumberOfNeighbors(x, y);

                    //If the cell is alive.
                    if (cellTable[cellKey] == 1)
                    {
                        //Condition One: If the cell has less than two neighbors, the cell dies.
                        if (neighbors < 2)
                        {
                            deadCells.Add(coord);
                        }
                        //Condition Two: If the cell has more than three neighbors, the cell dies.
                        if (neighbors > 3)
                        {
                            deadCells.Add(coord);
                        }
                    }

                    //If the cell is dead and Condition Three: If a dead cell has three neighbors, it comes to life.
                    if (cellTable[cellKey] == 0 && neighbors == 3)
                    {
                            liveCells.Add(coord);                   
                    }                    
                }
            }

            //Kills cells that did not meet rules to remain alive.
            for (int numDead = 0; numDead < deadCells.Count; numDead++)
            {
                int[,] currCell = deadCells.ElementAt(numDead);
                int x = currCell[0, 0];
                int y = currCell[0, 1];
                int cellKey = Convert.ToInt32(string.Format("{0}{1}", x, y));

                CellKiller(populateCells, cellKey, x, y);
            }

            //Adds cells that have three neighbors.
            for (int numLive = 0; numLive < liveCells.Count; numLive++)
            {
                int[,] currCell = liveCells.ElementAt(numLive);
                int x = currCell[0, 0];
                int y = currCell[0, 1];
                int cellKey = Convert.ToInt32(string.Format("{0}{1}", x, y));

                PopulateCell(populateCells, cellKey, x, y);
            }

        }

        static private void CellCreator(Graphics liveCellInitial, int cellKey, int x, int y)
        {
            PopulateCell(liveCellInitial, cellKey, x, y);

            if (cellTable[cellKey] == 1)
            {
                BoardDesign.DrawSection(Color.Green, liveCellInitial, x, y);
            }
        }

        static private void CellKiller(Graphics killZone, int cellKey, int x, int y)
        {
            cellTable[cellKey] = 0;

            BoardDesign.DrawSection(Color.Red, killZone, x, y);

        }

        static public void PopulateCell(Graphics liveZone, int cellKey, int x, int y)
        {

            cellTable[cellKey] = 1;
            BoardDesign.DrawSection(Color.Green, liveZone, x, y);
        }

        static private int NumberOfNeighbors(int x, int y)
        {
            int neighborCount = 0;
        
            //A cell will have eight potential neighbors. Neighbors are represented in their location mathematically compared to the current cell.
            for(int neighborX = -1; neighborX < 2; neighborX++)
            {
                for(int neighborY = -1; neighborY < 2; neighborY++)
                {

                    //Not including the current cell.
                    if(!(neighborX == 0 && neighborY == 0))
                    {
                        int currentNeighborX = (neighborX * cellDimensions) + x;
                        int currentNeighborY = (neighborY * cellDimensions) + y;

                        //Neighbor is within the boundaries of the population.
                        if (currentNeighborX > -1 && currentNeighborX < populationArea &&
                            currentNeighborY > -1 && currentNeighborY < populationArea)
                        {
                            int neighborCellKey = Convert.ToInt32(string.Format("{0}{1}", currentNeighborX, currentNeighborY));

                            if (cellTable[neighborCellKey] == 1)
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
