



using GestoreEventi;
using System.Globalization;



//Console.WriteLine("Benvenuto nel programma di organizzazione eventi!");


//Console.Write("Inserisci il titolo del programma di eventi: ");
//string titolo = Console.ReadLine();


//ProgrammaEventi programma = new ProgrammaEventi(titolo);

//Console.Write("Quanti eventi vuoi inserire? ");
//int numEventi;

//while (!int.TryParse(Console.ReadLine(), out numEventi) || numEventi <= 0)
//{
//    Console.Write("Inserisci un numero intero: ");
//}

//for (int i = 0; i < numEventi; i++)
//{

//    Console.WriteLine($"\nInserimento evento {i + 1}");



//    Console.Write("Inserisci il titolo dell'evento: ");
//    string titoloEvento = Console.ReadLine();


//    Console.Write("Inserisci la data dell'evento (nel formato yyyy-MM-dd): ");
//    DateTime dataEvento;

//    while (!DateTime.TryParse(Console.ReadLine(), out dataEvento))
//    {
//        Console.Write("Inserisci una data valida nel formato specificato: ");
//    }

//    Console.Write("Inserisci il numero di posti disponibili per l'evento: ");
//    int numPosti;

//    while (!int.TryParse(Console.ReadLine(), out numPosti) || numPosti <= 0)
//    {
//        Console.Write("Inserisci un numero intero positivo: ");
//    }


//    Console.WriteLine("Quanti posti vuoi prenotare? ");


//    int postiDaPrenotare;
//    while (!int.TryParse(Console.ReadLine(), out postiDaPrenotare))
//    {
//        Console.WriteLine("i posti prenotati sono" + postiDaPrenotare);
//    }

//        Evento nuovoEvento = new Evento(titoloEvento, dataEvento, numPosti, postiDaPrenotare);

//    try
//    {

//        programma.aggiungiEvento(nuovoEvento);
//        Console.WriteLine($"Evento '{titoloEvento}' aggiunto");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Errore non hai inserito l'evento: {ex.Message}");
//        i--; 
//    }
//}

//Console.WriteLine($"\nNumero di eventi presenti nel programma: {programma.NumeroEventi()}");

//Console.WriteLine("Lista di eventi nel programma:");
//Console.WriteLine(programma);

//Console.Write("\nInserisci una data per visualizzare gli eventi in quella data (nel formato yyyy-MM-dd): ");
//DateTime dataRicerca;
//while (!DateTime.TryParse(Console.ReadLine(), out dataRicerca))
//{
//    Console.Write("Inserisci una data valida nel formato specificato: ");
//}

//List<Evento> eventiInData = programma.EventiInData(dataRicerca);
//Console.WriteLine($"\nEventi in data {dataRicerca.ToShortDateString()}:");







Console.WriteLine("---------bonus----------");
ProgrammaEventi programma = new ProgrammaEventi("Programma Conferenze");
Console.WriteLine("Inserisci il numero di conferenze che vuoi aggiungere:");
int numConferenze = int.Parse(Console.ReadLine());

for (int i = 0; i < numConferenze; i++)
{
    Console.WriteLine($"Conferenza {i + 1}");






    Console.Write("Inserisci la data e l'ora (formato gg/mm/aaaa hh:mm): ");
    DateTime dataOra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
    if (dataOra != DateTime.Now)
    {
        Console.WriteLine("orario o data non adatta ");

    }



    Console.Write("Inserisci il titolo: ");
    string titolo = Console.ReadLine();




    Console.Write("Inserisci il nome del relatore: ");
    string relatore = Console.ReadLine();



    Console.Write("Inserisci il prezzo: ");
    double prezzo = double.Parse(Console.ReadLine());

    Console.WriteLine("Quanti posti vuoi prenotare? ");
    int postiDaPrenotare;
    while (!int.TryParse(Console.ReadLine(), out postiDaPrenotare))
    {
        Console.WriteLine("i posti prenotati sono" + postiDaPrenotare);
    }


    Console.Write("Inserisci il numero di posti disponibili per l'evento: ");
    int capienzaMassima;

    while (!int.TryParse(Console.ReadLine(), out capienzaMassima) || capienzaMassima <= 0)
    {
        Console.Write("Inserisci un numero intero positivo: ");
    }
    try
    {
        Conferenza conferenza = new Conferenza(relatore, prezzo, titolo, dataOra, capienzaMassima, postiDaPrenotare);
        programma.aggiungiEvento(conferenza);
        Console.WriteLine("Conferenza aggiunta al programma eventi!");
        Console.WriteLine($"stampa lista eventi{programma}");
        Console.WriteLine($"Numero di eventi nel programma: {programma.NumeroEventi()}");
    }
    catch (ArgumentException e)
    {
        Console.WriteLine($"Errore: {e.Message}");
        Console.WriteLine("Conferenza non aggiunta al programma eventi.");
    }
}





