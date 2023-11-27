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
    class ProjectLib
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

        public static Dictionary<string, double> GetGini(DataTable table)
        {
            List<string> classes = new List<string>();
            Dictionary<string, double> giniRes = new Dictionary<string, double>();

            foreach (DataRow row in table.Rows)
            {
                if (!classes.Contains(row[row.ItemArray.Length - 1])) classes.Add((string)row[row.ItemArray.Length - 1]);
            }
            int last = table.Columns.Count - 1;
            for (int i = 0; i < table.Columns.Count - 1; i++)
            {
                List<string> val = new List<string>();
                double res=0;
                foreach (DataRow row in table.Rows)
                {
                    if (!val.Contains(row[i])) val.Add(row[i].ToString());
                }

                foreach (string v in val)
                {
                    double MA = 0;
                    double gini = 1;
                    double prob = 0;
                    int count = 0;
                    int total = 0;
                    foreach (string c in classes)
                    {
                        count = 0;
                        total = 0;
                        foreach (DataRow row in table.Rows)
                        {
                            if (v == (string)row[i] && c == (string)row[last])
                                count++;
                            total++;
                        }
                        prob = count / total;
                        gini -= Math.Pow(prob, 2);
                    }
                    

                }

                giniRes.Add(table.Columns[i].ColumnName, res);
            }

        

            return giniRes;
        }

        public static double CalculateBestSplit(DataTable table, out string name)
        {
            Dictionary<string, double> GiniComparison = GetGini(table);
            /*for (int i = 0; i<table.Columns.Count; i++)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(table.Columns[i]);
                dt.Columns.Add(table.Columns[table.Columns.Count - 1]);
                GiniComparison.Add(table.Columns[i].ColumnName, GetGini(dt));
            }*/
            double res = 0;
            name = "";
            return res;
        }
    }
}
