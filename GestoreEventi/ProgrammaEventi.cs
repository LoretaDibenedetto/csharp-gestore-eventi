using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        string Titolo;
        List<Evento> eventi;


        public ProgrammaEventi( string Titolo)
        {
            this.Titolo = Titolo;
            eventi = new List<Evento>();
        }

        public string GetTitolo
        {
            get { return Titolo; }
        }

        public List<Evento> GetEventi()
        {
            return eventi;
        }




    }
}
