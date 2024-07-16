using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmiApplication.Models;

namespace BmiApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"Max",19,1.81,65);
            Person person2 = new Person(2, "John", 22, 0.78, 45.7);
            Console.WriteLine("===========Person 1 =========");
            Console.WriteLine(person1);
            Console.WriteLine("===========Person 2 =========");
            Console.WriteLine(person2);

            Console.WriteLine($"{person1.Name}'s bmi index is {person1.BmiCalculation()} kg/m2");
            BodyType(person1);
            Console.WriteLine($"{person2.Name}'s bmi index is {person2.BmiCalculation()} kg/m2");
            BodyType(person2);



        }

        static void BodyType(Person person)
        {
            double bmi = person.BmiCalculation();
            if (bmi < 16.0)
                Console.WriteLine($"{person.Name} is underweight (Severe Thinnness)\n");
            else if (bmi > 16.0 && bmi < 16.9)
                Console.WriteLine($"{person.Name} is underweight (Moderate Thinness)\n");
            else if (bmi > 17.0 && bmi < 18.4)
                Console.WriteLine($"{person.Name} is underweight (Mild Thinness)\n");
            else if (bmi > 18.5 && bmi < 24.9)
                Console.WriteLine($"{person.Name} is in Normal Weight Range\n");
            else if (bmi > 25.0 && bmi < 29.9)
                Console.WriteLine($"{person.Name} is Overweight (Pre-obese)\n");
            else if (bmi > 30.0 && bmi < 34.9)
                Console.WriteLine($"{person.Name} is Obese (Class 1)\n");
            else if (bmi > 35.0 && bmi < 39.9)
                Console.WriteLine($"{person.Name} is Obese (Class 2)\n");
            else
                Console.WriteLine($"{person.Name} is Obese (Class 3)\n");
        }
    }
}
