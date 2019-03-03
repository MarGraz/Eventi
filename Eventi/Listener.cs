using System;
using System.Collections.Generic;
using System.Text;

namespace Eventi
{
    public class Listener
    {
        //Riceverà la notifica dell'evento da parte del delegate Action nella classe "emitter"
        public void MessageHandler(string message)
        {
            Console.WriteLine("Ricevuto il messaggio: {0}", message);
        }

    }
}
