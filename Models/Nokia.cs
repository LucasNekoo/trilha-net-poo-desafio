namespace DesafioPOO.Models
{
    // Classe que herda de Smartphone e representa um Nokia
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação da instalação de aplicativo específica para o Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}
