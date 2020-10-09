using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using VersionTolerantSerialization;

namespace VersionA
{
    [Serializable]
    class Person : PersonModule
    {
        string firstName;
        string lastName;

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

        public new void Clear()
        {
            this.firstName = "";
            this.lastName = "";
        }
    }

}
