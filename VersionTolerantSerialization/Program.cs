using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace VersionTolerantSerialization
{

    class Program
    {
        /// <summary>
        /// When We execute the code below, it creates an instance of our Person class, 
        /// sets the Firstname and Lastname properties, saves it to a file, and then reads it 
        /// back in and displays it. It's a Simple example that demonstrates serialization and 
        /// deserialization and creates a binary data file.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"D:\\SerializedData.bin";
            VersionA.Person person = new VersionA.Person();
            person.FirstName = "Ramesh";
            person.LastName = "Verma";

            Serializer.Serialize(person, path);
            person.Clear();

            VersionA.Person person1 = new VersionA.Person();
            person1 = (VersionA.Person)Deserializer.DeSerialize(path);
            Console.WriteLine("First Name {0} \nlast name is {1} \n", person1.FirstName, person1.LastName);

            Console.ReadKey();
        }
    }
}
