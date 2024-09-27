class Program{
    static void Main(){
        string name;
        int birthdate;
        int age;


        Console.Write("Insert your name: ");
        name = Console.ReadLine();

        Console.Write("Insert birthdate: ");
        birthdate = int.Parse(Console.ReadLine());
        
        age = 2024 - birthdate;

        Console.WriteLine($"Hi {name}!");

        Console.WriteLine($"You have {age} years old");

        if(age >= 18)
        {
        Console.WriteLine($"You are of legal age");
        }
        else
        {
        Console.WriteLine($"You aren't of legal age");

        }

    }
}