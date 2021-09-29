using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PMO
{
    //Questa classe ci permette di costruire la classe Police
    //Questo metodo di costruzione della classe viene preso dal design pattern Builder
    class BuilderPolice 
    {
        //Istanziamo una variabile Police
        private Police utente;

        //Questo costruttore serve a resettare sempre i dati di Police
        public BuilderPolice() { this.Reset(); }
        private void Reset()
        {
            utente = new Police();
        }

        //Questi sono i metodi per l'inserimento dei dati
        public BuilderPolice buildNome(string nome) { utente.Nome = nome; return this; }
        public BuilderPolice buildCognome(string cognome) { utente.Cognome = cognome; return this; }
        public BuilderPolice buildCodFisc(string codFisc) { utente.CodFisc = codFisc; return this; }
        public BuilderPolice buildEmail(string email) { utente.Email = email; return this; }
        public BuilderPolice buildPassword(string pass) { utente.Password = pass; return this; }
        public BuilderPolice buildGrado(string grado) { utente.Grado = grado; return this; }
        public BuilderPolice buildIstituto(string istituto) { utente.Istituto = istituto; return this; }
        public Police Build() { return utente; }
    }
}
