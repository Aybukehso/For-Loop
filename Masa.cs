using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTORANT
{
    internal class Masa:MENU
    {
        public int masano;
        public bool masadurum;
        public double masageliri;

        public static List<Masa> masaList = new List<Masa>()
        {
                new Masa(){masano=1,masadurum=false,kofte=0,pilav=0,pizza=0,ayran=0,cola=0,sprite=0},
                new Masa(){masano=2,masadurum=false,kofte=0,pilav=0,pizza=0,ayran=0,cola=0,sprite=0},
                new Masa(){masano=3,masadurum=false,kofte=0,pilav=0,pizza=0,ayran=0,cola=0,sprite=0},
                new Masa(){masano=4,masadurum=false,kofte=0,pilav=0,pizza=0,ayran=0,cola=0,sprite=0}
        };
        public static void Masalar()
        {
            foreach (var i in masaList)
            {
                if (i.masadurum==true)
                {
                    Console.WriteLine(i.masano + " :DOLU ");
                }
                else
                {
                    Console.WriteLine(i.masano+ " :BOŞ");
                }
            }
        }
        public static void MenuUrunListele()
        {
            Console.WriteLine("----------------------------MENÜ------------------------------");
            Console.WriteLine("*******ANA YEMEKLER***********************İÇECEKLER***********");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("       1.Kofte : 50 TL                      4.Ayran    : 15 TL    ");
            Console.WriteLine("       2.Pilav : 25 TL                      5.Coca Cola: 25 TL    ");
            Console.WriteLine("       3.Pizza : 55 TL                      6.Sprite   : 25 TL    ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();
        }
        public static void Masaurunlistele(int secim)
        {
            foreach (Masa item in masaList)
            {
                if (secim==item.masano)
                {
                    Console.WriteLine("Köfte: "+item.kofte +" adet"+"\n"+ "Pilav: "+item.pilav+ " adet" + "\n" + "Pizza: " +item.pizza
                        + " adet" + "\n" + "Ayran: " +item.ayran+ " adet" + "\n" + "Coca Cola: "
                        +item.cola+ " adet" + "\n" + "Sprite: " +item.sprite + " adet" );
                    Console.ReadLine();                     
                }
            }
        }
        public static void MasaAc(int secim)
        {
            foreach (Masa item in masaList)
            {
                if (secim == item.masano)
                {
                    item.masadurum = true;
                }
            }
        }
        public static void MasaFalse(int secim)
        {
            foreach (Masa item in masaList)
            {
                if (secim==item.masano)
                {
                    item.masadurum = false;
                    
                }
            }
        }
        public static void MasaHesap(int secim)
        {

            foreach (Masa item in masaList)
            {
                if (secim==item.masano)
                {
                    item.masageliri = (item.kofte * 50) + (item.pilav * 25) + (item.pizza * 55) + (item.ayran * 15) + 
                        (item.cola * 25) + (item.sprite * 25);
                    Console.WriteLine(item.masano + " .Masa ödenecek tutar: " + item.masageliri +" TL...");
                }
            }
        }
    }
}
