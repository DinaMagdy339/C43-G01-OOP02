using assign02oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assign02oop
{
    internal struct Person
    {
        #region Attributes 
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

       

    }
}

    



    
