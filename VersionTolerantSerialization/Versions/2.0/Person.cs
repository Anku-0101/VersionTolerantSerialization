using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using VersionTolerantSerialization;

namespace VersionB
{
    [Serializable]
    class Person : PersonModule
    {
        //Version 1.0
        //private string firstName;
        //private string lastName;
        
        
        //private int age;

        public new string FirstName 
        { 
            get {return this.firstName; }
            set { this.firstName = value; }
        }

        public new string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        
        public new int Age 
        {
            get { return this.age; } 
            set { this.age = value; }
        }

        public new void  Clear()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
        }
    }

}
