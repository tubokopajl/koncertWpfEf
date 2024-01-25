using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koncertWpfEf.Models
{
    public class Koncert
    {
        //id cim eloado idopont, letszam ,ar, helyszin

        public int Id { get; set; }

        public string Cim { get; set; }

        public string Eloado { get; set; }

        public DateTime IdoPont { get; set; }

        public int Letszam { get; set; }

        public int Ar { get; set; }

        public string Helyszin { get; set; }
    }
}
