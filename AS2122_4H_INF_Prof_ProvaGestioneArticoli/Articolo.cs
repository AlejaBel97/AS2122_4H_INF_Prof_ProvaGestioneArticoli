using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        
        private string descrizione;
        private string unitaMisura;
        private double prezzo;
        private int codice;
        // ...

        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo

        public string Descrizione { get => descrizione; }
        public string UnitaMisura { get => unitaMisura; }
        public double Prezzo { get => prezzo; }
        public int Codice { get => codice; }
        // ...


        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
            this.codice = codice;
            // ...
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}
