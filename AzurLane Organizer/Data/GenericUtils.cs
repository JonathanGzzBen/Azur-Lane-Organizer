using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Threading;

using System.Runtime.Serialization.Formatters.Binary;

namespace AzurLane_Organizer.Data
{
    public static class GenericUtils
    {
        /// <summary>
        /// Writes the given object instance to a binary file.
        /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
        /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the binary file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the binary file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite)
        {
            //Must work on finding a better solution.
            //If the file doesn't exist, File.Open always throws exception.
            const int maxNumberOfRetries = 50;
            const int delayOnRetry = 500;
            for(int i = 0; i < maxNumberOfRetries; i++)
            {
                try
                {
                    using (Stream stream = File.Open(filePath, FileMode.Create))
                    {
                        var binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(stream, objectToWrite);
                        break;
                    }
                }
                catch
                {
                    Thread.Sleep(delayOnRetry);
                }
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the binary file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var binaryFormatter = new BinaryFormatter();
                if(stream.Length != 0)
                    return (T)binaryFormatter.Deserialize(stream);

                return default(T);
            }
        }
    }
    
}
