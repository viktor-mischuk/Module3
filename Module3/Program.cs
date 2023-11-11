namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Name = "Victor";
            byte Age = 59;
            bool HavePet = true;
            double ShoeSize = 47;

            Console.WriteLine("Меня зовут " + Name);
            Console.WriteLine("Мой возраст {0} лет", Age);
            Console.WriteLine("Имеете животное? " + HavePet);
            Console.WriteLine("Мой размер обуви - " + ShoeSize);
        }
    }
}