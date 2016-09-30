using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excuses
{
    /// <summary>
    /// 
    /// </summary>
    public class Excuse
    {
        public Excuse(string nomEleve, string prenomEleve, string nomEtablissement, string addresse, string cp, string ville, string numTel, string email, string sexeDestinataire, string nomDestinaire, DateTime dateAbsence, DateTime dateNow)
        {
            NomEleve = nomEleve;
            PrenomEleve = prenomEleve;
            NomEtablissement = nomEtablissement;
            Addresse = addresse;
            Cp = cp;
            Ville = ville;
            NumTel = numTel;
            Email = email;
            SexeDestinataire = sexeDestinataire;
            NomDestinaire = nomDestinaire;
            Sexe.Add("Homme"); Sexe.Add("Femme");
            DateAbsence = dateAbsence;
            DateNow = dateNow;
        }

        public String NomEleve { get; set; }
        public String PrenomEleve { get; set; }
        public String NomEtablissement { get; set; }
        public String Addresse { get; set; }
        public String Cp { get; set; }
        public String Ville { get; set; }
        public String NumTel { get; set; }
        public String Email { get; set; }
        public String SexeDestinataire { get; set; }
        public String NomDestinaire { get; set; }
        public List<String> Sexe { get; set; }
        public List<String> LoremExcuses { get; set; }
        public DateTime DateAbsence { get; set; }
        public DateTime DateNow { get; set; }

        /// <summary>
        /// Ajout d'une excuse
        /// </summary>
        /// <param name="excuse"></param>
        public void addExcuse(String excuse)
        {
            this.LoremExcuses.Add(excuse);
        }
        /// <summary>
        /// Vide l'objet
        /// </summary>
        /// <param name="exc"></param>
        public void clearPage(Excuse exc)
        {
            exc.NomEleve = String.Empty;
            exc.PrenomEleve = String.Empty;
            exc.NomEtablissement = String.Empty;
            exc.Addresse = String.Empty;
            exc.Cp = String.Empty;
            exc.Ville = String.Empty;
            exc.NumTel = String.Empty;
            exc.Email = String.Empty;
            exc.SexeDestinataire = String.Empty;
            exc.NomDestinaire = String.Empty;
            exc.Sexe.Clear();
            exc.DateAbsence = new DateTime();
            exc.DateNow = new DateTime();
        }
        
    }
}
