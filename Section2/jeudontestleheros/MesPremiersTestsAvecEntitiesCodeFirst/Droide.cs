using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MesPremiersTestsAvecEntitiesCodeFirst
{
    [Table("Droides")]
    public class Droide
    {
        public int Id { get; set; }

        //public Armes Armes { get; set;  }

        public string Matricule { get; set;  }
    }
}
