using System;


namespace Persona
{
    public class Person
    {

        private string surname;
        private string name;
        private string fatherName;
        private int age;
        private string eyesColor;

        public Person(string surname, string name, string fatherName, int age, string eyesColor)
        {
            this.surname = surname;
            this.name = name;
            this.fatherName = fatherName;
            this.age = age;
            this.eyesColor = eyesColor;
            

        }

        public void goInSchool()
        {
            Console.WriteLine("I go to school");
        }
        public void eatBreakfast()
        {
            Console.WriteLine("I eat breakfast");
        }
        public override string ToString()
        {
            return ("My Surname:" + surname + 
                "\nMy Name:" + name + 
                "\nMy Father Name:" + fatherName + 
                ",\nMy age" + age + "years old,"
                + "\nMy eyes, " + eyesColor);
        }
    }
}



