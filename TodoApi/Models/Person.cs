using System;
namespace TodoApi.Models
{
    public class Person
    {
        public string firstName, lastName;
        public int age;
        public DateTime birthDate;

        public Person()
        {
        }

        public Person(string firstName, string lastName, int age, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.birthDate = birthDate;
        }


    }
}
