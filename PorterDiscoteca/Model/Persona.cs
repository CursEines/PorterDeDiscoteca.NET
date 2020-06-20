namespace PorterDiscoteca.Model
{

    public enum Sexe
    {
        Home = 0,
        Dona = 1
    }

    public enum Calçat
    {
        SabatesDeMudar = 0,
        Sandalies = 1,
        Vambes = 2,
        Xancletes = 3,
    }


    public class Persona
    {
        public string Nom { get; set; }
        public Sexe Sexe { get; set; }
        public decimal DinersQuePorta { get; set; }

        public decimal PreuAproximatDeLaRoba { get; set; }
        public Calçat Sabates { get; set; }
        public bool PortaPantalonsCurts { get; set; }
        public bool SemblaQueHaBegutMoltAlcohol { get; set; }

        public Persona(string nom, Sexe sexe, decimal dinersQuePorta, decimal preuAproximatDeLaRoba, Calçat sabates, bool portaPantalonsCurts, bool semblaQueHaBegutMoltAlcohol)
        {
            Nom = nom;
            Sexe = sexe;
            DinersQuePorta = dinersQuePorta;
            PreuAproximatDeLaRoba = preuAproximatDeLaRoba;
            Sabates = sabates;
            PortaPantalonsCurts = portaPantalonsCurts;
            SemblaQueHaBegutMoltAlcohol = semblaQueHaBegutMoltAlcohol;
        }
    }
}