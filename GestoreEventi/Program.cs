



using GestoreEventi;

//Console.Write("Inserisci il titolo dell'evento: ");
//string titolo = Console.ReadLine();


//Console.Write("Inserisci la data dell'evento (formato gg/mm/aaaa): ");
//DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);



//Console.Write("Inserisci la capienza massima dell'evento: ");
//int capienzaMassima = int.Parse(Console.ReadLine());




//Evento nuovoEvento = new Evento(titolo, data, capienzaMassima);



//Console.Write("Vuoi prenotare dei posti? (S/N): ");
//string sceltaUtente = Console.ReadLine();


//while (sceltaUtente.ToLower() == "s")
//{
//    Console.Write("Quanti posti vuoi prenotare? ");
//    int postiDaPrenotare = int.Parse(Console.ReadLine());

//    nuovoEvento.PrenotaPosti(postiDaPrenotare);

//    //Console.Write("Vuoi prenotare altri posti? (S/N): ");
//    //sceltaUtente = Console.ReadLine();



//    Console.WriteLine("numero di posti prenotati:" + nuovoEvento.GetPostiPrenotati);
//    Console.WriteLine("numero di posti disponibili: " + nuovoEvento.GetMassimaCapienza);




//    Console.WriteLine("vuoi disdire dei posti? (s/n): ");
//    sceltaUtente = Console.ReadLine();
//    Console.Write("Quanti posti vuoi disdire? ");
//    int postiDaDisdire = int.Parse(Console.ReadLine());


//    nuovoEvento.DisdiciPosti(postiDaDisdire);


//    Console.Write("Vuoi disdire altri posti? (S/N): ");
//    sceltaUtente = Console.ReadLine();


//    Console.WriteLine("numero di posti prenotati:" + nuovoEvento.GetPostiPrenotati);
//    Console.WriteLine("numero di posti disponibili: " + nuovoEvento.GetMassimaCapienza);
//}



////Evento evento1 = new Evento("Evento 1", new DateTime(2023, 5, 1), 200, 0);
////Evento evento2 = new Evento("Evento 1", new DateTime(2023, 5, 1), 200, 0);
////Evento evento3 = new Evento("Evento 1", new DateTime(2023, 5, 1), 200, 0);


//List<Evento> listaEventi = new List<Evento>
//{
//   nuovoEvento
//};
//;
//Console.WriteLine(listaEventi.ToString());



//Console.WriteLine(ProgrammaEventi.ConvertiListaInStringa(listaEventi));






//Console.WriteLine("Inserisci il titolo del programma eventi:");
//string titolo = Console.ReadLine();
//ProgrammaEventi programma = new ProgrammaEventi(titolo);

//Console.WriteLine("Quanti eventi vuoi aggiungere?");
//int numEventi = int.Parse(Console.ReadLine());

//for (int i = 0; i < numEventi; i++)
//{
//    Console.WriteLine($"Inserisci i dettagli dell'evento {i + 1}:");

//    Console.WriteLine("Titolo:");
//    string titoloEvento = Console.ReadLine();

//    Console.WriteLine("Data (formato gg/mm/aaaa):");
//    //DateTime dataEvento = DateTime.Parse(Console.ReadLine());
//    DateTime dataEvento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

//    Console.Write("Inserisci la capienza massima dell'evento: ");
//    int capienzaMassima = int.Parse(Console.ReadLine());



//    Console.Write("posti prenotati: ");
//    int postiPrenotati = int.Parse(Console.ReadLine());

//    Evento evento1 = new Evento(titoloEvento, dataEvento, capienzaMassima, postiPrenotati);

//    evento1.PrenotaPosti(postiPrenotati);
//    programma.aggiungiEvento(evento1);



//}

//programma.ToString();
//Console.WriteLine($"Numero eventi: {programma.NumeroEventi()}");

Console.WriteLine("Benvenuto nel programma di organizzazione eventi!");


Console.Write("Inserisci il titolo del programma di eventi: ");
string titolo = Console.ReadLine();


ProgrammaEventi programma = new ProgrammaEventi(titolo);

Console.Write("Quanti eventi vuoi inserire? ");
int numEventi;

while (!int.TryParse(Console.ReadLine(), out numEventi) || numEventi <= 0)
{
    Console.Write("Inserisci un numero intero: ");
}

for (int i = 0; i < numEventi; i++)
{

    Console.WriteLine($"\nInserimento evento {i + 1}");


    
    Console.Write("Inserisci il titolo dell'evento: ");
    string titoloEvento = Console.ReadLine();


    Console.Write("Inserisci la data dell'evento (nel formato yyyy-MM-dd): ");
    DateTime dataEvento;

    while (!DateTime.TryParse(Console.ReadLine(), out dataEvento))
    {
        Console.Write("Inserisci una data valida nel formato specificato: ");
    }

    Console.Write("Inserisci il numero di posti disponibili per l'evento: ");
    int numPosti;

    while (!int.TryParse(Console.ReadLine(), out numPosti) || numPosti <= 0)
    {
        Console.Write("Inserisci un numero intero positivo: ");
    }

    
    try
    {
        Evento nuovoEvento = new Evento(titoloEvento, dataEvento, numPosti);
        programma.aggiungiEvento(nuovoEvento);
        Console.WriteLine($"Evento '{titoloEvento}' aggiunto");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Errore non hai inserito l'evento: {ex.Message}");
        i--; 
    }
}

Console.WriteLine($"\nNumero di eventi presenti nel programma: {programma.NumeroEventi}");

Console.WriteLine("Lista di eventi nel programma:");
Console.WriteLine(programma.ToString());

Console.Write("\nInserisci una data per visualizzare gli eventi in quella data (nel formato yyyy-MM-dd): ");
DateTime dataRicerca;
while (!DateTime.TryParse(Console.ReadLine(), out dataRicerca))
{
    Console.Write("Inserisci una data valida nel formato specificato: ");
}

List<Evento> eventiInData = programma.EventiInData(dataRicerca);
Console.WriteLine($"\nEventi in data {dataRicerca.ToShortDateString()}:");

