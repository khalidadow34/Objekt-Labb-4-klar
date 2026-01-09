using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static Objekt_Labb_4.Sprint_1;

namespace Objekt_Labb_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            List<Person> people;

            people = new List<Person>();

            bool Villkor = true;
            bool Villkor2 = true;


            Sprint_1.Person PushinP = new Sprint_1.Person
            {
                BirthDate = new DateTime(2001, 3, 13),
                EyeColor = "Blue",
                Gender = Sprint_1.Gender.Man,

                Hair = new Sprint_1.Hair

                {
                    Length = 12.5,
                    Color = "Brown",
                    Type = "Curly"

                }

            };

            people.Add(PushinP);


            while (Villkor)
            {



                Console.WriteLine("Välj ett alternativ : \n" +
                "1. Visa nuvarande Lista\n" +
                "2. Lägg till person \n" +
                "3. Avsluta Program");

                string inputchoice = Console.ReadLine();

                
                switch (inputchoice)
                {
                    case "1":

                        ListPersons(people);
                        break;

                    
                    case "2":

                        AddPerson(people);

                        Console.WriteLine();
                        Console.WriteLine("Kör Tillbaka Till Menyn");
                        Console.WriteLine();
                        break;


                    case "3":

                        Console.WriteLine("Avslutar Programmet...");

                        Villkor = false;
                        break;

                    default:

                        Console.WriteLine("Fel inmatning. Försök igen");
                        break;
                }


            }







        }
    }
    
}