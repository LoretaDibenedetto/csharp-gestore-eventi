﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public void aggiungiEvento(Evento newEvento)
        {
            eventi.Add(newEvento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();
            
            foreach (Evento eventoSingolo in eventi)
            {

                if (eventoSingolo.GetDateTime == data)
                {
                  
                    eventiInData.Add(eventoSingolo);
                }
            }
            return eventiInData;
        }
       
            public static string ConvertiListaInStringa(List<Evento> listaEventi)
            {
                string str = "";
                foreach (Evento eventoSingolo in listaEventi)
                {
                    str += $"{eventoSingolo.GetDateTime} - {eventoSingolo.GetTitolo}\n";
                }
                return str;
            }
        public void PulisciLista()
        {
            eventi.Clear();
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }


        public override string ToString()
        {
            string str = base.ToString();
            str = "";
            foreach (Evento eventoSingolo in eventi)
            {
                str += $"{eventoSingolo.GetDateTime} - {eventoSingolo.GetTitolo}\n";
            }
            return str;
        }
    }
}
