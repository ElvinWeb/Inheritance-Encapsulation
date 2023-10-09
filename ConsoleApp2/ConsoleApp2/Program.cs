namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Programmer programmer = new Programmer();
            programmer.Name = "Elvin";
            programmer.Surname = "Sarkarov";
            programmer.Age = 19;
            programmer.Speciality = "FrontEnd: React Developer";
            programmer.Experience = 2.5;

            programmer.ShowFullInfo();
        }
    }
}