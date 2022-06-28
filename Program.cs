using System;

namespace Ex._1.Magazin_Laborator8_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieți un program care va modela un magazin de electronice. Magazinul de electronice va avea afișate
             televizoare, telefoane, becuri inteligente precum si sisteme audio. Când clientul va intra in magazin,
             becurile se vor aprinde, televizoarele vor porni pe un program cu muzică iar telefoanele își vor debloca
             automat ecranul. Clientul va putea cumpăra produse de la casă iar aceasta va calcula automat veniturile.
             La plecarea clientului, becurile se vor stinge, televizoarele se vor opri iar telefoanele isi vor bloca
             ecranul.


            Suplimentar

             Telefonul
             • Va avea o metodă ”deblochează” care va primi ca parametru o parola
                    o Telefonul va fi deblocat doar dacă parola este corectă sau dacă încă nu a fost setată
                    (empty string)
             • Va avea o metodă de schimbare a parolei care va primi doi parametrii, parola veche și parola
             nouă
                    o Parola va fi schimbată doar dacă parola veche este corectă
                    o Va afișa in consola dacă parola a fost sau nu schimbată cu succes
             • Va persista starea telefonului (blocat/deblocat)
             • Va expune o metodă ”apelează”
                    o va primi ca parametru un număr de telefon
                    o va efectua apelul doar dacă telefonul este deblocat

            Magazinul
         • Va avea o parolă pe care o va seta automat telefoanelor atunci când un telefon nou va intra în
         stoc
         • Va oferi o metodă de schimbare a parolei (aceeași regulă ca la schimbarea parolei telefonului) la
         apelul căreia, dacă parola veche este corectă, va schimba parola tuturor telefoanelor aflate în
         stoc
         • La vânzarea unui telefon, parola acestuia va fi resetată pe valoarea inițiala (empty string) astfel
         încât cumpărătorul să își poată seta propria parolă
             */

            Magazin magazin = new Magazin();

            Bec bec = new Bec();

            Telefon telefoniPhone10 = new Telefon(ProducatorTelefon.iPhone, ModelTelefon.x10);
            Telefon telefonNokia3310 = new Telefon(ProducatorTelefon.Nokia, ModelTelefon.n3310);
            Telefon telefonOneplusN10 = new Telefon(ProducatorTelefon.OnePlus, ModelTelefon.N10);
            Telefon telefonSamsungS10 = new Telefon(ProducatorTelefon.Samsung, ModelTelefon.S10);

            TV tvSamsungSA55 = new TV(ProducatorTV.Samsung, ModelTV.SA55);
            TV tvLG30 = new TV(ProducatorTV.LG, ModelTV.LG30);
            TV tvnei45 = new TV(ProducatorTV.Nei, ModelTV.N45);
            TV tvphilipsPH35 = new TV(ProducatorTV.Philips, ModelTV.PH35);


            magazin.AdaugareBec(bec);
            magazin.AdaugareBec(bec);
            magazin.AdaugareBec(bec);
            magazin.AdaugareBec(bec);
            magazin.AdaugareBec(bec);


            Telefon telefonSamsungTest = new Telefon(ProducatorTelefon.Samsung, ModelTelefon.S10);
            telefonSamsungTest.SchimbaParola("0000", "1234");
            telefonSamsungTest.Deblocheaza("4343");
            telefonSamsungTest.Apelare("0722222222");
            telefonSamsungTest.Deblocheaza("1234");
            telefonSamsungTest.Apelare("0722222222");

            magazin.AdaugareTelefon(telefonSamsungTest);




            magazin.AdaugareTelefon(telefonOneplusN10);
            magazin.AdaugareTelefon(telefonNokia3310);
            magazin.AdaugareTelefon(telefonNokia3310);
            magazin.AdaugareTelefon(telefonNokia3310);
            magazin.AdaugareTelefon(telefoniPhone10);
            magazin.AdaugareTelefon(telefoniPhone10);
            magazin.AdaugareTelefon(telefonSamsungS10);
            magazin.AdaugareTelefon(telefonSamsungS10);

            magazin.AdaugareTV(tvSamsungSA55);
            magazin.AdaugareTV(tvLG30);
            magazin.AdaugareTV(tvnei45);
            magazin.AdaugareTV(tvphilipsPH35);
            magazin.AdaugareTV(tvLG30);
            magazin.AdaugareTV(tvSamsungSA55);



            magazin.ClientIntra();
            magazin.SchimbareParolaMagazin("0000", "9999");
            Console.WriteLine("Vindeti bec(1), TV(2) sau telefon(3)?\n" +
                    "Tastati numarul corespunzator produsului dorit:");
            int raspuns = int.Parse(Console.ReadLine());
            while (raspuns < 1 || raspuns > 3)
            {
                Console.WriteLine("Input gresit!");
                raspuns = int.Parse(Console.ReadLine());
            }
            switch (raspuns)
            {
                case 1:
                    magazin.VanzareBecuri(magazin);
                    break;
                case 2:
                    magazin.VanzareTV(magazin);
                    break;
                default:
                    magazin.VanzareTelefon(magazin);
                    break;
            }
            magazin.ClientIese();

        }
    }
}
