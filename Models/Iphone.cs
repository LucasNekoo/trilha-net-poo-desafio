namespace DesafioPOO.Models
{
    // Classe que herda de Smartphone e representa um iPhone
    public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação da instalação de aplicativo específica para o iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}
