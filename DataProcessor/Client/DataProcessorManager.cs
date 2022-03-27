using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Class which performs actual data processing based on dataprocessfactory 
    /// </summary>
    public class DataProcessorManager
    {
        /// <summary>
        /// Variable to store the dataprocessorfactory
        /// </summary>
        IDataProcessorFactory _iDataProcessorFactory;

        /// <summary>
        /// Constructor which assigns passed dataprocessorfactory to variable
        /// </summary>
        /// <param name="iDataProcessorFactory"></param>
        public DataProcessorManager(IDataProcessorFactory iDataProcessorFactory)
        {
            _iDataProcessorFactory = iDataProcessorFactory;
        }

        /// <summary>
        /// Method which performs actual processing of data based on dataprocessorfactory
        /// </summary>
        /// <returns></returns>
        public object ProcessData()
        {
            ISource source = _iDataProcessorFactory.Source();
            IDataTypeProcess dataType = _iDataProcessorFactory.DataTypeProcess();
            object? processedData = null;
            string path = source.path;
            if (!string.IsNullOrEmpty(path))
            {
                processedData =  dataType.ProcessData(path);
            }
            return processedData;
        }
    }
}
