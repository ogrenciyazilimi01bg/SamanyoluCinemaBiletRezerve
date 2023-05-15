using Samanyolu_Cinema_Bilet_Rezerve;
using SamanyoluCinemaBiletRezerve;


namespace SamanyoluCinemaBiletRezerve
{
    class GirisEkrani
    {
        
        public static string FilmAdiK;
        public static string tarihY;
        public static string tarihM;
        public static string tarihD;
        public static int biletAdeti;
        public static int FilmNumarası;
        public static string KoltukNo;
        static void Main(string[] agrs)
        {
            
            string ProgramaGirisTarihi = ("Tarih :" + DateTime.Now);
            Console.WriteLine("                               * Samanyolu Cinemasına HOŞGELDİNİZ *           " + ProgramaGirisTarihi);
            Console.WriteLine("        Aşağıdaki filmlerden birini Seçiniz.");
            Console.WriteLine("");

            var FilmSuresiK =0;
            var FilmSaatiK = "";
            var SalonAdiK = "";
            
            
            Film Film1 = new Film();
            Film1.filmAdi = "   JOHN WICK 4             ";
            Film1.filmTuru = "           Türü:Aksiyon   ";
            Film1.filmSuresi = 169;
            Film1.filmYonetmeni = "Yönetmen: Chad Stahelski ";

            Film Film2 = new Film();
            Film2.filmAdi = "   SÜPER MARİO KARDEŞLER        ";
            Film2.filmTuru = "      Türü:Animasyon   ";
            Film2.filmSuresi = 92;
            Film2.filmYonetmeni = "Yönetmen: Michael Jelenic ";

            Film Film3 = new Film();
            Film3.filmAdi = "   HAVA MUHALEFETİ      ";
            Film3.filmTuru = "              Türü:Komedi  ";
            Film3.filmSuresi = 105;
            Film3.filmYonetmeni = "Yönetmen: Murat Kepez ";



            Salon Salon1 = new Salon();
            Salon1.salonAdi = "Salon Adı: Merkür       ";
            Salon1.salonKapasitesi = 50;

            Salon Salon2 = new Salon();
            Salon2.salonAdi = "Salon Adı: Venüs      ";
            Salon2.salonKapasitesi = 50;

            Salon Salon3 = new Salon();
            Salon3.salonAdi = "Salon Adı: Dünya      ";
            Salon3.salonKapasitesi = 50;



            Seans Seans1 = new Seans();
            Seans1.tarih = DateTime.Now;
            Seans1.seansZamanı = "  11:00";
            Seans1.Film = (Film1);
            Seans1.Salon = (Salon1);

            Seans Seans2 = new Seans();
            Seans2.seansZamanı = "  14:30";
            Seans2.Film = (Film1);
            Seans2.Salon = (Salon1);

            Seans Seans3 = new Seans();
            Seans3.seansZamanı = "  18:00";
            Seans3.Film = (Film1);
            Seans3.Salon = (Salon1);

            Seans Seans4 = new Seans();
            Seans4.seansZamanı = " 21:30  ";
            Seans4.Film = (Film1);
            Seans4.Salon = (Salon1);

            Seans Seans5 = new Seans();
            Seans5.seansZamanı = "  11:00";
            Seans5.Film = (Film2);
            Seans5.Salon = (Salon2);

            Seans Seans6 = new Seans();
            Seans6.seansZamanı = "  14:30";
            Seans6.Film = (Film2);
            Seans6.Salon = (Salon2);

            Seans Seans7 = new Seans();
            Seans7.seansZamanı = "  18:00";
            Seans7.Film = (Film2);
            Seans7.Salon = (Salon2);

            Seans Seans8 = new Seans();
            Seans8.seansZamanı = " 21:30  ";
            Seans8.Film = (Film2);
            Seans8.Salon = (Salon2);

            Seans Seans9 = new Seans();
            Seans9.seansZamanı = "  11:00";
            Seans9.Film = (Film3);
            Seans9.Salon = (Salon3);

            Seans Seans10 = new Seans();
            Seans10.seansZamanı = "  14:30";
            Seans10.Film = (Film3);
            Seans10.Salon = (Salon3);

            Seans Seans11 = new Seans();
            Seans11.seansZamanı = "  18:00";
            Seans11.Film = (Film3);
            Seans11.Salon = (Salon3);

            Seans Seans12 = new Seans();
            Seans12.seansZamanı = " 21:30  ";
            Seans12.Film = (Film3);
            Seans12.Salon = (Salon3);



            Rezervasyon Rezervasyon1 = new Rezervasyon();
            Rezervasyon1.Seans = (Seans1);
            Rezervasyon1.koltukNo = (KoltukNo);
            Rezervasyon1.biletAdeti = (biletAdeti);
            

            Rezervasyon Rezervasyon2 = new Rezervasyon();
            Rezervasyon2.Seans = (Seans2);
            

            Rezervasyon Rezervasyon3 = new Rezervasyon();
            Rezervasyon3.Seans = (Seans3);

            Rezervasyon Rezervasyon4 = new Rezervasyon();
            Rezervasyon4.Seans = (Seans4);

            Rezervasyon Rezervasyon5 = new Rezervasyon();
            Rezervasyon5.Seans = (Seans5);

            Rezervasyon Rezervasyon6 = new Rezervasyon();
            Rezervasyon6.Seans = (Seans6);

            Rezervasyon Rezervasyon7 = new Rezervasyon();
            Rezervasyon7.Seans = (Seans7);

            Rezervasyon Rezervasyon8 = new Rezervasyon();
            Rezervasyon8.Seans = (Seans8);

            Rezervasyon Rezervasyon9 = new Rezervasyon();
            Rezervasyon9.Seans = (Seans9);


            Rezervasyon Rezervasyon10 = new Rezervasyon();
            Rezervasyon10.Seans = (Seans10);

            Rezervasyon Rezervasyon11 = new Rezervasyon();
            Rezervasyon11.Seans = (Seans11);


            Rezervasyon Rezervasyon12 = new Rezervasyon();
            Rezervasyon12.Seans = (Seans12);

            Bilgi Bilgi1 = new Bilgi();
            Bilgi1.biletFiyatı = 50;
            Bilgi1.Rezervasyon = (Rezervasyon1);

            Bilgi Bilgi2 = new Bilgi();
            Bilgi2.biletFiyatı = 50;
            Bilgi2.Rezervasyon = (Rezervasyon2);

            Bilgi Bilgi3 = new Bilgi();
            Bilgi3.biletFiyatı = 50;
            Bilgi3.Rezervasyon = (Rezervasyon3);

            Bilgi Bilgi4 = new Bilgi();
            Bilgi4.biletFiyatı = 50;
            Bilgi4.Rezervasyon = (Rezervasyon4);

            Bilgi Bilgi5 = new Bilgi();
            Bilgi5.biletFiyatı = 50;
            Bilgi5.Rezervasyon = (Rezervasyon5);



            Bilgi Bilgi6 = new Bilgi();
            Bilgi6.biletFiyatı = 50;
            Bilgi6.Rezervasyon = (Rezervasyon6);

            Bilgi Bilgi7 = new Bilgi();
            Bilgi7.biletFiyatı = 50;
            Bilgi7.Rezervasyon = (Rezervasyon7);

            Bilgi Bilgi8 = new Bilgi();
            Bilgi8.biletFiyatı = 50;
            Bilgi8.Rezervasyon = (Rezervasyon8);

            Bilgi Bilgi9 = new Bilgi();
            Bilgi9.biletFiyatı = 50;
            Bilgi9.Rezervasyon = (Rezervasyon9);


            Bilgi Bilgi10 = new Bilgi();
            Bilgi10.biletFiyatı = 50;
            Bilgi10.Rezervasyon = (Rezervasyon10);

            Bilgi Bilgi11 = new Bilgi();
            Bilgi11.biletFiyatı = 50;
            Bilgi11.Rezervasyon = (Rezervasyon11);

            Bilgi Bilgi12 = new Bilgi();
            Bilgi12.biletFiyatı = 50;
            Bilgi12.Rezervasyon = (Rezervasyon12);

            
            // Burdaki kodda filmlerin bilgileri veriliyor
            Console.WriteLine("1)" + Film1.filmAdi + Film1.filmTuru + "   " + Film1.filmSuresi + " dk" + "   " + Film1.filmYonetmeni);
            Console.WriteLine("2)" + Film2.filmAdi + Film2.filmTuru + " " + Film2.filmSuresi + " " + " dk" + "   " + Film2.filmYonetmeni);
            Console.WriteLine("3)" + Film3.filmAdi + Film3.filmTuru + "     " + Film3.filmSuresi + " dk" + "   " + Film3.filmYonetmeni);

            
            //Film numarası isteniyor burdaki kodda ve o numara da film varsa o film ile ilgili bilgiler yazıyor.Yoksa o numarada film tekrar numara girmesi isteniyor.
            while (true)
            {

                Console.WriteLine("Film numarasını yazınız");
                FilmNumarası = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (FilmNumarası == 1)
                {
                    Console.WriteLine("Seçilen  film:" + Film1.filmAdi + Film1.filmTuru + Film1.filmSuresi + "dk   " + Film1.filmYonetmeni);
                    Console.WriteLine(Salon1.salonAdi + "Salon Kapasitesi:" + Salon1.salonKapasitesi);
                    FilmAdiK = Film1.filmAdi;
                    FilmSuresiK =Film1.filmSuresi;
                    SalonAdiK = Salon1.salonAdi;
                    break;
                }

                else if (FilmNumarası == 2)
                {
                    Console.WriteLine("Seçilen  film:" + Film2.filmAdi + Film2.filmTuru + Film2.filmSuresi + "dk   " + Film2.filmYonetmeni);
                    Console.WriteLine(Salon2.salonAdi + "Salon Kapasitesi:" + Salon2.salonKapasitesi);
                    FilmAdiK = Film2.filmAdi;
                    FilmSuresiK =Film2.filmSuresi;
                    SalonAdiK = Salon2.salonAdi;
                    break;
                }

                else if (FilmNumarası == 3)
                {
                    Console.WriteLine("Seçilen  film:" + Film3.filmAdi + Film3.filmTuru + Film3.filmSuresi + "dk   " + Film3.filmYonetmeni);
                    Console.WriteLine(Salon3.salonAdi + "Salon Kapasitesi:" + Salon3.salonKapasitesi);
                    FilmAdiK = Film3.filmAdi;
                    FilmSuresiK=Film3.filmSuresi;
                    SalonAdiK = Salon3.salonAdi;
                    break;
                }


                else
                {
                    Console.WriteLine("Böyle bir film yok, tekrar deneyin");
                    continue;
                }
            }

            //Bilet tarihi seçimi yapılması isteniyor bu kodda.Başka bir günü  seçerse o günü yazması isteniyor.
            Console.WriteLine("            ");
            Console.WriteLine("Bilet tarihi Seçiniz");
            Console.WriteLine("1)" + Seans1.tarih.Day + "." + Seans1.tarih.Month + "." + Seans1.tarih.Year);
            Console.WriteLine("2)Başka bir gün için tarih seçiniz ");
            Console.WriteLine("            ");


            Console.WriteLine("            ");
            int SeansSecin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("         ");

            if (SeansSecin == 1)
            {
                Console.WriteLine("Seçtiğiniz tarih:" + Seans1.tarih.Day + "." + Seans1.tarih.Month + "." + Seans1.tarih.Year);
                tarihD = Seans1.tarih.Day.ToString();
                tarihM = Seans1.tarih.Month.ToString();
                tarihY = Seans1.tarih.Year.ToString();
            }
            else if (SeansSecin == 2)
            {
                while (true)
                {
                    Console.WriteLine("İstediğiniz tarihi örnekte gördüğünüz gibi giriniz.");
                    Console.WriteLine("Örnek;  10.05.2023");
                    Console.WriteLine("            ");
                    DateTime SecilenTarih = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Seçtiğniz tarih :" + SecilenTarih.Day + "." + SecilenTarih.Month + "." + SecilenTarih.Year);
                    tarihD = SecilenTarih.Day.ToString();
                    tarihM = SecilenTarih.Month.ToString();
                    tarihY = SecilenTarih.Year.ToString();
                    
                    // Geçmiş bir tarih girilince bu kod çalışır ve tekrar tarih girilmesi istenir.
                    if (SecilenTarih < Seans1.tarih)
                    {
                        Console.WriteLine("Geçmiş bir tarih girdiniz");
                        continue;

                    }
                    else
                    {
                        break;
                    }
                }

            }
            else if (SeansSecin < 1)
            {
                Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar programa giriş yapınız.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar programa giriş yapınız");
                Console.ReadLine();
            }

            //Seçilen film ve güne göre seans zamanı bilgisi verilir. 
            Console.WriteLine("            ");
            if (FilmNumarası == 1)
            {
                Console.WriteLine(Seans1.Film.filmAdi + "1) " + Seans1.seansZamanı + "  2) " + Seans2.seansZamanı + "  3) " + Seans3.seansZamanı + "  4) " + Seans4.seansZamanı);
                
            }
            else if (FilmNumarası == 2)
            {
                Console.WriteLine(Seans5.Film.filmAdi + "1) " + Seans5.seansZamanı + "  2) " + Seans6.seansZamanı + "  3) " + Seans7.seansZamanı + "  4) " + Seans8.seansZamanı);
            }
            else if (FilmNumarası == 3)
            {
                Console.WriteLine(Seans9.Film.filmAdi + "1) " + Seans9.seansZamanı + "  2) " + Seans10.seansZamanı + "  3) " + Seans11.seansZamanı + "  4) " + Seans12.seansZamanı);
            }

            //Bu kodda film seans zamanı seçilir.
            Console.WriteLine("Film Seans saati seçiniz ");
            Console.WriteLine("            ");
            Double FilmSaati = Convert.ToInt32(Console.ReadLine());

            if (FilmSaati == 1)
            {
                Console.WriteLine("Seçilen saat:" + Seans1.seansZamanı);
                FilmSaatiK = Seans1.seansZamanı;
            }
            else if (FilmSaati == 2)
            {
                Console.WriteLine("Seçilen saat:" + Seans2.seansZamanı);
                FilmSaatiK = Seans2.seansZamanı;
            }
            else if (FilmSaati == 3)
            {
                Console.WriteLine("Seçilen saat:" + Seans3.seansZamanı);
                FilmSaatiK = Seans3.seansZamanı;
            }
            else if (FilmSaati == 4)
            {
                Console.WriteLine("Seçilen saat:" + Seans4.seansZamanı);
                FilmSaatiK = Seans4.seansZamanı;
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
            }
            
            // Müsteri adı soyadı ve telefon numarası alınır bu kodda.
            Console.WriteLine("Müşteri Adı Soyadı giriniz");
            string Musteri = Convert.ToString(Console.ReadLine());

            Rezervasyon1.musteriAdiSoyadi = Musteri;
            Console.WriteLine("Müsteri ad - Soyad :" + Musteri);

            Console.WriteLine("Müşteri Telefon No giriniz.Örnek :(###)-###-##-## ");
            Double Ceptelefon = Convert.ToDouble(Console.ReadLine());
            Rezervasyon1.musteriCepTelefonu = Ceptelefon;


            var koltukA = "";

            //Bu kodda bugün  seçimine göre işlemler devam ediyor.Boş koltuk sayısı da yazdırılır.
            if (SeansSecin == 1)
            {
                Console.WriteLine(" 40 Tane boş koltuk  ");
                int bos = 40;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                Perde                          ");
                Console.WriteLine("1   " + "2  " + " 3  " + " 4  " + " 5  " + " 6  " + " 7  " + " 8  " + " 9  " + " 10  ");
                Console.WriteLine("11  " + "12  " + "13  " + "14  " + "15  " + "16  " + "17  " + "18  " + "19  " + "20  ");
                Console.WriteLine("21  " + "22  " + "23  " + "24  " + "25  " + "26  " + "27  " + "28  " + "29  " + "30  ");
                Console.WriteLine("31  " + "32  " + "33  " + "34  " + "35  " + "36  " + "37  " + "38  " + "39  " + "40  ");
                Console.WriteLine("41  " + "42  " + "43  " + "44  " + "45  " + "46  " + "47  " + "48  " + "49  " + "50  ");
                Console.WriteLine("");

                // Bu kodda random dolu koltuklar olusturluyor
                Random r = new Random();
                string[] K = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" };

                List<string> doluKoltuklar = new List<string>();
                HashSet<string> secilenKoltuklar = new HashSet<string>();

                while (doluKoltuklar.Count < 10)
                {
                    int index = r.Next(0, K.Length);
                    string koltukNo = K[index];

                    if (!secilenKoltuklar.Contains(koltukNo))
                    {
                        doluKoltuklar.Add(koltukNo);
                        secilenKoltuklar.Add(koltukNo);
                    }
                }

                foreach (string koltuk in doluKoltuklar)
                {
                    Console.WriteLine("doluKoltuk: " + koltuk);
                }
                 /*Burdaki kodlarda Bilet adeti girilmesi istenir  ve o kadar bilet var mı diye kontrol edilir.
                 Yeterli koltuk yoksa tekrar bilet adeti istenir.Aynı zamanda bilet sayısına göre fiyat hesaplanır.
                 Bilet adeti kadar boş koltuk no girilmesi istenir.*/
                while (true)
                {
                    Console.WriteLine("Bilet adeti giriniz ");
                    int biletAdeti = Convert.ToInt32(Console.ReadLine());
                    Rezervasyon1.biletAdeti = biletAdeti;
                    Console.WriteLine("Bilet adeti: " + biletAdeti);

                     
                    int Kalan;
                    Kalan = bos - biletAdeti;

                   
                    int fiyat = biletAdeti * Bilgi1.biletFiyatı;
                    Console.WriteLine(fiyat + " TL  ");
                    
                    if (Kalan < 0)
                    {
                        Console.WriteLine("Yetersiz koltuk Sayısı");
                        continue;

                    }
                    else
                    {

                        string[] KoltukNo = new string[biletAdeti];
                        Console.WriteLine("Lütfen bilet adeti kadar tek tek Koltuk No giriniz");
                        for (int d = 0; d < biletAdeti; d++)
                        {
                            KoltukNo[d] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Seçilen Koltuk No: " + KoltukNo[d]);
                            koltukA += KoltukNo[d] + " ";
                        }
                        break;
                        
                    }



                }



            }
            // Bu kodda bugün değil ileri bir tarih seçildiyse onun için işlemler yapılır.Ve boş koltuk sayısı söylenir.
            else
            {
                Console.WriteLine("Tüm Koltuklar boş");


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                Perde                          ");
                Console.WriteLine("1   " + "2  " + " 3  " + " 4  " + " 5  " + " 6  " + " 7  " + " 8  " + " 9  " + " 10  ");
                Console.WriteLine("11  " + "12  " + "13  " + "14  " + "15  " + "16  " + "17  " + "18  " + "19  " + "20  ");
                Console.WriteLine("21  " + "22  " + "23  " + "24  " + "25  " + "26  " + "27  " + "28  " + "29  " + "30  ");
                Console.WriteLine("31  " + "32  " + "33  " + "34  " + "35  " + "36  " + "37  " + "38  " + "39  " + "40  ");
                Console.WriteLine("41  " + "42  " + "43  " + "44  " + "45  " + "46  " + "47  " + "48  " + "49  " + "50  ");
                Console.WriteLine("");
                int bosk = 50;
                //Burdaki kodlarda Bilet adeti girilmesi istenir  ve o kadar bilet var mı diye kontrol edilir.
                //Yeterli koltuk yoksa tekrar bilet adeti istenir.Aynı zamanda bilet sayısına göre fiyat hesaplanır.
                // Bilet adeti kadar boş koltuk no girilmesi istenir.
                while (true)
                {
                    Console.WriteLine("Bilet adeti giriniz ");
                    int biletAdeti = Convert.ToInt32(Console.ReadLine());
                    Rezervasyon1.biletAdeti = biletAdeti;
                    Console.WriteLine("Bilet adeti: " + biletAdeti);
                    int kalan;
                    kalan = bosk - biletAdeti;
                    int fiyat = biletAdeti * Bilgi1.biletFiyatı;
                    Console.WriteLine(fiyat + " TL  ");
                    
                    if (kalan < 0)
                    {
                        Console.WriteLine("Yetersiz koltuk Sayısı");
                        continue;

                    }
                    else
                    {
                        

                            string[] KoltukNo = new string[biletAdeti];
                            Console.WriteLine("Lütfen bilet adeti kadar tek tek Koltuk No giriniz");
                            for (int d = 0; d < biletAdeti; d++)
                            {
                                KoltukNo[d] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Seçilen Koltuk No: " + KoltukNo[d]);
                                koltukA += KoltukNo[d] + " ";
                            }


                        
                        break;
                    }

                }

            }


            //Bilet yazdırma.

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Bilet Bilgisi                              Rezervasyon  yapılış Tarihi:    " + DateTime.Now );
            Console.WriteLine("  Film:" + FilmAdiK + ""+""+""+FilmSuresiK +"dk");
            Console.WriteLine(" "+" "+ SalonAdiK);
            Console.WriteLine("  Film Tarihi: " +tarihD+"."+tarihM+"."+tarihY );
            Console.WriteLine("  Film saati : " + FilmSaatiK);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------" );
            Console.WriteLine("  Adı Soyad :" + Rezervasyon1.musteriAdiSoyadi.ToUpper());     
            Console.WriteLine("  Cep Telefonu:"    );
            Console.WriteLine("{0:  (###)-###-##-##}",Rezervasyon1.musteriCepTelefonu);
            Console.WriteLine("  Fiyatı:" + Rezervasyon1.biletAdeti * Bilgi1.biletFiyatı + " TL  " + "Bilet Adeti:" + Rezervasyon1.biletAdeti  );
            Console.WriteLine("  Koltuk No:" + koltukA);
            Console.WriteLine("_________________________________________________________________________________________________________________");

            Console.WriteLine("*********************************İşlem Başarılı*******************************************");

            


        }



    }
}




















