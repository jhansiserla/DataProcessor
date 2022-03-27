using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Enumerations;

namespace DataProcessor
{
    /// <summary>
    /// Class which manages to create instance of data processing factory with input data
    /// </summary>
    public class DataProcessorManagingFactory
    { 
        /// <summary>
        /// Method returns dataprocessor factory based on data input
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IDataProcessorFactory GetDataProcessingFactory(Data data)
        {         
            try
            {
                if (data.Source == SourceTypes.SourceType.File.ToString())
                {
                    if (data.DataTypeProcess == DataProcessingTypes.DataType.Binary.ToString())
                    {
                        return new BinaryProcessorForFileFactory();
                    }
                    else if (data.DataTypeProcess == DataProcessingTypes.DataType.Text.ToString())
                    {
                        return  new TextProcessorForFileFactory();
                    }
                    else if (data.DataTypeProcess == DataProcessingTypes.DataType.TextReverse.ToString())
                    {
                        return  new TextReverseProcessorForFileFactory();
                    }

                }
            }

            catch (Exception ex)
            {
                throw;
            }
            return null;
            
        }

    }
}
