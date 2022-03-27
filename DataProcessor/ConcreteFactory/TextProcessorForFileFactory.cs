using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Class Factory for Text data processing with source as file
    /// </summary>
    public class TextProcessorForFileFactory: BinaryProcessorForFileFactory
    {
        /// <summary>
        /// Method to fetch Text processing instance
        /// </summary>
        /// <returns></returns>
        public override IDataTypeProcess DataTypeProcess()
        {
            return new TextProcess();
        }
    }
}
