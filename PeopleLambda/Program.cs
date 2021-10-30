using System;
using System.Linq;

namespace PeopleLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //LambdaTest();
            LinqTest();
            Console.WriteLine("Done processing");
            Console.ReadLine();
        }

        public static void LinqTest()
        {
            var people = SampleData.GetPeopleData();

            var results = (from p in people orderby p.FirstName
                           where p.LastName.ToLower() == "algamdi" select p);

            foreach (var person in results)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } { person.Email }");
            }
        }

        public static void LambdaTest()
        {
            var people = SampleData.GetPeopleData();

            var results = people.Where(p => p.LastName.ToLower() == "algamdi").OrderBy(p => p.FirstName);

            foreach (var person in results)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } { person.Email }");
            }
        }
    }
}
