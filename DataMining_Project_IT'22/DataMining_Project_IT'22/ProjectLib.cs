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
            // Assuming that the classification is on the last column

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
      
                foreach (DataRow row in table.Rows)
                {
                    if (!val.Contains(row[i])) val.Add(row[i].ToString());
                }
                double MA = 0;
                foreach (string v in val)
                {
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
                            if (v == (string)row[i]) total++;
                        }
                        prob = (double)count / (double)total;
                        gini -= Math.Pow(prob, 2);
                    }
                    MA += (double)((double)total / (double)table.Rows.Count) * gini;
                }

                giniRes.Add(table.Columns[i].ColumnName, MA);
            }

            return giniRes;
        }

        public static double CalculateBestSplit(DataTable table, out string name, out double gain)
        {
            Dictionary<string, double> GiniComparison = GetGini(table);
            double compareNum=0;
            string bestName="";
            foreach (KeyValuePair<string, double> kvp in GiniComparison)
            {
                if (kvp.Value != 0)
                {
                    compareNum = kvp.Value;
                    bestName = kvp.Key;
                    break;
                }
            }
            
            foreach (KeyValuePair<string, double> kvp in GiniComparison)
            {
                if (compareNum > kvp.Value && kvp.Value != 0)
                {
                    compareNum = kvp.Value;
                    bestName = kvp.Key;
                }
            }
            double res = compareNum;
            name = bestName;
            List<string> classes = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                if (!classes.Contains(row[row.ItemArray.Length - 1])) classes.Add((string)row[row.ItemArray.Length - 1]);
            }
            gain = (1 - (double)(1 / (double)classes.Count)) - res;
            return res;
        }

        private static double CalculateDistance(List<double> p1, List<double> p2, int type)
        {
            double res = 0;
            for (int i = 0; i < p1.Count; i++)
            {
                res += Math.Pow(p1[i] - p2[i], type);
            }
            res = Math.Pow(res, (double)(1 / (double)type));
            return res;
        }
        public static double CalculateCityBlockDistance(List<double> p1, List<double> p2)
        {
            return CalculateDistance(p1, p2, 1);
        }
        public static double CalculateEuclideanDistance(List<double> p1, List<double> p2)
        {
            return CalculateDistance(p1, p2, 2);
        }

        public static void ClusterData()
        {

        }
    }
}
