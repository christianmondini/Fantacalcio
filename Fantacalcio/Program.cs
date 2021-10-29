using System;

namespace Fantacalcio
{

    //Classe Fantallenatore
    class Fantacalcio
    {

        //attributi

        string fantaallenatore;
        string[] squadraf1 =new string[11];
        string[] squadraf2 = new string[11];
        string calciatore;
        string squadra;
        int crediti;//crediti del fantaallenatore
        double punteggiog;//punteggio del giocatore
        int[] classifica;//array che contiene la calssifica dei fantaallenatori
        int punteggiof;//punteggio del fantaallenatore
        int golfanta;//gol del fantallenatore
        double punteggios;//punteggio della squadra
        //malus e bonus
        int gol;
        int assist;
        double giallo;
        int rosso;
        int rigoresegnato;
        int rigorepreso;
        int portiereimbattuto;
        int golpreso;
        int autorete;
        int rigoresbagliato;

        //costruttore
        public Fantacalcio()
        {



            //inizializzo i bonus/malus
            gol = 3;
            assist = 1;
            giallo = -0.5;
            rosso = -1;
            rigoresegnato = 2;
            rigorepreso = -1;
            rigoresbagliato = -3;
            autorete = -2;
            golpreso = -1;
            rigorepreso = 3;
            portiereimbattuto = 1;

        }

        //metodi
        public bool setFantaallenatore()
        {
            fantaallenatore = Console.ReadLine();
            return true;
        }

        public bool setTurno()
        {
           
            
        }

    }

    //Classe calciatorrrrrrrr
    class Calciatore
    {
        //attributi
        string nome;
        string squadra;
        string ruolo;

        public Calciatore(string n,string s,string r)
        {
            this.nome = n;
            this.squadra = s;
            this.ruolo = r;
        }

        public void setCalciatorenome()
        {
            nome = Console.ReadLine();
           
        }

        public void setCalciatoresquadra()
        {
            squadra = Console.ReadLine();
           
        }

        public void setCalciatoreruolo()
        {
            ruolo = Console.ReadLine();
        }

        public void controlloGiocatore()
        {

        }


    }

    //Class Programm
    class Program
    {
        static void Main(string[] args)
        {
            string n, s, r;
            n = "";
            s = "";
            r = "";
            Fantacalcio f = new Fantacalcio();
            Calciatore c = new Calciatore(n,s,r);
            int a;

            for (int i = 1; i != 3; i++)
            {
                Console.WriteLine("Inserisci nome del {0} fantallenatore", i);
                f.setFantaallenatore();
            }

            Console.WriteLine("Inizia l'asta!!!!!!!!");
            Console.WriteLine("Adesso dovrete proporre i vostri calciatori");

            for (int i = 0; i != 22; i++)
            {
                if()
                Console.WriteLine("Inserisci nome");
                c.setCalciatorenome();
                Console.WriteLine("Inserisci squadra");
                c.setCalciatoresquadra();
                Console.WriteLine("Inserisci ruolo");
                c.setCalciatoreruolo();
            }

        }
    }

}