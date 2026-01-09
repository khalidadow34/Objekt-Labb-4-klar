using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Objekt_Labb_4.Sprint_1;

namespace Objekt_Labb_4
{
    internal class Sprint_1
    {
        public enum Gender
        {
            Man,
            Kvinna,
            IckeBinar,
            Annan
        }

        public struct Hair
        {
            public double Length { get; set; }
            public string Color { get; set; }
            public string Type { get; set; }

            public override string ToString()
            {
                return $"Length is: {Length}, Hair Color is: {Color}, Hair Type is: {Type}";
            }
        }

        public class Person
        {
            public Gender Gender { get; set; }
            public Hair Hair { get; set; }
            public string EyeColor { get; set; }
            public DateTime BirthDate { get; set; }

            public override string ToString()
            {
                return $"Gender is {Gender}, Hair {Hair}, Eye Color is {EyeColor}, Birth Date is {BirthDate.ToShortDateString()}";

            }
        }

        // sprint 2 efter 

        public static void AddPerson(List<Person> people)
        {

            try
            {
                Console.WriteLine("Fyll in din Gender: ");
                string inputGender = Console.ReadLine();

                Console.WriteLine("Fyll in din Hair length: ");
                double inputhairLength = double.Parse(Console.ReadLine());

                Console.WriteLine("Fyll in din Hair Color: ");
                string inputHairColor = Console.ReadLine();

                Console.WriteLine("Fyll in din Hair Type: ");
                string inputHairType = Console.ReadLine();

                Console.WriteLine("Fyll in din Eye Color: ");
                string inputEyeColor = Console.ReadLine();

                Console.WriteLine("Fyll in din Birth Date (yyyy-mm-dd) : ");
                DateTime inputBirthDate = DateTime.Parse(Console.ReadLine());




                Person newPerson = new Person
                {
                    Gender = Enum.Parse<Gender>(inputGender, true),
                    //Hair = inputhairLength,inputHair//

                    EyeColor = inputEyeColor,
                    BirthDate = inputBirthDate,

                    Hair = new Hair()
                    {
                        Length = inputhairLength,
                        Color = inputHairColor,
                        Type = inputHairType
                    }
                };


                people.Add(newPerson);

                Console.WriteLine(newPerson.ToString());


            }
            catch
            {
                Console.WriteLine("Fel inmatning, försök igen.");
            }
        }

        public static void ListPersons(List<Person> people)
        {
            foreach (Person pList in people)
            {
                Console.WriteLine();

                Console.WriteLine(pList.ToString());

                Console.WriteLine();
            }
        }


    }
}

