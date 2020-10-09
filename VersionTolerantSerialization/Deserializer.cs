using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VersionTolerantSerialization
{
    /// <summary>
    /// Helper class to Deserialize object back to its actual state
    /// </summary>
    class Deserializer
    {
        /// <summary>
        /// Method to deserialize serialized object of class
        /// </summary>
        /// <param name="path">Serialized file path</param>
        /// <returns></returns>
        public static object DeSerialize(string path)
        {
            object obj = null;
            using (FileStream fileStream
                = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                obj = binaryFormatter.Deserialize(fileStream);
            }
            return obj;
        }
    }
}
