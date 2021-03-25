using System;
using System.Collections.Generic;
using System.Text;

namespace jeuxdontonestlehero.Core.Data.Model
{
    public class Paragraphe
    {
        #region Proprietes
        public int id { get; set; }

        public int Numero { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        public Question MaQuestion { get; set; }


        #endregion
    }
}
