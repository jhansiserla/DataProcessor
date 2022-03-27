using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Class which provides details of data class
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Property which holds source of data
        /// </summary>
        public string? Source{ get; set; }

        /// <summary>
        /// Property which holds data type process of data
        /// </summary>
        public string? DataTypeProcess { get; set; }
    }
}
