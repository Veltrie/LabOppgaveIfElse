using System;

namespace LabOppgaveIfElse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool res;
            res = false;
            int tallet;
            string verdi = "";

            Console.WriteLine("Tast inn alderen din.");
            while (res == false)
            {
                verdi = Console.ReadLine();

                res = int.TryParse(verdi, out tallet);

                if (res == true)
                    Console.WriteLine(tallet);
                else
                    Console.WriteLine("Feil input, skriv alderen din med tall.");
            }

            Console.ReadLine();
            //dette betyr: Hvis alder er større enn 17, så skriv ut gammel nok
            //(else)hvis ikke, så skriv ikke gammel nok
            //en if er true eller false
            //Hvordan lese inn noe fra konsoll? eksempel under

            //oppgave 1
            //Sånn, da har vi nok av kodeeksempler til å lage noe selv. Oppgaven kommer under her.
            //Lever koden på Teams. Lykke til.
            //De to første linjene er ferdige. Vi leser inn en temperatur.
            //Du skal lage en "if/else" som i eksempelet over.
            //Hvis temperatur er under null, skriv ut "minusgrader". Hvis ikke (else), skriv ut "varmegrader".

            //din if/else her

            //oppgave 2
            //Lik oppgaven over, men denne gangen skal du lage en metode, og kalle denne.
            //Så vi leser inn som over, kaller metoden, som har parameter/argument. Dette parameteret er temperaturen.
            //Metoden skal ikke returnere noe.
        }
    }
}