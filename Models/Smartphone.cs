using System;

namespace DesafioPOO.Models
{
    // Classe abstrata que serve como base para classes específicas de smartphones
    public abstract class Smartphone
    {
        // Propriedades comuns a todos os smartphones
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor que inicializa as propriedades comuns
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método comum a todos os smartphones para ligar
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método comum a todos os smartphones para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que deve ser implementado nas classes derivadas para instalar aplicativos
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
