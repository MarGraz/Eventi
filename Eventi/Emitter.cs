using System;
using System.Collections.Generic;
using System.Text;

namespace Eventi
{
    /// <summary>
    /// Questa classe si occupa di notificare a tutti gli oggetti in ascolto (listener) che un evento si è verificato
    /// </summary>
    public class Emitter
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnNewMessage(message); }
        }

        //definisco un nuovo evento (event), ed il delegate (Action) si occuperà di notificare l'evento a tutti i sottoscrittori.
        //Qualsiasi delegate può essere usato per definire un evento, non è obbligatorio l'uso di Action
        public event Action<string> NewMessage;

        //Definisco il metodo che notificherà gli eventi.
        // --> Questo metodo andrà chiamato ogni volta che il contenuto della proprietà message cambia, infatti viene richiamato nel "set" della proprietà "Message"
        public void OnNewMessage(string msg)
        {
            //se ci sono sottoscrittori attivi
            if(NewMessage != null)
            {
                //notifico a tutti la presenza di un nuovo messaggio
                NewMessage(msg);
            }
        }

    }
}
