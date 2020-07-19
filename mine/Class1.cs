using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace mine
{
    public class Student
    {
        private string id;
        public string Id
        {
            
            set
            {
                id = value;
            }
            get { return id; }
        }

        private string LastName;
        public string LN { set; get; }

        private string FirstName;
        public string FN { set; get; }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value <= 150)
                    age = value;
            }
        }
    }
}
