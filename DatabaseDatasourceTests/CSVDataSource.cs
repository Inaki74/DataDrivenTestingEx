using System;
using System.Globalization;
using System.Reflection;
using Microsoft.VisualBasic.FileIO;

namespace CSVDatasourceTests
{
	public class CSVDataSource : Attribute, ITestDataSource
	{
        private string _csvLocation;

        public CSVDataSource(string str)
        {
            _csvLocation = str;
        }

        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            using (TextFieldParser parser = new TextFieldParser(_csvLocation))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                bool firstRun = true;
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();

                    if (!firstRun)
                    {
                        int intField1 = Convert.ToInt32(fields[0]);
                        int intField2 = Convert.ToInt32(fields[1]);
                        int intField3 = Convert.ToInt32(fields[2]);

                        yield return new object[] { intField1, intField2, intField3 };
                    }

                    firstRun = false;
                }
            }
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
            {
                return String.Format(CultureInfo.CurrentCulture, "{0} - first number: {1}, second number: {2}", methodInfo.Name, data[0], data[1]);
            }

            return null;
        }
    }
}

