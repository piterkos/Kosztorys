using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace Kosztorys
{
    class Wydruk
    {
        Zamowienie Zamowienie;
        Graphics Dokument;

        int prawyMargines = 826;
        int dolnyMargines = 1169;

        #region stałeTabeli
        const int pion1 = 24;
        const int pion2 = 320;
        const int pion3 = 344;
        const int pion4 = 377;
        const int pion5 = 415;
        const int pion6 = 478;
        const int pion7 = 541;
        const int pion8 = 625;
        const int wysokoscWiersza = 20;
        const int punktStartowyTabeli = 48;
        #endregion

        public Wydruk(Graphics _dokument, Zamowienie _zamowienie)
        {
            this.Zamowienie = _zamowienie;
            this.Dokument = _dokument;
        }

        public void UtworzWydruk()
        {
            UtworzNaglowek();
            for (int i = punktStartowyTabeli; i < 1800; i = i + wysokoscWiersza)
            {
                DodajWierszTabeli(i);
            }
        }

        private void DodajWierszTabeli(int punktStartowyWiersza)
        {
            Dokument.DrawLine(Pens.Black, new Point(pion1, punktStartowyWiersza), new Point(pion1, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion2, punktStartowyWiersza), new Point(pion2, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion3, punktStartowyWiersza), new Point(pion3, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion4, punktStartowyWiersza), new Point(pion4, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion5, punktStartowyWiersza), new Point(pion5, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion6, punktStartowyWiersza), new Point(pion6, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion7, punktStartowyWiersza), new Point(pion7, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(pion8, punktStartowyWiersza), new Point(pion8, punktStartowyWiersza + 20));
            Dokument.DrawLine(Pens.Black, new Point(0, punktStartowyWiersza + 20), new Point(827, punktStartowyWiersza + 20));
        }

        private void UtworzNaglowek()
        {
            using (Font czcionka = new Font("Arial", 10, FontStyle.Regular))
            {
                Dokument.DrawString("KOSZTORYS PRAC WYKOŃCZENIOWYCH", czcionka, Brushes.Black, 3, 10);
                Dokument.DrawString(Zamowienie.Klient, czcionka, Brushes.Black, 500, 10);
                Dokument.DrawString("Nr...20.../.../.../2017r", czcionka, Brushes.Black, 3, 30);
                Dokument.DrawString("Nr.", czcionka, Brushes.Black, 3, 50);
                Dokument.DrawString("Opis", czcionka, Brushes.Black, 165, 50);
                Dokument.DrawString("Dł.", czcionka, Brushes.Black, 323, 50);
                Dokument.DrawString("Sze.", czcionka, Brushes.Black, 347, 50);
                Dokument.DrawString("Wys.", czcionka, Brushes.Black, 380, 50);
                Dokument.DrawString("Ilość", czcionka, Brushes.Black, 428, 50);
                Dokument.DrawString("Stawka", czcionka, Brushes.Black, 484, 50);
                Dokument.DrawString("Razem", czcionka, Brushes.Black, 557, 50);
                Dokument.DrawString("Uwagi", czcionka, Brushes.Black, 700, 50);
            }

            Dokument.DrawLine(Pens.Black, new Point(0, 27), new Point(826, 27));
            Dokument.DrawLine(Pens.Black, new Point(0, 48), new Point(827, 48));
            Dokument.DrawLines(Pens.Black, (new Point[] {
                                                            new Point(0,48),
                                                            new Point(prawyMargines,48),
                                                            new Point(prawyMargines,68),
                                                            new Point(0,68)
                                                        }));
        }
    }
}
