using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using VersionA;

namespace VersionTolerantSerialization
{

    class Program
    {
        /// <summary>
        /// Method calls to show the implementation of Version tolerant Serialization
        /// and Serialization Callbacks
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"D:\\SerializedData.bin";
            
            //CASE 1 : Creating an instance of Version2 person and setting the values of version1
            //properties i.e FirstName and LastName
            //While the newely added property in Version2 i.e age is set by callback method
            VersionB.Person person = new VersionB.Person();
            person.FirstName = "Sumekh";
            person.LastName = "Verma";
            
            Serializer.Serialize(person, path);

            VersionB.Person person1 = new VersionB.Person();
            person1 = (VersionB.Person)Deserializer.DeSerialize(path);
            Console.WriteLine("\t\tFor CASE 1: \nFirst Name is {0} \nlast name is {1} \n" +
                "and Age is {2}", person1.FirstName, person1.LastName, person1.Age);


            string path2 = @"D:\\SerializedDatatwo.bin";
            //CASE 2 : Creating an instance of Version3 person and setting the values of version2
            //properties i.e FirstName, LastName and age
            //While the newely added property in version3 i.e Country is set by callback method
            VersionC.Person person2 = new VersionC.Person();
            person2.FirstName = "Aman";
            person2.LastName = "Sharma";
            person2.Age = 25;

            Serializer.Serialize(person2, path2);

            VersionC.Person person3 = new VersionC.Person();
            person3 = (VersionC.Person)Deserializer.DeSerialize(path2);
            Console.WriteLine("\n \n\t\tFor CASE 2: \nFirst Name is {0} \nlast name is {1}" +
                " \nAge is {2} \nCountry is {3} ", person3.FirstName, person3.LastName, 
                person3.Age, person3.Country);


            Console.ReadKey();
        }
    }
}
