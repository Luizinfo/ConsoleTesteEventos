using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTesteEventos
{
    class Publisher
    {
        //Etapa1.1-Criar um delegate cujo nome seja
        //"nomeDoEvento"+EventHandler
        public delegate void TrabalhoFeitoEventHandler(object sender, EventArgs args);

        //Etapa1.2-Criar um evento baseado no delegate
        public event TrabalhoFeitoEventHandler TrabalhoFeito;
        public void ProcessaUmTrabalho()
        {
            Console.WriteLine("Publisher/Editor : Um trabalho foi concluído");
            //Etap1.3-Dispara o evento
            OnTrabalhoFeito();
        }

        /*O parão standard requer que o método seja definido como protected virtual. 
        * O nome também precisa coincidir com o nome do evento e será prefixado com 'On'.*/
        protected virtual void OnTrabalhoFeito()
        {
            //modo tradicional
            //if (TrabalhoFeito != null)
            //    TrabalhoFeito(this, EventArgs.Empty);
            //modo simplificado
            TrabalhoFeito?.Invoke(this, EventArgs.Empty);

        }
    }
}
