using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using VersionTolerantSerialization;

namespace VersionC
{
    [Serializable]
    class Person : PersonModule
    {
        //Version 1.0
        private string firstName;
        private string lastName;

        //Version 2.0
        [OptionalField(VersionAdded =2)]
        private int age;

        //Version 3.0
        [OptionalField(VersionAdded =3)]
        private string country;

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

        public new string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }
        public new void Clear()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
            this.country = "";
        }
        
        [OnSerializing]
        private void SetDefaultAgeAndCountry(StreamingContext sc)
        {
            this.Age = -1;
            this.country = "N/A";
        }

    }

}
