class Program{

    
    static void Main(){

        void registrar(){

        Console.WriteLine("Insira o nome do produto: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Insira o valor do produto: ");
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira a data de validade do produto: ");
        string data_validade = Console.ReadLine();

        Register MeuRegistro = new(nome, data_validade, valor);
        MeuRegistro.register_product();
        }

        Console.WriteLine("deseja registrar quantos produtos? ");
        int contador = int.Parse(Console.ReadLine());
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"{i + 1}° produto: ");
            registrar();
        }
    }
}
class Register{
    protected string name;
    protected int value;
    protected string validate_time;

    public string message;


    public Register(string name, string validate_time, int value)
    {
        this.name = name;
        this.validate_time = validate_time;
        this.value = value;
    }

    void create_message(){ 
        this.message = $"Produto {this.name} de valor {this.value} com a data de validade {this.validate_time} vendido";
    }

    public void register_product(){
        create_message();
        File.AppendAllText("log.txt", this.message);
    }
}