using System;
using System.IO;

namespace Fantacalcio
{

    //Classe Fantallenatore
    class Fantaallenatore
    {
        //creatore file per fantaallenatori
        private static string mainPath = Environment.CurrentDirectory;
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


        //giocatori
        int turno;
        int tmp;

        string q = "";

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
        public Fantaallenatore()
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
            turno = 0;
            tmp = 0;

        }

        //metodi

        //metodo che fa inserire il nome del gicoatore e ne crea il file
        public string setFantaallenatore()
        {
            
                fantaallenatore = Console.ReadLine();
                using (StreamWriter a = File.CreateText($"{mainPath}\\squadre\\{fantaallenatore}")) { }
                return fantaallenatore;
           
            
        }

        //Questo metodo sovrascrive i dati dei claciatori su ogni file

        public void salvaCalciatori()
        {
            
            for(int i = 0; i == 0; i++)
            {
                q = Console.ReadLine();
                // Apre il file per scriverci.
                using (StreamWriter sw = new StreamWriter($"{mainPath}\\squadre\\{fantaallenatore}"))
                {//Write a line of text
                    sw.WriteLine(q);
                }
              
                
            }

            q = "";
            


        }

        //questo metodo serve a ritornare il nome scelto dal giocatore per salvarlo nel Main
        public string settaNome()
        {
            return fantaallenatore;
        }

        //questo metodo serve a capire di chi è il turno 
        public bool setTurno()
        {
            if (turno == 0)
            {
                turno++;
                return true;

            }
            else
            {
                turno--;
                return false;
                
            }
            
        }


    }


    //Classe calciatorrrrrrrr
    class Calciatore
    {
        //attributi
        string nome;
        string squadra;
        string ruolo;

        //creatore
        public Calciatore(string n,string s,string r)
        {
            this.nome = n;
            this.squadra = s;
            this.ruolo = r;
        }

        //Fa inserire il nome del calciatore scelto
        public void setCalciatorenome()
        {
            nome = Console.ReadLine();
           
        }

        //Fa inserire la squadra del calciatore scelto
        public void setCalciatoresquadra()
        {
            squadra = Console.ReadLine();
           
        }

        //Fa inserire il ruolo del calciatore scelto
        public void setCalciatoreruolo()
        {
            ruolo = Console.ReadLine();
        }

        //controlla se il calciatore scelto esiste
        public void controlloGiocatore()
        {


        }


    }

    //Class Programm
    class Program
    {
        private static string mainPath = Environment.CurrentDirectory;
        static void Main(string[] args)
        {

            

            //creo i nomi dei giocatori
            string allenatore1="";
            string allenatore2="";
            //creo le stringhe utili a richiamare la classe calciatore
            string n, s, r;
            n = "";
            s = "";
            r = "";
            //creo un istanza della classe Fantaallenatore per il primo giocatore
            Fantaallenatore f = new Fantaallenatore();
            //creo un istanza della classe Fantaallenatore per il secondo giocatore
            Fantaallenatore d = new Fantaallenatore();
            //creo un istanza della classe Calciatore
            Calciatore c = new Calciatore(n,s,r);
           
            //variabile utile per il ciclo while
            int t=0;

            while (t==0)
             {
                //Il giocatore ora dovrà scegliere cosa fare attraverso un apposito menù
                Console.WriteLine("Digita 1 se vuoi creare nuova partita,");
                Console.WriteLine("Digita 2 se vuoi entrare in partita già esistente,");
                Console.WriteLine("Digita 3 se vuoi eliminare una partita già esistente.");
                //l'utente sceglie cosa vuole fare digitando il tasto che corrisponde alla sua scelta
                int decisione = int.Parse(Console.ReadLine());



                if (decisione == 1)
                {
                    if (!Directory.Exists(mainPath + "\\squadre"))//se non esiste alcuna cartella la prima volta che viene aperto il programma la creo
                    {
                       
                        for (int i = 0; i == 0; i++)
                        {
                            DirectoryInfo creaCartella = Directory.CreateDirectory(mainPath + "\\squadre");

                            Console.WriteLine("Inserisci nome del fantallenatore1");
                            f.setFantaallenatore();
                            allenatore1 = f.settaNome();
                      
                            Console.WriteLine("Inserisci nome del fantallenatore2");
                            d.setFantaallenatore();
                            allenatore2 = d.settaNome();

                            if (allenatore2 == allenatore1)
                            {
                                Console.WriteLine("Mi spiace ma questo nome è già in uso al momento");
                                Directory.Delete(mainPath + "\\squadre", true);
                                i--;
                            }
                            else//se va tutto bene
                            {
                                Console.WriteLine("Ottimo i nomi sono stati inseriti in modo a dir poco perfecto");
                            }
                        }
                        
                        
                    }
                    else//se esiste già la cartella non può essere creata
                    {
                        Console.WriteLine("NOOOOOON PUOIIIII SonO gIAs stati Creatiiiiiiiiiiii!!!!");
                    }

                }
                else
                {
                    if (decisione == 2)
                    {
                        if (Directory.Exists(mainPath + "\\squadre"))//se la cartella esiste
                        {
                            Console.WriteLine("Ottimo puoi continuare a vivere la tua vita come nulla fosse");
                            allenatore1 = f.settaNome();
                            allenatore2 = d.settaNome();
                            t++;
                        }
                        else//se la cartella non esiste
                        {
                            Console.WriteLine("Mi spiace doverti avvertire che la partita da lei cercata al momento non è raggiungibile, riprova più tardi dopo averla creata grazie");
                        }
                    }
                    else
                    {
                        if (decisione == 3)
                        {
                            string elimina = "";
                            if (Directory.Exists(mainPath +"\\squadre"))//se la cartella esiste
                            {


                                //creo un ciclo che controlli la scelta del giocatore se vuole eliminare o meno il file
                                for (int i = 0; i == 0; i++)
                                {
                                    Console.WriteLine("Sei sicuro di voler eliminare la partita esistemnte?Digita si o no");
                                    elimina = Console.ReadLine();


                                    if (elimina == "si")
                                    {
                                        Directory.Delete(mainPath + "\\squadre", true);

                                    }
                                    else if (elimina == "no")
                                    {
                                        t = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Mi spiace non ho capito la tua scelta");
                                        i--;
                                    }

                                }
                            }
                            else//se la cartella non esiste
                            {
                                Console.WriteLine("Mi spiace ma non puoi eliminare proprio un bel niente");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ma che straca**o vuoi fare?????");
                        }
                    }
                }
            }

            Console.WriteLine("Inizia l'asta!!!!!!!!");
            Console.WriteLine("Adesso dovrete proporre i vostri calciatori");

            //INIZIA ASTA che chiede nome squadra e ruolo di ogni calciatore
            for (int i = 0; i <= 22; i++)
            {
                if (f.setTurno() == true)//scelgo il turno
                {
                    Console.WriteLine(allenatore1+ " tocca a te!!!!");

                    Console.WriteLine("Inserisci nome");
                    //c.setCalciatorenome();
                    f.salvaCalciatori();
                    Console.WriteLine("Inserisci squadra");
                    //c.setCalciatoresquadra();
                    f.salvaCalciatori();
                    Console.WriteLine("Inserisci ruolo");
                    //c.setCalciatoreruolo();

                }
                else
                {
                    Console.WriteLine(allenatore2+ "tocca a te!!!!");

                    Console.WriteLine("Inserisci nome");
                    //c.setCalciatorenome();
                    d.salvaCalciatori();
                    Console.WriteLine("Inserisci squadra");
                    //c.setCalciatoresquadra();
                    d.salvaCalciatori();
                    Console.WriteLine("Inserisci ruolo");
                    //c.setCalciatoreruolo();
                    d.salvaCalciatori();




                }


            }


            //INIZIA IL CAMPIONATO

            Console.WriteLine("Bene ora che le squadre sono al completo può avere inizio il fantacalcio");
            Console.WriteLine("Il campionato è formato da 10 giornate e la prima parte adesso");

            for(int i = 0; i <= 10; i++)
            {

            }

        }
        
    }

}