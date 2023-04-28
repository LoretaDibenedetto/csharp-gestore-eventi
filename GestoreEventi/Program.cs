﻿



using GestoreEventi;

Console.Write("Inserisci il titolo dell'evento: ");
string titolo = Console.ReadLine();


Console.Write("Inserisci la data dell'evento (formato gg/mm/aaaa): ");
DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);



Console.Write("Inserisci la capienza massima dell'evento: ");
int capienzaMassima = int.Parse(Console.ReadLine());




Evento nuovoEvento = new Evento(titolo, data, capienzaMassima);



Console.Write("Vuoi prenotare dei posti? (S/N): ");
string sceltaUtente = Console.ReadLine();


while (sceltaUtente.ToLower() == "s")
{
    Console.Write("Quanti posti vuoi prenotare? ");
    int postiDaPrenotare = int.Parse(Console.ReadLine());

        nuovoEvento.PrenotaPosti(postiDaPrenotare);
  
    Console.Write("Vuoi prenotare altri posti? (S/N): ");
    sceltaUtente = Console.ReadLine();



Console.WriteLine("numero di posti prenotati:" +  nuovoEvento.GetPostiPrenotati);
Console.WriteLine("numero di posti disponibili: " + nuovoEvento.GetMassimaCapienza);




    Console.WriteLine("vuoi disdire dei posti? (s/n): ");
    sceltaUtente = Console.ReadLine();
    Console.Write("Quanti posti vuoi disdire? ");
    int postiDaDisdire = int.Parse(Console.ReadLine());


    nuovoEvento.DisdiciPosti(postiDaDisdire);


    Console.Write("Vuoi disdire altri posti? (S/N): ");
    sceltaUtente = Console.ReadLine();


Console.WriteLine("numero di posti prenotati:" + nuovoEvento.GetPostiPrenotati);
Console.WriteLine("numero di posti disponibili: " + nuovoEvento.GetMassimaCapienza);
}






