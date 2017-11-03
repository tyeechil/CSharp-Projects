using System.Text;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace QALab3
{
    public class CSVReader
    {
        //Nothing here is needed for what's showing on the live version, this is Adam testing something...to be continued
        public static string csvPath = @"C:\users\tyeechil\dropbox\QALab3\QALab3\matchbox20.csv";
        //JSON data gathered from the csv file from convertCSV
        public string csvData;

        public CSVReader()
        {
            DataTable dt = convertCSV(csvPath);  
            int count = dt.Rows.Count;
            csvData = JsonConvert.SerializeObject(dt, Formatting.Indented);
            csvData = "{\"draw\":2,\"data\":" + csvData + "}";
        }

        public static DataTable convertCSV(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = sr.ReadLine().Split(',');
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }

            return dt;
        } 

    }   
}