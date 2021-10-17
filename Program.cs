using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person
    {
        public string name = "Gintoki";
        public string username = "Sakato";
        public int age = 29;
        public double height = 175.4;
        public string activity = "Handyman" ;
        public string properties = "Always lazy";
       
        public string GetContent() => 
            $"Имя: {name} \n " +
            $"Фамилия: {username}\n " +
            $"Возраст: {age} \n" +
            $"Рост: {height} \n" +
            $"Деятельность: {activity} \n" +
            $"Свойства: {properties} \n" +
    }

}
