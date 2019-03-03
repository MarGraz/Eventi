using System;

namespace Eventi
{
    class Program
    {
        static void Main(string[] args)
        {

            //L'ogetto emitter sarà responsabile di emettere gli eventi
            Emitter emitt = new Emitter();

            //Gli oggetti Listener sottoscriveranno l'ascolto della classe Emitter
            Listener listen1 = new Listener();
            Listener listen2 = new Listener();

            //Delegate multicast per sottoscrivere l'ascolto dell'Emitter. Aggiungo i metodi "MessagHandler" di "Listener", sul delegate "NewMessage" responsabile della notifica di nuovi eventi
            emitt.NewMessage += listen1.MessageHandler;
            emitt.NewMessage += listen2.MessageHandler;

            //Genero due eventi. Per farlo è sufficiente cambiare il contenuto della proprietà "Message"
            emitt.Message = "Primo messaggio";
            emitt.Message = "Cambio messaggio";

            Console.WriteLine("Premi INVIO per terminare...");
            Console.ReadLine();
        }
    }
}
