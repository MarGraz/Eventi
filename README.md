# Eventi

Gli eventi si basano sull'uso dei <b>delegate</b>. Questo modello segue il <b>design pattern "Observer"</b>, che consente a un sottoscrittore (<b>Listener</b>) di effettuare la registrazione e ricevere notifiche da un oggetto (<b>Emitter</b>). 

Un evento è un messaggio inviato da un oggetto per segnalare l'occorrenza di un'azione. L'azione può essere causata dall'interazione dell'utente, ad esempio la pressione di un pulsante, oppure generata da altre logiche di programma, ad esempio la modifica di un valore della proprietà, come in questo esempio.
La classe Emitter implementerà il metodo che notificherà l'avvenuto evento a tutti i Listener, solitamente questo evento viene denominato con il <b>prefisso "On..."</b>, in questo esempio "OnNewMessage".

In questo esempio si è fatto uso anche del <b>multicast</b> per simulare la notifica dell'evento a due diversi oggetti Listener.
