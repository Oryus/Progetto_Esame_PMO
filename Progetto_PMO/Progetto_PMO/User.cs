using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PMO
{
    //Questa classe astratta è la classe padre delle classi Civil e Police
    //Questa da un impronta del comportamento delle sue due classi figlio
    abstract class User
    {
        //Questi attributi sono presenti in entrambi le classi
        private string nome;
        private string cognome;
        private string codFisc;
        private string email;
        private string password;

        //Metodi associati agli attributi
        public string Nome{ get => nome; set => nome = value; }                     //Permette di cambiare e restituire il valore di nome
        public string Cognome { get => cognome; set => cognome = value; }           //Permette di cambiare e restituire il valore di cognome
        public string CodFisc { get => codFisc; set => codFisc = value; }           //Permette di variare e restituire il valore di codice fiscale
        public string Email { get => email; set => email = value; }                 //Permette di variare e restituire il valore di email
        public string Password { get => password; set => password = value; }        //Permette di variare e restituire il valore di password
    }
}
