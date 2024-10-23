using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double sayı;

            //sayı = 4.85;
            //Console.WriteLine(sayı);
            //Console.Read();

            //Console.WriteLine("*-----* Fiyat Listesi *-----*");
            //Console.WriteLine();

            //double appleprice, orangeprice, strawberryprice, potato, tomato;
            //appleprice = 14.85;
            //orangeprice = 20.95;
            //strawberryprice = 35;
            //potato = 9.74;
            //tomato = 6.35;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + appleprice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangeprice +  " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryprice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potato + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomato + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double applegram, orangegram, strawberrygram, potatogram, tomatogram;

            //applegram = 1.245;
            //orangegram = 2.650;
            //strawberrygram = 0.750;
            //potatogram = 4.859;
            //tomatogram = 3.745;

            //double appletotalprice = applegram * appleprice;
            //double orangetotalprice = orangegram * orangeprice;
            //double strawberrytotalprice = strawberrygram * strawberryprice;
            //double potatototalprice = potatogram * potato;
            //double tomatototalprice = tomatogram * tomato;



            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + appleprice + " - Gramaj: " + applegram + "- Toplam Tutar: " + appletotalprice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangeprice + " - Gramaj: " + orangegram + "- Toplam Tutar: " + orangetotalprice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryprice + " - Gramaj: " + strawberrygram + "- Toplam Tutar: " + strawberrytotalprice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potato + " - Gramaj: " + potatogram + "- Toplam Tutar: " + potatototalprice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomato + " - Gramaj: " + tomatogram + "- Toplam Tutar: " + tomatototalprice);

            //double shoppingtotalprice = appletotalprice + orangetotalprice + strawberrytotalprice + potatototalprice + tomatototalprice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingtotalprice + " TL");


            #endregion

            #region Char Değişkenler 

            //ABCDEFGH
            //DEFG...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';


            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler 
            //Console.WriteLine("**** CSharp hava yolları yolcu bilgisi ****");
            //Console.WriteLine();

            //string passengername, passengersurname, passengerdistrict, passengercity, passengerage, passengeridentitynumber;
            //Console.WriteLine();

            //Console.Write("Yolcu Adı: ");
            //passengername = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengersurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerdistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengercity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerage = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengeridentitynumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengeridentitynumber + "Yolcu Ad Soyad: " + passengername + " " + passengersurname + " " + 
            //    passengerdistrict + " / " + passengercity + " " + passengerage);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC345E

            //int shoesprice, computerprice, chairprice, tvprice; 
            //computerprice = 20000;
            //chairprice = 5000;
            //tvprice = 12000;
            //shoesprice = 1000;

            //int shoescount, computercount, chaircount, tvcount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoescount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computercount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chaircount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvcount = int.Parse(Console.ReadLine());

            //int totalprice = shoescount * shoesprice + computerprice * computercount + chairprice * chaircount + tvprice * tvcount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalprice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
                

            #endregion

            Console.Read();
            

        }
    }
}
