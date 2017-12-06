using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BSimplifier
{
    class FileUtils
    {
        public System.Data.DataTable FetchData(string filepath, string delimiter)
        {
            bool IsFirstRowHeader = true;
            string[] columnf = new string[] { "" };
            System.Data.DataTable dt = new System.Data.DataTable();
            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(filepath))
            {
                parser.TrimWhiteSpace = true;
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(delimiter);
                if (IsFirstRowHeader)
                {

                    columnf = parser.ReadFields();
                    foreach (string sds in columnf)
                    {
                        dt.Columns.Add(new DataColumn(sds.Trim().ToLower(), Type.GetType("System.String")));
                    }

                }
                while (true)
                {
                    if (IsFirstRowHeader == false)
                    {
                        string[] parts = parser.ReadFields();
                        if (parts == null)
                        {
                            break;
                        }
                        dt.Rows.Add(parts);
                    }
                    IsFirstRowHeader = false;
                }
            }
            return dt;
        }
    }
}
