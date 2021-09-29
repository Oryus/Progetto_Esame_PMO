using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PMO
{
    //Questa classe ci permette di costruire la classe Fine(multa)
    //Questo metodo di costruzione della classe viene preso dal design pattern Builder
    class BuilderFine
    {
        //Istanziamo una variabile Fine
        private Fine multa;

        //Questo costruttore serve a resettare sempre i dati di Fine
        public BuilderFine() { this.Reset(); }
        private void Reset()
        {
            multa = new Fine();
        }

        //Questi sono i metodi per l'inserimento dei dati
        public BuilderFine buildId(int id) { multa.Id = id; return this; }
        public BuilderFine buildNomeCitt(string nomeCitt) { multa.Nome_Citt = nomeCitt; return this; }
        public BuilderFine buildNomeUff(string nomeUff) { multa.Nome_Uff = nomeUff;  return this; }
        public BuilderFine buildIndirizzo(string comune, string via) { multa.Comune = comune; multa.Via = via; return this; }
        public BuilderFine buildData(DateTime data) { multa.Data = data.Date; multa.Scadenza = data.AddMonths(3).Date; return this; }
        public BuilderFine buildScadenza(DateTime scadenza) { multa.Scadenza = scadenza.Date; return this; }
        public BuilderFine buildDescr(string descrizione) { multa.Descrizione = descrizione; return this; }
        public BuilderFine buildImporto(string importo) { multa.Importo = importo; return this; }
        public BuilderFine buildStato(bool stato) { multa.Stato = stato; return this; }
        public Fine Build() { return multa; }
    }
}
