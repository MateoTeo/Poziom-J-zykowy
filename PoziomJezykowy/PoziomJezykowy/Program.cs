using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoziomJezykowy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Główne Informacje
            Console.WriteLine("Program służy do sprawdzenia na jakim poziomie językowym znajduje sie użytkownik.\n" +
                                  "Wyróżnia się sześć poziomów biegłości języka A1-C2, gdzie do każdego poziomu jest " +
                                  "przypisana szacowana ilość słów: \n \n" +
                                  "A1-550 \nA2-1100 \nB1-2200 \nB2-4400 \nC1-8800 \nC2-17600 \n\n");
            #endregion

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = Path.Combine(path, "Language_Profinency_Levels.txt");


            #region Dodawanie słówek
            AddArrayList addThing = new AddArrayList();
            Console.WriteLine("Podaj słowo po angielsku");
            string word = Console.ReadLine();
            addThing.Add_Word(word);

            Console.WriteLine("Podaj słowo po polsku");
            string definition = Console.ReadLine();
            addThing.Add_Definition(definition);


            #endregion


            #region Tworzenie dokumentu oraz dodwanie do listy 
            //Tworzenie Dokumentu 
            if (File.Exists(file))
            {
                //Console.WriteLine(File.ReadAllText(file));
            }
            else
            {
                File.WriteAllText(file, "LISTA SŁÓWEK \n" + Environment.NewLine);
            }

            //Dodawanie słówek
            if (File.Exists(file))
            {
                File.AppendAllText(file, word + " - " + definition + Environment.NewLine);
            }
            #endregion


            #region Wyświetlanie listy + ilość znanych słów 
            //Pokazywanie Listy słówek
            Console.WriteLine("Czy chcesz zobaczyć liste słówek? (tak/nie)");
            string question = Console.ReadLine();
            if (question == "tak")
            {
                #region Zliczanie ilości słów
                Console.Clear();
                Console.WriteLine(File.ReadAllText(file));
                var lineCount = File.ReadLines(@"C:\Users\ACER\Desktop\Language_Profinency_Levels.txt").Count();

                if (lineCount > 0)
                {
                    Console.WriteLine("Znajomość słów: {0}", lineCount - 1);
                }
                else
                {
                    Console.WriteLine("Brak znanych słów");
                }
                #endregion

                #region Poziom językowy
                if (lineCount < 550)
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: A0");
                }
                else if (lineCount >= 550 && lineCount < 1100)
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: A1");
                }
                else if (lineCount >= 1100 && lineCount < 2200)
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: A2");
                }
                else if (lineCount >= 2200 && lineCount < 4400)
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: B1");
                }
                else if (lineCount >= 4400 && lineCount < 8800)
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: B2");
                }
                else if (lineCount >= 8800 && lineCount < 17600)
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: C1");
                }
                else
                {
                    Console.WriteLine("Twój poziom językowy obecnie to: C2");
                } 
                #endregion

            }       
            else
            {

            }
            #endregion


            Console.ReadLine();
        }
        
    }
}
