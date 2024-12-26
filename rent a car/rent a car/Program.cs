using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car
{
    internal class Program 
    {
        private static string Don(string k)
        {
           // İŞLEM SORUSU METODU  
           switch (k)
           {
                case "E": Console.Clear(); break;
                case "H": Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Çıkış yapılıyor..."); System.Threading.Thread.Sleep(2000); Environment.Exit(0); break;
                case "e": Console.Clear(); break; 
                case "h": Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Çıkış yapılıyor..."); System.Threading.Thread.Sleep(2000); Environment.Exit(0); break;
                default: Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçerli değer giremediniz."); Console.ForegroundColor = ConsoleColor.White; break;
           } return k;
        } 
        static void Main(string[] args)
        {
            // MÜŞTERİ BİLGİLERİ
            List<string> musIsim = new List<string>();  
            List<string> musTel = new List<string>();
            List<string> musSifre = new List<string>();
            List<string> musEposta = new List<string>();
            List<string> musAdres = new List<string>();
            List<string> kiraAd = new List<string>();
            List<string> kiraTel = new List<string>();
            List<string> kiraAdres = new List<string>();
            List<string> kiraSifre = new List<string>();
            List<DateTime> tarih = new List<DateTime>();

            // ARABA LİSTELERİ
            List<string> marka = new List<string>();
            List<int> modelYili = new List<int>();
            List<int> km = new List<int>();
            List<string> plaka = new List<string>();
            List<string> kiraArac = new List<string>();
            List<string> kiraPlaka = new List<string>();
            List<int> kiraKm = new List<int>();

            int isKarar;   // Kullanıcıdan Alınan Sayı
            string karar;   // Kullanıcıdan Alınan Metin

            while (true)
            {
                Console.WriteLine("RENT A CAR");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: "); Console.WriteLine("1-) Müşteri İşlemleri"); Console.WriteLine("2-) Araç Yönetimi"); Console.WriteLine("3-) Kiralama İşlemleri"); Console.WriteLine("4-) İade İşlemleri"); Console.WriteLine("5-) Arama ve Filtreleme"); Console.WriteLine("6-) ÇIKIŞ");
                isKarar = Convert.ToInt32(Console.ReadLine());
                if (isKarar == 1)
                {
                    // MÜŞTERİ iŞLEMLERİ
                    Console.Clear();
                    Console.WriteLine("MÜŞTERİ İŞLEMLERİ");
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz."); Console.WriteLine("1-) Müşteri Kayıt"); Console.WriteLine("2-) Müşteri Bilgilerini Güncelle");
                    isKarar = Convert.ToInt32(Console.ReadLine());

                    if (isKarar == 1)
                    {
                        // MÜŞTERİ KAYIT
                        Console.WriteLine("MÜŞTERİ KAYIT EKRANI");
                        Console.WriteLine("İsminizi giriniz: ");
                        string isim = Console.ReadLine();
                        Console.WriteLine("Şifrenizi giriniz: ");
                        string sifre = Console.ReadLine();
                        Console.WriteLine("Telefon numaranızı giriniz: ");
                        string telNo = Console.ReadLine();
                        Console.WriteLine("E-Posta adresinizi giriniz: ");
                        string eposta = Console.ReadLine();
                        Console.WriteLine("Adresinizi giriniz: ");
                        string adres = Console.ReadLine();

                        musIsim.Add(isim);
                        musSifre.Add(sifre);
                        musTel.Add(telNo);
                        musEposta.Add(eposta);
                        musAdres.Add(adres);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kayıt Başarılı!"); Console.ForegroundColor = ConsoleColor.White;
                        // İşlem Sorusu
                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); 
                    }
                    else if (isKarar == 2)
                    {
                        // BİLGİLERİ GÜNCELLEME
                        Console.Clear();
                        Console.WriteLine("MÜŞTERİ BİLGİLERİ GÜNCELLEME EKRANI");
                        Console.Write("İsim giriniz: "); string ism = Console.ReadLine();
                        Console.Write("Şifrenizi giriniz:");
                        while (true)
                        {
                            string sifre = Console.ReadLine();
                            int index = musIsim.IndexOf(ism);
                            if (sifre == musSifre[index])
                            {

                                if (musIsim.Contains(ism))
                                {
                                    Console.WriteLine("Değiştirmek istediğiniz işlemi seçiniz.");
                                    Console.WriteLine("1-) Telefon Numarası"); Console.WriteLine("2-) E-Posta"); Console.WriteLine("3-) Şifre"); Console.WriteLine("4-) Adres");
                                    isKarar = Convert.ToInt32(Console.ReadLine());
                                    index = musIsim.IndexOf(ism);

                                    if (isKarar == 1)
                                    {
                                        Console.WriteLine("Yeni Telefon Numaranızı Giriniz: ");
                                        string tlf = Console.ReadLine();
                                        musTel[index] = tlf;
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Telefon Numarası Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                    else if (isKarar == 2)
                                    {
                                        Console.WriteLine("Yeni E-Posta Adresini Giriniz: ");
                                        string epst = Console.ReadLine();
                                        musEposta[index] = epst;   // 
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("E-Posta Adresi Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                    else if (isKarar == 3)
                                    {
                                        Console.WriteLine("Yeni şifrenizi giriniz:");
                                        sifre = Console.ReadLine();
                                        musSifre[index] = sifre;
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Şifreniz Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                    else if (isKarar == 4)
                                    {
                                        Console.WriteLine("Yeni Adresinizi Giriniz: ");
                                        string adr = Console.ReadLine();
                                        musAdres[index] = adr;
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Adres Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Geçerli bir değer giremediniz!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Kullanıcı Bulunamadı!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write("Şifreniz Yanlıştır! Tekrar Deneyiniz: "); Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçerli bir değer giremediniz!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                    }
                } 
                else if (isKarar == 2)
                {
                    Console.Clear();
                    Console.WriteLine("ARAÇ YÖNETİMİ");
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz."); Console.WriteLine("1-) Yeni Araç Ekleme"); Console.WriteLine("2-) Araç Bilgileri Güncelleme"); Console.WriteLine("3-) Mevcut Araçlar");
                    isKarar = Convert.ToInt32(Console.ReadLine());
                    if (isKarar == 1)
                    {
                        // ARAÇ EKLEME
                        Console.Clear();
                        Console.WriteLine("ARAÇ EKLEME EKRANI");
                        Console.Write("Aracın marka ve modelini giriniz: "); string arMarka = Console.ReadLine();
                        Console.Write("Aracın model yılını giriniz: "); int arModelYili = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Aracın plakasını giriniz: "); string arPlaka = Console.ReadLine();
                        Console.Write("Aracın kilometre bilgisini giriniz: "); int arKm = Convert.ToInt32(Console.ReadLine());

                        marka.Add(arMarka); modelYili.Add(arModelYili);
                        km.Add(arKm); plaka.Add(arPlaka);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kayıt Başarılı!"); Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                    }
                    if (isKarar == 2)
                    {
                        // ARAÇ BİLGİSİ GÜNCELLEME
                        Console.Clear();
                        Console.WriteLine("BİLGİ GÜNCELLEME EKRANI");
                        int sayac = 0;
                        Console.WriteLine("Değiştirmek istediğiniz aracı seçiniz: ");
                        foreach (string i in marka)
                        {
                            sayac++;
                            Console.WriteLine(sayac + " - " + i);
                        }
                        int secim = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Araç: " + marka[secim - 1]);
                        Console.WriteLine("Aracın değiştirmek istediğiniz bilgisini seçiniz: "); Console.WriteLine("1-) Kilometre Bilgisi"); Console.WriteLine("2-) Plaka Bilgisi");
                        isKarar = Convert.ToInt32(Console.ReadLine());
                        if (isKarar == 1)
                        {
                            Console.WriteLine("Şu anki kilometre : " + km[secim - 1]); Console.WriteLine("Aracın yeni kilometre bilgisini giriniz: ");
                            int yKm = Convert.ToInt32(Console.ReadLine());
                            km[secim - 1] = yKm;
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kilometre Güncellendi!"); Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                        }
                        else if (isKarar == 2)
                        {
                            Console.WriteLine("Şu anki plaka : " + plaka[secim - 1]); Console.WriteLine("Aracın yeni plaka bilgisini giriniz: ");
                            string yPlaka = Console.ReadLine();
                            plaka[secim - 1] = yPlaka;
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Plaka Güncellendi!"); Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçerli bir değer giremediniz!"); Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                        }
                    }
                    if (isKarar == 3)
                    {   // LİSTELEME
                        Console.WriteLine("Araç Adı                Araç Plakası            KİRA DURUMU");
                        Console.WriteLine("-------------------------------------------------------------");
                        for (int i = 0; i < marka.Count; i++) 
                        {
                            if (kiraPlaka.Contains(plaka[i]))
                            {
                                Console.Write($"{marka[i],-24}{plaka[i],-20}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("KİRADA"); Console.ForegroundColor = ConsoleColor.White; // buradaki $ işareti Console.WriteLine(); içine liste elemanlarını yan yana yazabilmemizi sağlar...
                            }
                            else
                            {
                                Console.Write($"{marka[i],-24}{plaka[i],-20}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                    }
                }
                else if (isKarar == 3)
                {
                    // KİRALAMA İŞLEMLERİ
                    Console.Clear();
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz."); Console.WriteLine("1-) Araç Kiralama"); Console.WriteLine("2-) Kiralanan Araçlar");
                    isKarar = Convert.ToInt32(Console.ReadLine());
                    if (isKarar == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Araç Kiralama Ekranı");
                        Console.WriteLine("BİLGİLENDİRME");
                        Console.WriteLine("Kiralama ücretleri günlük olarak hesaplanmaktadır. Tüm araçların kiralama ücreti 300 TL' dir.");
                        Console.Write("İsminizi giriniz: ");
                        string kAd = Console.ReadLine();
                        if (musIsim.Contains(kAd))
                        {
                            int index = musIsim.IndexOf(kAd);
                            Console.Write("Lütfen şifrenizi giriniz: ");
                            while (true)
                            {
                                string sifre = Console.ReadLine();
                                if (musSifre[index] == sifre)
                                {
                                    int sayac = 0;
                                    Console.WriteLine("Kiralamak istediğiniz aracı seçiniz.");
                                    foreach (string i in marka)
                                    {
                                        sayac++;
                                        Console.WriteLine(sayac + "- " + i);
                                    }
                                    int secim = Convert.ToInt32(Console.ReadLine());
                                    if (kiraArac.Contains(marka[secim - 1]))
                                    {
                                        int indeks = kiraArac.IndexOf(marka[secim - 1]);
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Bu araç " + kiraAd[indeks] + " kişisine kiralanmıştır."); Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                    else
                                    {
                                        kiraAd.Add(kAd);
                                        kiraArac.Add(marka[secim - 1]);
                                        kiraSifre.Add(sifre);
                                        Console.Write("Kiralamak istediğiniz gün sayısını giriniz: ");
                                        int gun = Convert.ToInt32(Console.ReadLine());
                                        DateTime bugun = DateTime.Now;
                                        DateTime iadeTarih = bugun.AddDays(gun);
                                        tarih.Add(iadeTarih);
                                        kiraTel.Add(musTel[index]);
                                        kiraPlaka.Add(plaka[secim - 1]);
                                        kiraAdres.Add(musAdres[index]);
                                        kiraKm.Add(km[secim - 1]);

                                        int bedel = gun * 300;
                                        Console.WriteLine("Toplam fiyat " + bedel + "TL'dir. Ödeme yöntemini seçiniz."); Console.WriteLine("1- Kredi Kartı"); Console.WriteLine("2- Nakit");
                                        while (true)
                                        {
                                            isKarar = Convert.ToInt32(Console.ReadLine());
                                            if (isKarar == 1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Ödemeniz gerçekleştirilmiştir!"); Console.ForegroundColor = ConsoleColor.White; break;
                                            }
                                            else if (isKarar == 2)
                                            {
                                                Console.WriteLine("Ödemeyi aracı teslim alırken kasaya yapmayı unutmayınız..."); System.Threading.Thread.Sleep(2000); Console.Clear(); break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Geçersiz değer girdiniz. Araç kiralama işlemini tamamlamak için bir ödeme yöntemi seçmeniz gerekmektedir. Toplam fiyat: " + bedel + "TL'dir."); Console.WriteLine("1- Kredi Kartı"); Console.WriteLine("2- Nakit");
                                            }
                                        }
                                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("Şifreniz yanlıştır! Tekrar deneyiniz:"); Console.ForegroundColor = ConsoleColor.White;
                                }
                                }
                            }
                            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Müşteri kaydı bulunamadı lütfen kayıt olunuz."); Console.ForegroundColor = ConsoleColor.White; }
                        }
                        else if (isKarar == 2)
                        {
                            // KİRADAKİ ARAÇLAR
                            Console.WriteLine("Araç Adı               Araç Plakası        Müşteri İsmi           Teslim Tarihi       Müşteri Telefon Numarası           Müşteri Adresi");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                            for (int i = 0; i < kiraArac.Count; i++)
                            {
                                Console.WriteLine($"{kiraArac[i],-24}{kiraPlaka[i],-20}{kiraAd[i],-24}{tarih[i],-24}{kiraTel[i],-30}{kiraAdres[i]}"); 
                            }
                            Console.WriteLine();
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçersiz bir değer girdiniz!"); Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                        }
                    }
                    else if (isKarar == 4)
                    {
                        // İADE İŞLEMLERİ
                        Console.Clear();
                        Console.WriteLine("İade edeceğiniz aracı seçiniz.");
                        int secim = 0;
                        foreach (string i in kiraArac) { secim++; Console.WriteLine(secim + "- " + i); }
                        secim = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İsminizi giriniz.");
                        string isim = Console.ReadLine();
                        int adIndex = kiraAd.IndexOf(isim);
                        if (adIndex == secim - 1)
                        {
                            Console.WriteLine("Şifrenizi giriniz.");
                            while (true)
                            {
                                string sifre = Console.ReadLine();
                                if (sifre == kiraSifre[adIndex])
                                {
                                // iade edilen araç bilgilerini kiradaki araç listesinden silme
                                    kiraArac.RemoveAt(secim - 1);
                                    kiraPlaka.RemoveAt(secim - 1);
                                    kiraAdres.RemoveAt(secim - 1);
                                    kiraAd.RemoveAt(secim - 1);
                                    kiraTel.RemoveAt(secim - 1);
                                    Console.WriteLine("Aracın kiralanmadan önceki kilometresi: " + kiraKm[secim - 1]);
                                    Console.WriteLine("Lütfen aracın şuanki kilometresini giriniz:");
                                    while (true)
                                    {
                                        int mKm = Convert.ToInt32(Console.ReadLine());
                                        if (mKm < kiraKm[secim - 1])
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Girdiğiniz değer aracın kiralanmadan önceki kilometresinden küçüktür!"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Lütfen aracın kiralanmadan önceki kilometresinden büyük bir değer giriniz!");
                                        }
                                        else
                                        {
                                            int indks = km.IndexOf(kiraKm[secim - 1]);
                                            km[indks] = mKm;
                                            kiraKm.RemoveAt(secim - 1);
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("İade işlemi tamamlanmıştır. Bizi tercih ettiğiniz için teşekkürler..."); Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                    }
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar); break;
                                }
                                else { Console.ForegroundColor = ConsoleColor.Red; Console.Write("Şifreniz yanlıştır! Tekrar deneyiniz: "); Console.ForegroundColor = ConsoleColor.White; }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Seçtiğiniz araç ve sisteme kayıtlı isim eşleşmemektedir."); Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                        }
                    }
                    else if (isKarar == 5)
                    {
                        // ARAMA VE FİLTRELEME
                        Console.Clear();
                        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz."); Console.WriteLine("1-) Araç Arama"); Console.WriteLine("2-) Araç Filtreleme");
                        isKarar = Convert.ToInt32(Console.ReadLine());
                        if (isKarar == 1)
                        {
                            Console.WriteLine("ARAÇ ARAMA EKRANI");
                            Console.WriteLine("Aramak istediğiniz aracın marka ve modelini giriniz: ");
                            karar = Console.ReadLine();
                            Console.Clear();
                            if (marka.Contains(karar))
                            {
                                Console.WriteLine("Araç Adı            Kilometresi          Plakası         KİRA DURUMU");
                                Console.WriteLine("----------------------------------------------------------------------");
                                for (int i = 0; i < marka.Count; i++)
                                {
                                    if (marka[i].Equals(karar))
                                    {
                                        if (kiraPlaka.Contains(plaka[i]))  // KİRADAKİ ARAÇLARI LİSTELER
                                        {
                                            Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else      // KİRALAMAYA UYGUN ARAÇLARI LİSTELER
                                        {
                                            Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                } Console.WriteLine();
                                Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("ARAÇ BULUNAMADI!"); Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                            }
                        }
                        else if (isKarar == 2)
                        {
                            //  ARAÇ FİLTRELEME
                            Console.WriteLine("Filtrelemek istediğiniz özelliği seçin:"); Console.WriteLine("1-) Kilometre"); Console.WriteLine("2-) Model Yılı");
                            isKarar = Convert.ToInt32(Console.ReadLine());
                            if (isKarar == 1) // KİLOMETREYE GÖRE FİLTRELEME
                            {
                                Console.WriteLine("Kilometre değer aralıklarını giriniz: ");
                                Console.Write("1. değer: "); int deger1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("2. değer: "); int deger2 = Convert.ToInt32(Console.ReadLine());
                                if (deger1 > deger2) // deger1 deger2 den büyükse
                                {
                                    Console.WriteLine("Araç Adı            Kilometresi          Plakası          Kira Durumu");
                                    Console.WriteLine("-----------------------------------------------------------------------");
                                    for (int i = 0; i < marka.Count; i++)
                                    {
                                        if (km[i] >= deger2 && km[i] <= deger1)
                                        {
                                            if (kiraPlaka.Contains(plaka[i]))
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else if (km[i]<deger2 && km[i] > deger1) { }
                                    } Console.WriteLine();
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                                }
                                else if (deger1 < deger2) // deger2 deger1 den büyükse
                                {
                                    Console.WriteLine("Araç Adı            Kilometresi          Plakası          Kira Durumu");
                                    Console.WriteLine("-----------------------------------------------------------------------");
                                    for (int i = 0; i < marka.Count; i++)
                                    {
                                        if (km[i] <= deger2 && km[i] >= deger1)
                                        {
                                            if (kiraPlaka.Contains(plaka[i]))   // KİRALIK ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else    // KİRALAMAYA UYGUN ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else if (km[i] > deger2 && km[i] < deger1) { }
                                    } Console.WriteLine();
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                                }
                                else
                                {
                                    Console.WriteLine("Araç Adı            Kilometresi          Plakası          Kira Durumu");
                                    Console.WriteLine("-----------------------------------------------------------------------");
                                    for (int i = 0; i < marka.Count; i++)
                                    {
                                        if (km[i] == deger1)
                                        {
                                            if (kiraPlaka.Contains(plaka[i]))   // KİRALIK ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else    // KİRALAMAYA UYGUN ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-16}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else if (km[i] > deger2 && km[i] < deger1) { }
                                    } Console.WriteLine();
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                                }
                            }
                            else if (isKarar == 2) // MODEL YILINA GÖRE LİSTELEME
                            {
                                Console.WriteLine("Model yılı değer aralıklarını giriniz:");
                                Console.Write("1. değer:"); int deger1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("2. değer:"); int deger2 = Convert.ToInt32(Console.ReadLine());

                                if(deger1 > deger2)
                                {
                                    Console.WriteLine("Araç Adı            Kilometresi          Plakası          Model Yılı        Kira Durumu");
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                    for ( int i = 0; i < marka.Count; i++)
                                    {
                                        if (modelYili[i]<=deger1 && modelYili[i]>=deger2)
                                        {
                                            if (kiraPlaka.Contains(plaka[i]))   // KİRALIK ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-20}{modelYili[i],-15}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else    // KİRALAMAYA UYGUN ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-20}{modelYili[i],-15}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else if (modelYili[i]>deger1 && modelYili[i] < deger2) { }
                                    } Console.WriteLine();
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                                }
                                else if (deger1 < deger2)
                                {
                                    Console.WriteLine("Araç Adı            Kilometresi          Plakası          Model Yılı        Kira Durumu");
                                    Console.WriteLine("----------------------------------------------------------------------------------------");
                                    for (int i = 0; i < marka.Count; i++)
                                    {
                                        if (modelYili[i] >= deger1 && modelYili[i] <= deger2)
                                        {
                                            if (kiraPlaka.Contains(plaka[i]))   // KİRALIK ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-20}{modelYili[i],-15}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else    // KİRALAMAYA UYGUN ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-20}{modelYili[i],-15}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else if (modelYili[i] < deger1 && modelYili[i] > deger2) { }
                                    } Console.WriteLine();
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                                }
                                else
                                {
                                    Console.WriteLine("Araç Adı            Kilometresi          Plakası          Kira Durumu");
                                    Console.WriteLine("-----------------------------------------------------------------------");
                                    for (int i = 0; i < marka.Count; i++)
                                    {
                                        if (modelYili[i] == deger1 && modelYili[i] == deger2)
                                        {
                                            if (kiraPlaka.Contains(plaka[i]))   // KİRALIK ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-20}{modelYili[i],-15}"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" KİRADA"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else    // KİRALAMAYA UYGUN ARAÇLARI LİSTELER
                                            {
                                                Console.Write($"{marka[i],-24}{km[i],-16}{plaka[i],-20}{modelYili[i],-15}"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" KİRALAMAYA UYGUN"); Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else if (modelYili[i] > deger2 && km[i] < deger1) { }
                                    } Console.WriteLine();
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçerli bir değer giremediniz!"); Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                            }
                        }
                    }
                    else if (isKarar == 6)
                    {       // ÇIKIŞ
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Çıkış Yapılıyor.."); System.Threading.Thread.Sleep(2000); Environment.Exit(0);
                    }
                    else
                    {   // GEÇERSİZ DEĞER
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçerli bir değer giremediniz..."); Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Don(karar);
                    }
                }
            }
        }
    }
