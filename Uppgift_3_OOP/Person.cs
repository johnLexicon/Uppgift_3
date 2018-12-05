using System;
namespace Uppgift_3_OOP
{
    class Person
    {

        #region Fields
        private int age;
        private string fname;
        private string lname;
        private int height;
        private float weight;
        #endregion

        #region Properties
        public int Age { get => age; set => age = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public int Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }
        #endregion
        
    }
}
