using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_PMO
{
    //Questa classe ci permette di costruire la classe Civil
    //Questo metodo di costruzione della classe viene preso dal design pattern Builder
    class BuilderCivil 
    {
        //Istanziamo una variabile Civil
        private Civil utente;

        //Questo costruttore serve a resettare sempre i dati di Civil
        public BuilderCivil() { this.Reset(); }
        private void Reset()
        { 
            utente = new Civil();   
        }

        //Questi sono i metodi per l'inserimento dei dati
        public BuilderCivil buildNome(string name) { utente.Nome = name; return this; }
        public BuilderCivil buildCognome(string cognome) { utente.Cognome = cognome; return this; }
        public BuilderCivil buildCodFisc(string codFisc) { utente.CodFisc = codFisc; return this; }
        public BuilderCivil buildEmail(string email) { utente.Email = email; return this; }
        public BuilderCivil buildPassword(string pass) { utente.Password = pass; return this; }
        public BuilderCivil buildIndirizzo(string via, string comune) { utente.Via = via; utente.Comune = comune; return this; }
        public BuilderCivil buildCellulare(string cellulare) { utente.Cellulare = cellulare; return this; }
        public Civil Build() { return utente; }
    }
}
