using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiApplication.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        static double DEFAULT_HEIGHT = 5.0;

        static double DEFAULT_WEIGHT = 50.0;

        public Person(int id , string name , int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = DEFAULT_HEIGHT;
            Weight = DEFAULT_WEIGHT;
        }

        public Person(int id, string name, int age, double height, double weight) 
            :this(id,name,age)
            
        {
            Height = height;
            Weight = weight;
            
        }

        public double BmiCalculation()
        {
            return Weight / (Height*Height);
        }

        public override string ToString()
        {
            return $"Person Id : {Id}\n" +
                $"Person Name : {Name}\n" +
                $"Person Height : {Height}\n" +
                $"Person Weight : {Weight}\n";
        }


    }
}
