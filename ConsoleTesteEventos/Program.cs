using System;

namespace ConsoleTesteEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Demo de um evento simples ***");
            //cria instancia do Editor e do Assinante
            Publisher remetente = new Publisher();
            Subscriber receptor = new Subscriber();
            //Define o tratamento de evento
            remetente.TrabalhoFeito += receptor.OnTrabalhoFeitoEventHandler;
            //invoca o método
            remetente.ProcessaUmTrabalho();
            Console.ReadKey();
        }
    }
}
