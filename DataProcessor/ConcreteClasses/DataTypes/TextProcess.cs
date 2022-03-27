using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Enumerations;

namespace DataProcessor
{
    /// <summary>
    /// Class which performs text type processing
    /// </summary>
    public class TextProcess : IDataTypeProcess
    {
        /// <summary>
        /// Method to process the data in text format for provided path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string ProcessData(string path)
        {
            string text = System.IO.File.ReadAllText(path, Encoding.UTF8);
            if (!string.IsNullOrEmpty(text))
            { 
            text = text.Substring(0,7);
            }
            return text;
        }
    }
}
