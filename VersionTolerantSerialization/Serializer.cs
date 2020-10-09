using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VersionTolerantSerialization
{
    /// <summary>
    /// Helper class to perform Serialization
    /// </summary>
    class Serializer
    {
        /// <summary>
        /// Serializes the object and stores the state at the location required
        /// </summary>
        /// <param name="obj">Object to be serialized</param>
        public static void Serialize(object obj, string path)
        {
            using (FileStream fileStream
                = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                
                binaryFormatter.Serialize(fileStream, obj);
            }
        }
    }
}
