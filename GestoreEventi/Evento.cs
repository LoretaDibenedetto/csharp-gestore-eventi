using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int massimaCapienza = 200;
        private int postiPrenotati;

        public string GetTitolo
        {
            get { return titolo; }
            set
            {
                if (titolo == "")
                {
                    throw new Exception("Il titolo non può essere vuoto.");
                }
                titolo = value;
            }
        }

        public DateTime GetDateTime
        {
            get { return data; }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new Exception("La data dell'evento non può essere nel passato.");
                }
                data = value;
            }
        }

        public int GetMassimaCapienza
        {
            get { return massimaCapienza; }
            
        }

        public int GetPostiPrenotati
        {
            get { return postiPrenotati; }
        }

       

        public Evento(string titolo, DateTime data, int massimacapienza, int postiPrenotati = 0) 
        {
            this.titolo = titolo;
            this.data = data;
            this.massimaCapienza= massimacapienza;
            this.postiPrenotati= postiPrenotati;
        
        
        
        }

        public void PrenotaPosti(int postiDaPrenotare )
        {
          if(data < DateTime.Today)
            {
                throw new Exception("Non è possibile prenotare posti per una data passata.");
            }
          if (postiDaPrenotare <= 0) 
            {
            
             throw new Exception("il numero di posti da prenotare deve essere maggiore di 0");
            
            
            }

          if (postiPrenotati + postiDaPrenotare > massimaCapienza)
            {
                throw new Exception("non ci sono abbastanza posti liberi");
            }

            postiPrenotati += postiDaPrenotare;
        }

        public void DisdiciPosti(int postiDaDisdire)
        {
            if(data < DateTime.Today)
            {
                throw new Exception("non e' possibile disdire posti di un evento accaduto in passato");
            }
            if (postiDaDisdire <= 0)
            {
                throw new Exception("Il numero di posti da disdire deve essere un numero positivo.");
            }
            if (postiPrenotati - postiDaDisdire  < 0)
            {
                throw new Exception("Non ci sono abbastanza posti prenotati per disdire questo numero di posti.");
            }
            postiPrenotati -= postiDaDisdire;
        }

        public override string ToString()
        {
            string infoProduct =
            $"Titolo: {this.titolo} \n" +
           // $"Data: {this.data.ToString()} \n" +
            $"massima capienza: {this.massimaCapienza} \n" +
            $"posti prenotati: {this.postiPrenotati} \n";
           

            return infoProduct;
        }









    }
}
