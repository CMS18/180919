using System;

namespace SudokuSolver
{
    internal class Sudoku
    {
        private int[,] cells = new int[9, 9];

        public Sudoku(string board)
        {
            int position = 0;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int number = int.Parse(board[position].ToString());
                    SetCellValue(row, col, number);
                    position++;
                }
            }
        }

        private int GetCellValue(int row, int column)
        {
            throw new NotImplementedException();
        }

        private void SetCellValue(int row, int column, int value)
        {
            cells[row, column] = value; 
        }

        private bool CellIsEmpty(int row, int column)
        {
            // Hämta värde på cell i rad och kolumn
            // Om (cell == 0) så är den tom

            throw new NotImplementedException();
        }

        private int[] GetNumbersInRow(int row)
        {
            // Hämta siffrorna i en rad

            throw new NotImplementedException();
        }

        private int[] GetNumbersInColumn(int column)
        {
            // Hämta siffrorna i en rad

            throw new NotImplementedException();
        }

        private int[] GetNumbersInBlock(int row, int column)
        {
            // Beräkna vilket block
            // Hämta siffrorna i blocket rad för rad

            throw new NotImplementedException();
        }

        private int[] FindPossibleNumbers()
        {
            // Hitta möjliga tal för cell utifrån rad, kolumn och block

            throw new NotImplementedException();
        }
        private bool IsComplete()
        {
            // Loopa igenom alla celler
            //   Om (cell är tom) inte färdig

            throw new NotImplementedException();
        }

        public void Solve()
        {
            // Loopa tills färdig (dvs inga tomma rutor)
            //   Loopa igenom alla celler (for-loop nestade rad och kolumn)
            //     Om (cell är tom) 
            //       Hitta möjliga tal för cell utifrån rad, kolumn och block
            //       Om (noll alternativ för cellen) finns ingen lösning - avbryta
            //       Om (ett alternativ för cellen) skriv in tal i cell
            //       Om (flera alternativ för cellen) gå vidare

            throw new NotImplementedException();
        }
    }
}