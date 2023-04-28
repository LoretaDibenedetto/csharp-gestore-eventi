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
                    throw new ArgumentException("Il titolo non può essere vuoto.");
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
                    throw new ArgumentException("La data dell'evento non può essere nel passato.");
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




    }
}
