using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using excel = Microsoft.Office.Interop.Excel;

namespace TestAutomation
{
    class ExcelLibrary
    {
        public static DataTable ExcelToDataTable(string fileName)
        {//open file and returns as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Create openxml reader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //Set the First Row as Column Name and Return as DataSet
            var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            //Get all the Tables
            DataTableCollection table = result.Tables;
            //Store it in DataTable
            DataTable resultTable = table["Sheet1"];
            //return
            return resultTable;
        }

        static List<Datacollection> dataCollection = new List<Datacollection>();
        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for(int row = 1; row <= table.Rows.Count; row++)
            {
                for(int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCollection.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {//Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCollection
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public static string excelread(int x, int y)
        {
            excel.Application xapp = new excel.Application();
            excel.Workbook xworkbook = xapp.Workbooks.Open("D:\\Book1.xls");
            excel.Worksheet xsheet = xworkbook.Worksheets[1];
            excel.Range xrange = xsheet.UsedRange;
            return xrange.Cells[x][y].value;
        }
    }
    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
    
}
