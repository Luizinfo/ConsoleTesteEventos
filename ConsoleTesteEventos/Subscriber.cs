using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTesteEventos
{
    //Etapa2-Criar um subscriber ou assinante
    class Subscriber
    {
        //Tratamento do evento
        public void OnTrabalhoFeitoEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("O Subscriber/Assinante foi notificado");
        }
    }
}
