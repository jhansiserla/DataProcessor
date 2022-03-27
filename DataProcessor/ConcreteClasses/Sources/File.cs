using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Enumerations;

namespace DataProcessor
{
    /// <summary>
    /// Class to process data with File as source 
    /// </summary>
    public class File : ISource
    {
        public File()
        {
            path = @"C:/Test/Sample.xml";
        }
        /// <summary>
        /// Property which stores path of File
        /// </summary>
        public string path { get; set; }



    }
}
