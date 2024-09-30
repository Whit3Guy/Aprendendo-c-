using System.Text.Json;
using Ex1;

namespace exercicios{
    abstract class Carro_Exc{
           public static void Rodar_exc_1()
        {

        Console.WriteLine("Insira seu nome");
        string name = Console.ReadLine();

        Console.WriteLine($" ");

        Console.WriteLine($"{name}, seja bem vindo ao seu sistema de controle de carro!");

        Console.WriteLine($" ");

        Console.WriteLine($"{name}, qual é a marca do seu carro? ");
        string marca = Console.ReadLine();

        Console.WriteLine($"E o modelo do seu carro? ");
        string modelo = Console.ReadLine();


        Console.WriteLine($"O ano do seu carro? ");
        int ano = int.Parse(Console.ReadLine());

        Console.WriteLine($"A velocidade atual do seu carro? ");
        decimal velocidade = decimal.Parse(Console.ReadLine());
        
        Car carro = new(marca, modelo, ano, velocidade);

        Console.WriteLine($"Vamos começar!");

        

    bool on = true;
    string decisao = "";


        while(on)
        {
            Console.WriteLine($" ");
            decisao = null;
            Console.WriteLine($"O que você gostaria de fazer?");
            Console.WriteLine($"1. Acelerar");
            Console.WriteLine($"2. Frear");
            Console.WriteLine($"3. Verificar a velocidade atual");
            Console.WriteLine($"4. Sair");
    
            decisao = Console.ReadLine();


        switch(decisao)
        {
            case "1":

                Console.WriteLine(" ");
                
                Console.WriteLine("Quanto você deseja acelerar? ");
                int num =  int.Parse(Console.ReadLine());
                carro.Acelerar(num);
                break;

            case "2":
                Console.WriteLine(" ");
                Console.WriteLine("Quanto você deseja frear? ");
                int num2 =  int.Parse(Console.ReadLine());
                carro.Frear(num2);
                break;

            case "3":
                Console.WriteLine(" ");
                Console.WriteLine($"Sua velocidade atual é {carro.Velocidade_atual} km/h");
                
                break;
            case "4":
                Console.WriteLine(" ");
                Console.WriteLine(" Dados do seu carro: ");
                string text = JsonSerializer.Serialize(carro);
                Console.WriteLine(text);
                Console.WriteLine("Bye!");
                on = false;

                break;
            default:
                Console.WriteLine(" ");
                Console.WriteLine("caiu no default");
                break;

        }

        }


    }
}
}
