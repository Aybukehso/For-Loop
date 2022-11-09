using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTORANT
{
    internal class Program:Masa
         
    {
        public double masageliri = 0;
        static void Main(string[] args)
        {     
ANAMENU:
            Console.WriteLine("**********************************");
            Console.WriteLine("CAFE YÖNETİM SİSTEMİNE HOŞGELDİNİZ");
            Console.WriteLine("**********************************");

            Console.WriteLine("------MASA AÇ----------[1]");
          

            Console.WriteLine("------MASA İŞLEM-------[2]");

            Console.WriteLine("------MASA HESAP-------[3]");

            Console.WriteLine("------KASA İŞLEMLERİ---[4]");

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Çıkış Yap        [0]");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("SEÇİMİNİZ\t");

            int islem = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                switch (islem)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("*******************");
                            Console.WriteLine("------MASA AÇ------");
                            Console.WriteLine("*******************");
                            Masalar();
                            Console.WriteLine("Masa açmak için ID giriniz");                          
                            int x = Convert.ToInt32(Console.ReadLine());
                            MasaAc(x);
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("Ana Menüye Dön      [0]");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("-----MENU----------");
                            MenuUrunListele();
                            
URUNEKLE:                   Console.Write("Ürün eklemek için Ürün ID giriniz: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            switch (b)
                            {
                                case 1:
                                    foreach (Masa item in Masa.masaList)
                                    {
                                        if (x == item.masano)
                                        {
                                            item.kofte += 1;
                                        }
                                    }
                                    Console.WriteLine("Masaya köfte eklendi");
                                    goto URUNEKLE;
                                    
                                case 2:
                                    foreach (Masa item in Masa.masaList)
                                    {
                                        if (x == item.masano)
                                        {
                                            item.pilav += 1;
                                        }
                                    }
                                    Console.WriteLine("Masaya pilav eklendi!");
                                    goto URUNEKLE;
                                    
                                case 3:
                                    foreach (Masa item in Masa.masaList)
                                    {
                                        if (x == item.masano)
                                        {
                                            item.pizza += 1;
                                        }
                                    }
                                    Console.WriteLine("Masaya pizza eklendi!");
                                    goto URUNEKLE;
                                    
                                case 4:
                                    foreach (Masa item in Masa.masaList)
                                    {
                                        if (x == item.masano)
                                        {
                                            item.ayran += 1;
                                        }
                                    }
                                    Console.WriteLine("Masaya ayran eklendi!");
                                    goto URUNEKLE;
                                    
                                case 5:
                                    foreach (Masa item in Masa.masaList)
                                    {
                                        if (x == item.masano)
                                        {
                                            item.cola += 1;
                                        }
                                    }
                                    Console.WriteLine("Masaya cola eklendi!");
                                    goto URUNEKLE;
                                    
                                case 6:
                                    foreach (Masa item in Masa.masaList)
                                    {
                                        if (x == item.masano)
                                        {
                                            item.sprite += 1;
                                        }
                                    }
                                    Console.WriteLine("Masaya sprite eklendi!");
                                    goto URUNEKLE;
                                    
                                case 0:
                                    
                                    goto ANAMENU;                                   
                            }
                            break;
                        } 
                        

                    case 2:
MASAİSLEM:
                        Console.Clear();
                        Console.WriteLine("**************************");
                        Console.WriteLine("------MASA İŞLEM----------");
                        Console.WriteLine("**************************");

                        Masa.Masalar();
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Onayla ve Ana Menüye Dön      [0]");
                        Console.WriteLine("Geri Dön            [sol ok]");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.Write("İşlem yapmak için masa ID giriniz: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Masa.Masaurunlistele(a);
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Sipariş Ekle     [1]");
                        Console.WriteLine("sipariş Sil      [2]");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Onayla ve Ana Menüye Dön      [0]");
                        Console.WriteLine("Geri Dön            [sol ok]");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("SEÇİMİNİZ\t");
                        ConsoleKeyInfo KeyInfoss = Console.ReadKey(true);
                        if (KeyInfoss.Key == ConsoleKey.Escape)
                        {
                            goto ANAMENU;
                        }
                        else if (KeyInfoss.Key == ConsoleKey.LeftArrow)
                        {
                            goto MASAİSLEM;
                        }
                        int islem3 = Convert.ToInt32(Console.ReadLine());
                        switch (islem3)
                        {
                            case 1:
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("                     SİPARİŞ EKLE                      ");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Onayla ve Ana Menüye Dön      [0]");
                                MenuUrunListele();

SİPARİSEKLE:
                                Console.WriteLine("Ürün eklemek için ürün ID giriniz: ");
                                int c=Convert.ToInt32(Console.ReadLine());
                                switch (c)
                                {
                                    case 1:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a==item.masano)
                                            {
                                                item.kofte += 1;
                                            }
                                        }
                                        Console.WriteLine("Köfte Eklendi!");
                                        goto SİPARİSEKLE;

                                    case 2:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a==item.masano)
                                            {
                                                item.pilav += 1;
                                            }
                                        }
                                        Console.WriteLine("Pilav Eklendi!");
                                        goto SİPARİSEKLE;
                                    case 3:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a==item.masano)
                                            {
                                                item.pizza += 1;
                                            }
                                        }
                                        Console.WriteLine("Pizza Eklendi!");
                                        goto SİPARİSEKLE;
                                    case 4:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a== item.masano)
                                            {
                                                item.ayran += 1;
                                            }
                                        }
                                        Console.WriteLine("Ayran Eklendi!");
                                        goto SİPARİSEKLE;
                                    case 5:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a == item.masano)
                                            {
                                                item.cola += 1;
                                            }
                                        }
                                        Console.WriteLine("Coca Cola Eklendi!");
                                        goto SİPARİSEKLE;
                                    case 6:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a == item.masano)
                                            {
                                                item.sprite += 1;
                                            }
                                        }
                                        Console.WriteLine("Sprite Eklendi!");
                                        goto SİPARİSEKLE;
                                    case 0:
                                        goto ANAMENU;

                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("                     SİPARİŞ SİL                       ");
                                Console.WriteLine("-------------------------------------------------------");
                                MenuUrunListele();
                                Console.WriteLine("Onayla ve Ana Menüye Dön      [0]");
                                Console.WriteLine("-------------------------------------------------------");
                                int b = Convert.ToInt32(Console.ReadLine());
                                Masa.Masaurunlistele(b);
SİPARİSSİL:
                                
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Ürün silmek için ürün ID giriniz: ");
                                Console.WriteLine("-------------------------------------------------------");

                                int z = Convert.ToInt32(Console.ReadLine());
                                switch (z)
                                {
                                    case 1:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a==item.masano)
                                            {
                                                item.kofte -= 1;
                                            }
                                        }
                                        Console.WriteLine("Köfte silindi!");
                                        goto SİPARİSSİL;
                                    case 2:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a==item.masano)
                                            {
                                                item.pilav -= 1;
                                            }
                                        }
                                        Console.WriteLine("Pilav silindi!");
                                        goto SİPARİSSİL;
                                    case 3:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a == item.masano)
                                            {
                                                item.pizza -= 1;
                                            }
                                        }
                                        Console.WriteLine("Pizza silindi!");
                                        goto SİPARİSSİL;
                                    case 4:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a == item.masano)
                                            {
                                                item.ayran -= 1;
                                            }
                                        }
                                        Console.WriteLine("Ayran silindi!");
                                        goto SİPARİSSİL;
                                    case 5:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a == item.masano)
                                            {
                                                item.cola -= 1;
                                            }
                                        }
                                        Console.WriteLine("Coca Cola silindi!");
                                        goto SİPARİSSİL;
                                    case 6:
                                        foreach (Masa item in masaList)
                                        {
                                            if (a == item.masano)
                                            {
                                                item.sprite -= 1;
                                            }
                                        }
                                        Console.WriteLine("Sprite silindi!");
                                        goto SİPARİSSİL;
                                    case 0:
                                        goto ANAMENU;
                                }
                                break;
                            case 0:
                                goto ANAMENU;                      
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("                     MASA HESAP                        ");
                        Console.WriteLine("-------------------------------------------------------");
                        Masalar();
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Onayla ve Ana Menüye Dön      [0]");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Hesap kapatmak için masa ıd'si giriniz");
                        ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                        if (KeyInfo.Key == ConsoleKey.Escape)
                        {
                            goto ANAMENU;
                        }
                        int s = Convert.ToInt32(Console.ReadLine());
                        Masa.MasaFalse(s);
                        Masa.Masaurunlistele(s);
                        Masa.MasaHesap(s);

                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Hesap Öde                     [1]");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Onayla ve Ana Menüye Dön      [0]");
                        int w = Convert.ToInt32(Console.ReadLine());
                        switch (w)
                        {
                            case 1:
                                foreach (Masa item in masaList)
                                {
                                    if (s == item.masano)
                                    {
                                        item.masageliri = (item.kofte * 50) + (item.pilav * 25) + (item.pizza * 55) + (item.ayran * 15) +
                                            (item.cola * 25) + (item.sprite * 25);
                                        Console.WriteLine(item.masano + " .Masa ödenecek tutar: " + item.masageliri + " TL...");
                                    }
                                }

                                break;
                        }
                   





                        



                        //int islem2 = Convert.ToInt32(Console.ReadLine());
                        //switch (islem2)
                        //{
                        //    case 1:
                        //        Console.Clear();
                        //        Masaurunlistele(islem2);
                        //        break;                         
                        //}
                        //Console.WriteLine("-------------------------------------------------------");

                        //Console.WriteLine();
                        //Console.WriteLine("Geri Dön            [sol ok]");
                        //Console.WriteLine("-------------------------------------------------------");

                        //Console.Clear();
                        /*switch (islem2)
                        {
                            case 1:
                                Console.WriteLine("*******************");
                                Console.WriteLine("----SİPARİŞ GÖR----");
                                Console.WriteLine("*******************");
                                Console.WriteLine();
                                break;
                                
                            case 2:
                                Console.WriteLine("********************");
                                Console.WriteLine("----SİPARİŞ EKLE----");
                                Console.WriteLine("********************");
                                break;
                            case 3:
                                Console.WriteLine("***********************");
                                Console.WriteLine("----SİPARİŞ DÜZENLE----");
                                Console.WriteLine("***********************");
                                break;
                            case 4:
                                Console.WriteLine("*******************");
                                Console.WriteLine("----SİPARİŞ SİL----");
                                Console.WriteLine("*******************");
                                break;
                                goto ANAMENU;
                        }
                        break;
                    case 3:
                        Console.WriteLine("------ADİSYON GÖR----------[1]");
                        Console.WriteLine("------BAHŞİŞ EKLE----------[2]");
                        Console.WriteLine("SEÇİMİNİZ\t");

                        int islem3 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (islem3)
                        {
                            case 1:
                                Console.WriteLine("*******************");
                                Console.WriteLine("----ADİSYON GÖR----");
                                Console.WriteLine("*******************");
                                break;
                            case 2:
                                Console.WriteLine("*******************");
                                Console.WriteLine("----BAHŞİŞ EKLE----");
                                Console.WriteLine("*******************");
                                break;
                                goto ANAMENU;
                        }
                        break;
                    case 4:
                        Console.WriteLine("------TOPLAM GELİR----------[1]");
                        Console.WriteLine("------TOPLAM MASA GELİRİ----[2]");
                        Console.WriteLine("SEÇİMİNİZ\t");

                        int islem4 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (islem4)
                        {
                            case 1:
                                Console.WriteLine("********************");
                                Console.WriteLine("----TOPLAM GELİR----");
                                Console.WriteLine("********************");
                                break;
                            case 2:
                                Console.WriteLine("**************************");
                                Console.WriteLine("----TOPLAM MASA GELİRİ----");
                                Console.WriteLine("**************************");
                                break;
                                goto ANAMENU;

                        }*/
                        break;

                }


            }

        }

    }
}
