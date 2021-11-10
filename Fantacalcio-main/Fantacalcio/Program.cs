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
        int punteggiog;//punteggio del giocatore
        int[] classifica;//array che contiene la calssifica dei fantaallenatori
        double punteggiof;//punteggio del fantaallenatore
        int golfanta;//gol del fantallenatore
        double punteggios;//punteggio della squadra


        //giocatori
        int turno;
        int tmp;

        string n = "";
        string r = "";
        string s = "";

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
        int rigoreparato;

        //costruttore
        public Fantaallenatore()
        {
            //iniziallizzo variabili
            punteggiog = 0;
            punteggiof = 0;
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
            rigoreparato = 3;
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
        public double calcoloPunti(double media,int assists,int autogol,int rigorisbagliati,int rigoripresi,int golpresi,int portierimbattuti,int golf,double gialli,int rossi,int rigore,int rigoriparati)//metodo che calcola media con bonus e malus
        {
            golf = golf*gol;
            assists = assists * assist;
            gialli = gialli*giallo;
            rossi = rossi*rosso;
            rigore = rigore*rigoresegnato;
            rigorisbagliati = rigorisbagliati * rigoresbagliato;
            autogol = autogol * autorete;
            rigoriparati = rigoriparati * rigoreparato;
            golpresi = golpresi * golpreso;
            rigoripresi = rigoripresi * rigorepreso;
            portierimbattuti = portierimbattuti * portiereimbattuto;
            media = media+golf+gialli+rossi+rigore+rigoriparati+portierimbattuti+golpresi+rigorisbagliati+autogol+rigoripresi;
            punteggiof = media;
            return punteggiof;
        } 

        //Questo metodo sovrascrive i dati dei claciatori su ogni file

        public void salvaCalciatori()
        {
           
                n = Console.ReadLine();
           
            // Apre il file per scriverci.
            using (StreamWriter sw = new StreamWriter($"{mainPath}\\squadre\\{fantaallenatore}"))
                {//Scrive una riga di testo
                    sw.WriteLine(n);
                }

           
        }

        public void salvaRuolo()
        {
            r = Console.ReadLine();


            using (StreamWriter sw = new StreamWriter($"{mainPath}\\squadre\\{fantaallenatore}"))
            {//Scrive una riga di testo
                sw.WriteLine(r);
            }
        }

        public void salvaSquadra()
        {
            s = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter($"{mainPath}\\squadre\\{fantaallenatore}"))
            {//Scrive una riga di testo
                sw.WriteLine(s);
            }

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


    //Classe calciatore
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
                int decisione=Convert.ToInt32(Console.ReadLine());



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
                            Console.WriteLine("Ottimo puoi continuare la tua partita");
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
                            Console.WriteLine("La tua scelta non corrisponde a nessuna possibilità");
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
                    f.salvaSquadra();
                    Console.WriteLine("Inserisci ruolo");
                    f.salvaRuolo();
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
                    d.salvaSquadra();
                    Console.WriteLine("Inserisci ruolo");
                    //c.setCalciatoreruolo();
                    d.salvaRuolo();




                }


            }


            //INIZIA IL CAMPIONATO
            double punti=0;
            double punti1=0;


            //Varaibili primo fantaallenatore
            double mediac;
            double medias=0;
            int gol;
            int assists;
            int golpresi;
            double gialli;
            int rossi;
            int rigore;
            int rigoriparati;
            int rigoripresi;
            int rigorisbagliati;
            int autogol;
            int portiereimbattuto;

            //variabili secondo fantaallenatore
            double mediac1 ;
            double medias1 = 0;
            int gol1 ;
            int assists1;
            int golpresi1;
            double gialli1 ;
            int rossi1 ;
            int rigore1 ;
            int rigoriparati1 ;
            int rigoripresi1;
            int rigorisbagliati1;
            int autogol1;
            int portiereimbattuto1;


            Console.WriteLine("Bene ora che le squadre sono al completo può avere inizio il fantacalcio");
            Console.WriteLine("Il campionato è formato da 10 giornate e la prima parte adesso");

            for(int i = 0; i <= 10; i++)//campionato da 10 giornate
            {
                //primo
                Console.WriteLine(allenatore1 + "Inserisci i dati della tua squadra relativi alla {0} giornata",i);//il fantaallenatore inserirà tutti i dati riguardanti bonus e malus
                for (int p = 0; p <= 11; p++)//ciclo che calcola la media della squadra in base alle medie dei singoli calciatori
                {
                    Console.WriteLine("Inserisci la media del {0} calciatore", p);

                    mediac = Convert.ToDouble(Console.ReadLine());

                    medias = medias + mediac;

                }
                Console.WriteLine("Inserisci i gol fatti dai tuoi giocatori");
                gol = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero assist fatti dai tuoi giocatori  ");
                assists = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i gialli presi dai tuoi giocatori");
                gialli = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i rossi presi dai tuoi giocatori");
                rossi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i rigori segnati");
                rigore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di portieri imbattuti  ");
                rigorisbagliati = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di autogol fatti  ");
                autogol = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i rigori parati ");
                rigoriparati = Convert.ToInt32(Console.ReadLine());
                /* for(int v = 0; v == 0; v++)
                 {
                     Console.WriteLine("Il tuo portiere è imbattuto? ");
                     string risposta = Console.ReadLine();
                     if (risposta == "si")
                     {
                         portiereimbattuto = 1;
                     }
                     else if (risposta == "no")
                     {
                         portiereimbattuto = 0;
                     }
                     else
                     {
                         Console.WriteLine("Non ho capito potresti ripetere?");
                         v--;
                     }
                 }*/
                Console.WriteLine("Inserisci il numero di portieri imbattuti ");
                portiereimbattuto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i gol presi dal portiere ");
                golpresi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di rigori non parati dal portiere ");
                rigoripresi = Convert.ToInt32(Console.ReadLine());

                medias = f.calcoloPunti(medias,assists,autogol,rigorisbagliati,rigoripresi,golpresi,portiereimbattuto,gol, gialli,rossi, rigore, rigoriparati);
                punti = punti + medias;

                //secondo
                Console.WriteLine(allenatore2 + "Inserisci i dati della tua squadra relativi alla {0} giornata", i);//il fantaallenatore inserirà tutti i dati riguardanti bonus e malus
                for (int p = 0; p <= 11; p++)//ciclo che calcola la media della squadra in base alle medie dei singoli calciatori
                {
                    Console.WriteLine("Inserisci la media del {0} calciatore", p);

                    mediac1 = Convert.ToDouble(Console.ReadLine());

                    medias1 = medias1 + mediac1;

                }
                Console.WriteLine("Inserisci i gol fatti ");
                gol1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di assist fatti dai tuoi giocatori");
                assists1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i gialli presi dai tuoi giocatori");
                gialli1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i rossi presi dai tuoi giocatori");
                rossi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i rigori segnati");
                rigore1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci i rigori parati ");
                Console.WriteLine("Inserisci il numero di portieri imbattuti  ");
                rigorisbagliati1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di autogol fatti  ");
                autogol1 = Convert.ToInt32(Console.ReadLine());
                rigoriparati1 = Convert.ToInt32(Console.ReadLine());
                /*for (int v = 0; v == 0; v++)
                {
                    Console.WriteLine("Il tuo portiere è imbattuto? ");
                    string risposta = Console.ReadLine();
                    if (risposta == "si")
                    {
                        portiereimbattuto1 = 1;
                    }
                    else if (risposta == "no")
                    {
                        portiereimbattuto1 = 0;
                    }
                    else
                    {
                        Console.WriteLine("Non ho capito potresti ripetere?");
                        v--;
                    }
                }*/
                Console.WriteLine("Inserisci il numero di portieri imbattuti  ");
                portiereimbattuto1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di gol presi dal portiere ");
                golpresi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di rigori non parati dal portiere ");
                rigoripresi1 = Convert.ToInt32(Console.ReadLine());
                medias1 = d.calcoloPunti(medias1,assists1,autogol1,rigorisbagliati1,rigoripresi1,golpresi1,portiereimbattuto1, gol1, gialli1, rossi1, rigore1, rigoriparati1);
                punti1 = punti1 + medias1;
            }

            //DECRETO VINCITORE
            Console.WriteLine("Il vincitore di questo fantacalcio è.....");
            if (punti < punti1)
            {
                Console.WriteLine(allenatore2+"con {0} punti",punti1);
            }else if (punti > punti1)
            {
                Console.WriteLine(allenatore1 + "con {0} punti", punti);
            }
            else
            {
                Console.WriteLine("Nessuno perhè si tratta di un pareggio, il campionato è finito: {0} a {1} punti.COMPLIMENTI AD ENTRAMBI I GIOCATORI",punti,punti1);
            }

            Console.ReadKey();//a fine Main per la lettura 
        }
        
    }

}