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
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"D:\\SerializedData.bin";
            PersonModule person = new VersionA.Person();
            person.FirstName = "Sumekh";
            person.LastName = "Verma";
            

            VersionA.Person person2 = new VersionA.Person();

            

            Serializer.Serialize(person, path);
            person.Clear();

            
            PersonModule person1 = new VersionB.Person();
            person1 = (PersonModule)Deserializer.DeSerialize(path);
            Console.WriteLine("First Name {0} \nlast name is {1} \n and Age is {2}", person1.FirstName, person1.LastName, person1.Age);

            Console.ReadKey();
        }
    }
}
