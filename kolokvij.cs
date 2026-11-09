namespace KOLOKVIJ
{
    internal class Program
    {

        //1) Naredite deklaracijo 4 različna tipa podatkov, ter jih ustrezno poimenujte in dodajte pravilne vrednosti. Vsako spremenljivko izpišite na zaslonu.​ The main entry point for the application.      

        static void Main(string[] args)
        {
            /* 
             int starost = 20;
             double visina = 1.75;
             string ime = "Domen Gazvoda";
             bool student = true;


             Console.WriteLine("Ime: " + ime);
             Console.WriteLine("Starost: " + starost);
             Console.WriteLine("Višina: " + visina);
             Console.WriteLine("Ali je študent: " + student);
            */
            //2) Naredite spremenljivko tipa double in dodajte ji vrednost ter prevedite v string in izpišite na zaslonu.​     

            /*
             double teza = 75.5;
             string tezaKotString = teza.ToString();
             Console.WriteLine("Teža: " + tezaKotString);    
         */
            //3) Na osnovi trenutne temperature izpišite ustrezen tekst na zaslonu. V primeru da je temperatura manjša kot 20 stopinj, izipišite “Mrzlo je”, v primeru da je temperatura  20 do 25 stopinj (vključno z 20 in 25) izpišite “V redu je temperatura” in v primeru več kot 25 naj izpiše “Prevroče”.​

            /* Console.Write("Vnesi temperaturo: ");

                 double temperatura;


                 if (double.TryParse(Console.ReadLine(), out temperatura))
                 {
                     if (temperatura < 20)
                     {
                         Console.WriteLine("Mrzlo za znort");
                     }
                     else if (temperatura >= 20 && temperatura <= 25)
                     {
                         Console.WriteLine("Normalna temperatura");
                     }
                     else
                     {
                         Console.WriteLine("Vroče za znort");
                     }
                 }
                 else
                 {
                     Console.WriteLine("Zajebal si. Prav vpiši število in ne ostalo");
                 }

                 Console.ReadLine();
            */

            //4) Narediti IF ELSE zanko.​  Izpisati je potrebno sporočilo na osnovi dobijene vrednosti:​če je vrednost deljiva s 3, izpišete deljivo s 3.​ če ni s tri, ampak je s 7, napišete deljivo s 7.​ vsakem drugem primeru naj izpiše sodo število če je, če pa ni naj izpiše številka je liha.​



            /*
            
            {
                int stevilo;

                Console.Write("Vnesi poljubno celo število: ");

                if (int.TryParse(Console.ReadLine(), out stevilo))
                {
                    if (stevilo % 3 == 0 && stevilo % 7 == 0)
                    {
                        Console.WriteLine("Število je deljivo s 7 in 3.");
                    }
                    else if (stevilo % 3 == 0)
                    {
                        Console.WriteLine("Število je deljivo s 3.");
                    }
                    else if (stevilo % 7 == 0)
                    {
                        Console.WriteLine("Število je deljivo s 7.");
                    }
                    else if (stevilo % 2 == 0)
                    {
                        Console.WriteLine("Število je sodo.");
                    }
                    else
                    {
                        Console.WriteLine("Številka je liha.");
                    }
                }
                else
                {
                    Console.WriteLine("Napaka! Vnesi celo število.");
                }

                Console.ReadLine();
            }
            */
            //5) Predstavljajte si, da ste razvijalec in dobite službo, v kateri morate ustvariti program za učitelja. Potrebuje program, napisan v C#, ki izračuna povprečno oceno njegovih študentov. Zato želi imeti možnost vnesti vsako oceno posebej in nato dobiti končno povprečno oceno, ko vnese -1.​Orodje mora torej preveriti, ali je vnos številka, in to dodati vsoti.Končno, ko konča z vnosom rezultatov, mora program na konzolo zapisati, kakšna je povprečna ocena.​Vnesena števila naj bodo samo med 5 in 10.Prepričajte se, da se program ne zruši, če učitelj vnese napačno vrednost.​Temeljito preizkusite svoj program.​
            
            {
                int ocena;
                int vsota = 0;
                int steviloOcen = 0;

                while (true)
                {
                    Console.Write("Vnesi oceno (od 5 do 10) ali -1 za konec: ");

                    
                    if (int.TryParse(Console.ReadLine(), out ocena))
                    {
                       
                        if (ocena == -1)
                        {
                            break;
                        }

                       
                        if (ocena >= 5 && ocena <= 10)
                        {
                            vsota = vsota + ocena;
                            steviloOcen++;

                            Console.WriteLine("Ocena je uspešno dodana.");
                        }
                        else
                        {
                            Console.WriteLine("Napaka! Ocena mora biti celo število med 5 in 10.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Napaka! Vnesi samo celo število.");
                    }
                }

                
                if (steviloOcen > 0)
                {
                    double povprecje = (double)vsota / steviloOcen;

                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Število vnesenih ocen: " + steviloOcen);
                    Console.WriteLine("Vsota ocen: " + vsota);
                    Console.WriteLine("Povprečna ocena: " + povprecje);
                }
                else
                {
                    Console.WriteLine("Nobena veljavna ocena ni bila vnesena.");
                }

                Console.WriteLine("Program je zaključen.");
                Console.ReadLine();
            }
        }



    }
}
















