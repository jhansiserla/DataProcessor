using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Interface to represent types of processing a data
    /// </summary>
    public interface IDataTypeProcess
    {
        /// <summary>
        /// Method to process Data from provided path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string ProcessData(string path);
    }
}
