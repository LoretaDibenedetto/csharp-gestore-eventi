﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Conferenza:Evento
    {

        private string relatore;
        private double prezzo;

        public Conferenza(string relatore, double prezzo, string titolo, DateTime data, int massimacapienza, int postiPrenotati = 0) : base(titolo, data, massimacapienza, postiPrenotati)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        public string GetRelatore()
        {
            return relatore;
        }

        public void SetRelatore(string newrelatore)
        {
            this.relatore = newrelatore;
        }
        

        public double GetPrezzo()
        {
            return prezzo;
        }

        public void SetPrezzo(double newprezzo)
        {
            this.prezzo = newprezzo;
        }


        public string GetDataOraFormattata()
        {
            return GetDateTime.ToString("dd/MM/yyyy HH:mm");
        }

        public string GetPrezzoFormattato()
        {
            return prezzo.ToString("0.00") + " euro";
        }

        public override string ToString()
        {
            return $"{GetDataOraFormattata()} - {GetTitolo} - {relatore} - {GetPrezzoFormattato()}";
        }

    }
}