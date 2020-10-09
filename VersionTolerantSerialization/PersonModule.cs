using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace VersionTolerantSerialization
{
    [Serializable]
    abstract class PersonModule
    {
        private string firstName;
        private string lastName;
        private int age;
        private string country;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Country 
        { 
            get
            {
                return country;
            }
            set
            {
                this.country = value;
            }
        }

        public void Clear()
        {
            this.age = 0;
            this.firstName = "";
            this.lastName = "";
        }
    }
}
