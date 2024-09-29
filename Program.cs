
class Program{
        static void Main(){
                       //Sendo delegate um método anônimo, e agora o C# o enxerga como um Func, que se executa normal como função, um método anônimo
        var multiply = delegate (int x, int y){return x*y;};
        Console.WriteLine(multiply(10,12));
        Calculate calculate = new(Sum);
        var result = calculate(10,20);
        Console.WriteLine(result);
        Run(Multiply);
    
    }
    static void Run(Calculate calc){
        Console.WriteLine(calc(30,50));
    }
    static int Sum(int a, int b){
        return a + b;
    }
    static int Multiply(int a, int b){
        return a * b;
    }

}

delegate int Calculate(int x, int y);