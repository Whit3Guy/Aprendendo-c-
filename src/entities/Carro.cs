namespace Ex1
{
        class Car
    {
        private string marca; 
        private string modelo; 
        private int ano; 
        private decimal velocidade_atual;
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public decimal Velocidade_atual { get => velocidade_atual; set => velocidade_atual = value; }
        public Car(string marca, string modelo, int ano, decimal velocidade_atual){
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Velocidade_atual = velocidade_atual;
        }
        public void Acelerar(decimal xlr8){
            if(xlr8 <= 0)
            {
                return;
            }
            Velocidade_atual += xlr8;        
        }
        public void Frear(decimal dessacelerar){
            if(dessacelerar <= 0)
            {
                return;
            }
            if(Velocidade_atual - dessacelerar < 0){
                Velocidade_atual = 0;
                return;
            }
            Velocidade_atual -= dessacelerar;        
        }



        
    }
}