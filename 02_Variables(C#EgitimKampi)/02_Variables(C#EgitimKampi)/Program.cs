using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables_C_EgitimKampi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyat" + applePrice+"TL");
            //Console.WriteLine("---- Portakal Birim Fiyat" + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyat" + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyat" + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyat" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Elmanın Toplam Fiyatı:" + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Elma -" + " Birim Fiyat: " + applePrice + "- Gramaj " + appleGram + " Toplam Tutar :" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -" + " Birim Fiyat: " + orangePrice + "- Gramaj " + orangeGram + " Toplam Tutar :" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -" + " Birim Fiyat: " + strawberryPrice + "- Gramaj " + strawberryGram + " Toplam Tutar :" + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -" + " Birim Fiyat: " + potatoPrice + "- Gramaj " + potatoGram + " Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -" + " Birim Fiyat: " + tomatoPrice + "- Gramaj " + tomatoGram + "  Toplam Tutar :" + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine();
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler
            //abdefgh 
            //her bir karakterin alfbedeki 3 sonraki karakterle değiştirme

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);











            #endregion

            #region Klavyeden Veri Girişleri


            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi*****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdNumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("-----------");
            //Console.WriteLine("Yolcu Tc Kimlik No :"+ passengerIdNumber +" -Yolcu Ad Soyad: " + passengerName +" "+ passengerSurname+"|"+passengerDistrict+"/"+passengerCity);







            #endregion

            #region Klavye Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkbı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());    

            //int totalPrice = shoesCount * shoesPrice + computerCount*computerPrice+chairCount*chairPrice + tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeiz Gereken Tutar: " + totalPrice + "TL");








            #endregion

            #region KLavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2 + exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);












            #endregion

            #region Klavyeden Karakter Girişi
            //char gender;
           
            //gender = char.Parse(Console.ReadLine());
            
            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);






            #endregion 

            Console.ReadLine();


        }
    }
}
