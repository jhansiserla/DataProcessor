using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Class Factory for binary data processing with source as file
    /// </summary>
    public class BinaryProcessorForFileFactory: IDataProcessorFactory
    {

        /// <summary>
        /// Method to fetch File instance
        /// </summary>
        /// <returns></returns>
        public ISource Source()
        {
            return new File();
        }

        /// <summary>
        /// Method to fetch Binary processing instance
        /// </summary>
        /// <returns></returns>
        public virtual  IDataTypeProcess DataTypeProcess()
        { 
         return new BinaryProcess();
        }
    }
}
