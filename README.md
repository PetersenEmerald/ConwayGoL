# ConwayGoL
Conway's Game of Life

Conway's Game of Life is a zero player mathematical modeling of population growth. This coded iteration of the game is modeled after John Horton Conway's rules.

The user starts the game by clicking Start. Cells are randomly populated in the graph.

The user continues the game by clicking Cycle. Cells are then put through the following rules to determine their next state:
  - Cells that are currently alive with 2 or 3 neighbors do not have a state change.
  - Cells that are currently dead with 3 neighbors have their state changed to alive.
  - Cells that are currently alive with less than 2 neighbors die of solutide.
  - Cells that are currently alive with more than 3 neighbors die of overpopulation.
  
 Cell Colour Key:
  - Cells that are green are in a live state.
  - Cells that are red are in a dead state.
  - Cells that are neither colour have never been used in the current game.
  
 The game was designed using C# with Windows Forms in Visual Studio 2017. The goal of the game was to demonstrate basic coding competence by using:
  - Object Oriented Programing Principles
  - Hashtable for Cell Data
  - Agile Practices with a Project Board
  - Tools in Windows Forms
