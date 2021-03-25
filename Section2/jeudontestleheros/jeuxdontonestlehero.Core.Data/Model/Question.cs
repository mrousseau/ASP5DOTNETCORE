using System;
using System.Collections.Generic;
using System.Text;

namespace jeuxdontonestlehero.Core.Data.Model
{
    public class Question
    {
        #region Propriete

            public int Id { get; set; }

            public string Titre { get; set; }

            public List<Reponse> MesReponses { get; set; }

        #endregion

    }
}
