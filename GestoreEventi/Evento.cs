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
        private DateTime dateTime;
        private int massimaCapienza;
        private int postiPrenotati;

        public string GetTitolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public DateTime GetDateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }


    }
}
