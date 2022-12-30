namespace CS_academy.Models
{
    internal class Person
    {
        public static int numberOfPeople; // 0 

        public string v1;
        public int v2;
        public int v3 { get; set; }

        

        public Person(string yyyy, int v2)
        {
            this.v1 = yyyy;
            this.v2 = v2;

          
        }


        public Person(string x)
        {

            this.v1 = x;

            numberOfPeople++; // plussar på 1  på number of people

        }

    }
}