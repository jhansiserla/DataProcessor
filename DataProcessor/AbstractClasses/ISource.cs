using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    /// <summary>
    /// Interface to represent source of data processing
    /// </summary>
    public interface ISource
    {
        /// <summary>
        /// Property which stores information of path of source
        /// </summary>
        string path { get; set; }
    }
}
