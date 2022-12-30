
using CS_academy.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CS_academy
{
    internal class Program
    {
   
        static void Main(string[] args)
        {

            Console.WriteLine("hej");


            // Hämta en variabel och placera in i en sträng med hjälp av "$" i början av strängvärdet samt  { x } där vi vill ha variabeln 
            string varName = "tja";
            string annanVarName = $"Min favorithälsning är: {varName}";


            Console.WriteLine(annanVarName);


            // TRIMMA koden

            string greeting = "      Hello World!       ";

            greeting.Trim(); // "Hello World!"

            greeting = greeting.Trim(); // Faktiskt sätter nya strängvärdet


            Console.WriteLine(greeting.Contains("hello"));
            Console.WriteLine(greeting.Contains("Hello"));
            Console.WriteLine(greeting);


           // skapa en ny klassinstans av "Person" 

           Person Jessica = new Person("Jessica");

           Person Erik = new Person("Erik");


            string namnet = Erik.v1;

            Erik.v1 = "Johanna"; // detta blir "value"

            Erik.v2 = 66; // 66 blir  "value"


            Console.WriteLine("antal personer: "+Person.numberOfPeople);

            // Skapa listor:
            var listan = new List<Person>();


            // Arrays

            string[] myNum = new string[2];

            myNum[0] = "tja";
            myNum[1] = "tjenare";
            myNum[2] = "hallå";


            Array.Resize<string>(ref myNum, 30);
            myNum[3] = "hallå";
            myNum[4] = "hallå";
             


            void addToArray(string[] arrayn, string[] newValues) {

                var length = arrayn.Length; // 2

                if (length > newValues.Length)
            {

                for (int i = 0; i< newValues.Length; i++) {
                        arrayn[length] = newValues[i];
                   
                }
            }
            }







            Console.WriteLine(myNum[3]);


            // DateTime:

            Console.WriteLine("Det är just nu:"+ DateTime.Now);


        }

    }
}