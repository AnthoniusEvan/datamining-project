using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
namespace DataMining_Project_IT_22
{
    class ImportCSV
    {
        public static DataTable NewDataTable(string fileName, string delimiters, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.SetDelimiters(delimiters);

                // Get Some Column Names
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);

                    // Get Remaining Rows
                    while (!parser.EndOfData)
                        result.Rows.Add(parser.ReadFields());
                }
            }

            return result;
        }
    }
}
