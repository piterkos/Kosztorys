using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace Kosztorys
{
    public class Wydruk
    {
        Zamowienie Zamowienie;
        Graphics Dokument;
        PrintPageEventArgs Strona;

        int ZatrzymanoWydrukNaPomieszczeniuNr = 0;
        int ZatrzymanoWydrukNaUsludzeNr = 0;

        int polozenieWydruku = 10;
        int numerWykonanejUslugi = 1;


        const int prawyMargines = 827;
        const int dolnyMargines = 1169;

        bool czyPierwszaStrona = true;
        int NrStrony = 1;

        #region stałeTabeli
        const int pion1 = 24;
        const int pion2 = 305;
        const int pion3 = 345;
        const int pion4 = 385;
        const int pion5 = 425;
        const int pion6 = 492;
        const int pion7 = 559;
        const int pion8 = 626;
        const int wysokoscWiersza = 20;
        #endregion

        public Wydruk( Zamowienie _zamowienie)
        {
            this.Zamowienie = _zamowienie;
        }

        public void UtworzWydruk(PrintPageEventArgs _dokument)
        {
            this.Dokument = _dokument.Graphics;     // przekaż parametry do głównych zmiennych, aby dostęp do nich miała reszta metod
            this.Strona = _dokument;
            if(czyPierwszaStrona)
                UtworzNaglowekGlowny(this.Dokument);
            UtworzNaglowekTabeli(this.Dokument);

            // drukuj dane tabelaryczne wg pomieszczeń
            for (int i = ZatrzymanoWydrukNaPomieszczeniuNr; i < Zamowienie.Pomieszczenia.Count; i++)
            {
                DrukujTabeleDlaPomieszczenia(Zamowienie.Pomieszczenia[i], this.Dokument, this.Strona);
                if (polozenieWydruku > 1100 && numerWykonanejUslugi < Zamowienie.WykonaneUslugi.Count)
                {
                    if (ZatrzymanoWydrukNaUsludzeNr == 0)
                        ZatrzymanoWydrukNaPomieszczeniuNr++;
                    polozenieWydruku = 30;
                    Strona.HasMorePages = true;
                    break;
                }
                else
                {
                    ZatrzymanoWydrukNaPomieszczeniuNr++;
                    Strona.HasMorePages = false;
                }
            }
            if (numerWykonanejUslugi == Zamowienie.WykonaneUslugi.Count + NrStrony)
                DodajPodsumowanie();
            czyPierwszaStrona = false;
            NrStrony++;
        }

        private void DodajPodsumowanie()
        {
            using (Font czcionka = new Font("Arial", 10, FontStyle.Bold))
            {
                Dokument.DrawString("Razem: " + Zamowienie.SumaRazem(), czcionka, Brushes.Black, prawyMargines / 2, polozenieWydruku + 5);
            }
        }
        IEnumerable<WykonanaUsluga> daneZpomieszczenia;
        private void DrukujTabeleDlaPomieszczenia(string pomieszczenie, Graphics dokument, PrintPageEventArgs strona)
        {
            // ustal listę wykonanych usług dla danego pmieszczenia
            daneZpomieszczenia = Zamowienie.WykonaneUslugi.Where(w => w.Pomieszczenie == pomieszczenie).AsEnumerable();

            using (Font czcionka = new Font("Arial", 10, FontStyle.Regular))
            {
                if (daneZpomieszczenia.Count() != 0) // jeżeli lista usług wykonanych w pomieszczeniu jest większa od 0 to wykonaj...
                {
                    // z pierwszej pozycji wyciągnij nazwę pomieszczenia
                    string nazwaPomieszczenia = daneZpomieszczenia.First().Pomieszczenie;
                    // ustawia nazwę pomieszczenia nad tabelą z danymi dotyczącymi danego pomieszczenia
                    dokument.DrawString(nazwaPomieszczenia, czcionka, Brushes.Black,
                        prawyMargines / 2 - dokument.MeasureString(nazwaPomieszczenia, // sprawdza szerokość napisu w pikselach
                        czcionka).Width,
                        polozenieWydruku + 2); // ustaw na środku napis z nazwą pomieszczenia

                    polozenieWydruku += wysokoscWiersza; // zwiększ aktualne położenie wydruku
                    // dodaj poziomą linię pod nazwą pomieszczenia
                    dokument.DrawLine(Pens.Black, new Point(0, polozenieWydruku), new Point(prawyMargines, polozenieWydruku));
                    // wypisz wiersz prezentujący wykonaną usługę
                    for (int i = ZatrzymanoWydrukNaUsludzeNr; i < daneZpomieszczenia.Count(); i++)
                    {
                        dokument.DrawString(numerWykonanejUslugi.ToString(), czcionka, Brushes.Black, 3, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Opis, czcionka, Brushes.Black, pion1 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Długosc, czcionka, Brushes.Black, pion2 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Szerokosc, czcionka, Brushes.Black, pion3 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Wysokosc, czcionka, Brushes.Black, pion4 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Ilosc.ToString() + " " + daneZpomieszczenia.ElementAt(i).JednostkaMiary, czcionka, Brushes.Black, pion5 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Stawka.ToString("c"), czcionka, Brushes.Black, pion6 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Razem.ToString("c"), czcionka, Brushes.Black, pion7 + 2, polozenieWydruku + 2);
                        dokument.DrawString(daneZpomieszczenia.ElementAt(i).Uwagi, czcionka, Brushes.Black, pion8 + 2, polozenieWydruku + 2);
                        DodajWierszTabeli(this.Dokument); // dodaj obramowanie
                        polozenieWydruku += wysokoscWiersza; // zwiększ aktualne położenie wydruku
                        numerWykonanejUslugi++; // zwiększ o 1 ogólnym numer wykonanej usługi
                        if (polozenieWydruku > 1100)  // jeżeli położenie wydruku wyjdzie ponad 1100 to przerwij wykonywanie pętli w celu sprawdzenia istniejących pozycji i ewentualnego dodania następnej strony
                        {
                            if (daneZpomieszczenia.Count() == i)    // jeżeli liczba usług z danego pomieszczenia = aktualnej pozycjia wyliczenia
                                ZatrzymanoWydrukNaUsludzeNr = 0;    // to uznaj, że cała lista usłyg w danym pomieszczeniu została wydrukowana
                            else
                                ZatrzymanoWydrukNaUsludzeNr = i;    // jeżeli nie to zapamiętaj na której pozycji wydruk usług został zakończony
                            break;                                  // i zatrzymaj wykonywanie pętli w celu dodania nowej strony
                        }
                        else
                            ZatrzymanoWydrukNaUsludzeNr = 0;        // jeżeli pętla zakończy się a nie wykroczono poza graanicę wydruku to ustaw jakoby druk pomieszczenia został zakończony
                    }
                }
            }
        }

        private void DodajWierszTabeli(Graphics dokument)
        {
            dokument.DrawLine(Pens.Black, new Point(pion1, polozenieWydruku), new Point(pion1, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion2, polozenieWydruku), new Point(pion2, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion3, polozenieWydruku), new Point(pion3, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion4, polozenieWydruku), new Point(pion4, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion5, polozenieWydruku), new Point(pion5, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion6, polozenieWydruku), new Point(pion6, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion7, polozenieWydruku), new Point(pion7, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(pion8, polozenieWydruku), new Point(pion8, polozenieWydruku + wysokoscWiersza));
            dokument.DrawLine(Pens.Black, new Point(0, polozenieWydruku + wysokoscWiersza), new Point(prawyMargines, polozenieWydruku + wysokoscWiersza)); // rysuj dolną krawdędź wiersza
        }

        private void UtworzNaglowekGlowny(Graphics dokument)
        {
            // Dodaj napisy w odpowiednich miejscach
            using (Font czcionka = new Font("Arial", 10, FontStyle.Regular))
            {
                dokument.DrawString("KOSZTORYS PRAC WYKOŃCZENIOWYCH", czcionka, Brushes.Black, 3, polozenieWydruku-5);
                dokument.DrawString(Zamowienie.Klient, czcionka, Brushes.Black, 500, polozenieWydruku-5);
                polozenieWydruku += 20;
                dokument.DrawString("Nr...20.../.../.../2017r", czcionka, Brushes.Black, 3, polozenieWydruku);
                polozenieWydruku += 20;
            }
            // dodaj obramowanie a właściwie dwie linie
            dokument.DrawLine(Pens.Black, new Point(0, 27), new Point(prawyMargines, 27));
            dokument.DrawLine(Pens.Black, new Point(0, polozenieWydruku), new Point(prawyMargines, polozenieWydruku));
        }
        private void UtworzNaglowekTabeli(Graphics dokument)
        {
            using (Font czcionka = new Font("Arial", 10, FontStyle.Regular))
            {
                dokument.DrawString("Nr.", czcionka, Brushes.Black, pion1 / 2 - dokument.MeasureString("Nr.", czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Opis", czcionka, Brushes.Black, pion1 + (pion2-pion1)/2 - dokument.MeasureString("Opis", czcionka).Width / 2, polozenieWydruku);//165
                dokument.DrawString("Dł.", czcionka, Brushes.Black, pion2 + (pion3 - pion2) / 2 - dokument.MeasureString("Dł.",czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Sze.", czcionka, Brushes.Black, pion3 + (pion4 - pion3) / 2 - dokument.MeasureString("Sze.", czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Wys.", czcionka, Brushes.Black, pion4 + (pion5 - pion4) / 2 - dokument.MeasureString("Wys.", czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Ilość", czcionka, Brushes.Black, pion5 + (pion6 - pion5) / 2 - dokument.MeasureString("Ilość.", czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Stawka", czcionka, Brushes.Black, pion6 + (pion7 - pion6) / 2 - dokument.MeasureString("Stawka",czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Razem", czcionka, Brushes.Black, pion7 + (pion8 - pion7) / 2 - dokument.MeasureString("Razem", czcionka).Width / 2, polozenieWydruku);
                dokument.DrawString("Uwagi", czcionka, Brushes.Black, pion8 + (prawyMargines - pion7) / 2 - dokument.MeasureString("Uwagi", czcionka).Width / 2, polozenieWydruku);
            }
            dokument.DrawLines(Pens.Black, (new Point[] {
                                                            new Point(0,polozenieWydruku),
                                                            new Point(prawyMargines,polozenieWydruku),
                                                            new Point(prawyMargines,polozenieWydruku + wysokoscWiersza),
                                                            new Point(0,polozenieWydruku + wysokoscWiersza)
                                                        }));
            DodajWierszTabeli(dokument);
            polozenieWydruku += 20;
        }
        private void UstalLiczbeStron()
        {
            //TODO: Do dokończenia jest ustalenie liczby stron
            int liczbaStron = 1;
            //int naglowekGlowny = 50;
            //int naglowekTabeli = 20;
            int nazwaPomieszczenia = 20;
            int wykonanaUsluga = 20;
            int liczbaPomieszczen = daneZpomieszczenia.Count();
            int liczbaWykonanychUslug = Zamowienie.WykonaneUslugi.Count;
            int pierwszaStronaStałeJest = 70;
            //liczbaStron = pierwszaStronaStałeJest + liczbaPomieszczen*nazwaPomieszczenia + wykonanaUsluga * liczbaWykonanychUslug 
        }
    }
}