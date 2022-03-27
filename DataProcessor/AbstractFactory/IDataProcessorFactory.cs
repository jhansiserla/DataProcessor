using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Interface which represent the data process from any soruce to any datatype processing
    /// </summary>
    public interface IDataProcessorFactory
    {
        /// <summary>
        /// Interface which represent the source for data processing
        /// </summary>
        /// <returns></returns>
        ISource Source();

        /// <summary>
        /// Interface which represent the type of data processing
        /// </summary>
        /// <returns></returns>
        IDataTypeProcess DataTypeProcess();
    }
}
