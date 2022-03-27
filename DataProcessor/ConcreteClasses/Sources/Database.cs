using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Enumerations;

namespace DataProcessor
{
    /// <summary>
    /// Class to process data with database as source
    /// </summary>
    public class Database : ISource
    {
        /// <summary>
        /// Property which stores path of database
        /// </summary>
        public string path { get; set; }

    }
}
