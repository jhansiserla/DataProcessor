using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Enumerations;

namespace DataProcessor
{
    /// <summary>
    /// Class which performs text processing in reverse order
    /// </summary>
    public class TextReverseProcess : IDataTypeProcess
    {
        /// <summary>
        /// Method to process data in text format in reverse order
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string ProcessData(string path)
        {
            string text  = string.Empty;
            try
            {
                text = System.IO.File.ReadAllText(path, Encoding.UTF8);
                if (!string.IsNullOrEmpty(text))
                {
                    text = text.Substring(0, 6);
                    text = text.Reverse().ToString();
                }
            }
            catch (Exception ex) { throw; }
            return text;
        }
    }
}
