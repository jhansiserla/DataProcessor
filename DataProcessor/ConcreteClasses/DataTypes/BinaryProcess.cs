using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Enumerations;
using System.IO;

namespace DataProcessor
{
    /// <summary>
    /// Class to performs binary processing
    /// </summary>
    public class BinaryProcess : IDataTypeProcess
    {
        /// <summary>
        /// Method which performa binary processing of data based on provided path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string ProcessData(string path)
        {
            string base64String = string.Empty;
            try
            {
                byte[] byteArray = System.IO.File.ReadAllBytes(path);
                if (byteArray != null && byteArray.Any())
                {
                    byteArray = byteArray.Take(5).ToArray();
                    base64String = Convert.ToBase64String(byteArray);
                }
                return base64String;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
