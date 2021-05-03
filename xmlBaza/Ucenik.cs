using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvTransformer
{
    class Ucenik
    {
        private static int brojac = 0;
        private int UcenikID;
        private string ime;
        private string prezime;
        private string email;
        private string razred;

        public Ucenik(string ime, string prezime, string email, string razred)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.razred = razred;
            brojac++;
            this.UcenikID = brojac;
        }

        public Ucenik()
        {
            brojac++;
            this.UcenikID = brojac;
        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Razred { get => razred; set => razred = value; }
        public int UcenikID1 { get => UcenikID; }
    }
}
