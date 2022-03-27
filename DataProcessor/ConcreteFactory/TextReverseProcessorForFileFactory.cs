using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Class Factory for text reverse data processing with source as file
    /// </summary>
    public class TextReverseProcessorForFileFactory : BinaryProcessorForFileFactory
    {
        /// <summary>
        /// Method to fetch Text Reverse processing instance
        /// </summary>
        /// <returns></returns>
        public override IDataTypeProcess DataTypeProcess()
        {
            return new TextReverseProcess();
        }
    }
}
