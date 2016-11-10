using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MovieCollectionMH.backend
{
    class ExcelHandler
    {
        public void ExportExcel(backend.MovieList List,string savetoFilename)
        {

            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

            xla.Visible = true;

            xla.Workbooks.Add();

            Worksheet worksheet = (Worksheet)xla.ActiveSheet;

            worksheet.Cells[1, "A"] = "Movie";
            worksheet.Cells[1, "B"] = "Lenght";
            worksheet.Cells[1, "C"] = "Format";

            var row = 1;
            foreach (var m in List.ListOfMovies)
            {
                row++;
                worksheet.Cells[row, "A"] = m.Movie;
                worksheet.Cells[row, "B"] = m.Length;
                worksheet.Cells[row, "C"] = m.Format;
            }

            worksheet.Columns[1].AutoFit();
            worksheet.Columns[2].AutoFit();
            worksheet.Columns[3].AutoFit();

            worksheet.SaveAs(savetoFilename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

        }

        public List<Movies> ImpExcel(string filename)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = false; // dont want to see it 

            Workbook Wb = xla.Workbooks.Open(filename);

            Worksheet ws = Wb.Worksheets[1];   // worksheet one.

            int numberOfRows = GetNumberOfRows(ws);

            List<Movies> temp = new List<Movies>();


            for (int r = 2; r <= numberOfRows; r++)
            {
                Movies mov =new Movies();

                mov.Movie = ws.Cells[r, 1].Value;
                mov.Length = ws.Cells[r, 2].Value;
                mov.Format = ws.Cells[r, 3].Value;
                temp.Add(mov);
            }


            xla.Quit();
            xla = null;
            return temp;

        }


        /// <summary>
        /// Gets the number of rows by searching the first null row
        /// </summary>
        /// <param name="ws">worksheet to search</param>
        /// <returns>number of rows</returns>
        /// <remarks>there probably is a better way to do this</remarks>
        private int GetNumberOfRows(Microsoft.Office.Interop.Excel.Worksheet ws)
        {
            int numberOfRows = 1;
            while (ws.Cells[1, numberOfRows].Value != null)
            {
                numberOfRows += 1;
            }
            numberOfRows -= 1; // substract 1 to get the last filled column

            return numberOfRows;
        }



    }
}
