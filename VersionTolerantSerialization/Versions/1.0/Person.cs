using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace VersionA
{
    [Serializable]
    class Person
    {
        //Version 1.0
        private string firstName;
        private string lastName;

        public string FirstName 
        { 
            get {return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public void Clear()
        {
            this.firstName = "";
            this.lastName = "";
        
        }
    }

}
