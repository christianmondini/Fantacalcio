using System;

namespace Fantacalcio
{
    class Fantacalcio
    {

        //attributi
        string fantaallenatore;
        string calciatore;
        string squadra;
        int crediti;//crediti del fantaallenatore
        double punteggiog;//punteggio del giocatore
        int []classifica;//array che contiene la calssifica dei fantaallenatori
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
            giallo= -0.5;
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

       
        static void Main(string[] args)
        {
            Fantacalcio f = new Fantacalcio();

            Console.WriteLine("Inserisci nome del giocatore");
            f.setFantaallenatore();
            
            x
    }
}
