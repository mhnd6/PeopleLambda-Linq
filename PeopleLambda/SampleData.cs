using PeopleLambda.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLambda
{
    public class SampleData
    {
        public static List<PersonModel> GetPeopleData()
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Mohanned", LastName = "Akbar", Email = "mrmohandtv@gmail.com"},
                new PersonModel{FirstName = "Amjad", LastName = "Bukhari", Email = "amj@gmail.com"},
                new PersonModel{FirstName = "Odi", LastName = "Algamdi", Email = "odi@gmail.com"},
                new PersonModel{FirstName = "Loay", LastName = "Algamdi", Email = "loay@gmail.com"},
                new PersonModel{FirstName = "Yehya", LastName = "Asfor", Email = "yehya@gmail.com"}
            };

            return people;
        }
    }
}
