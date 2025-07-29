using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Matematik; // kendimize ait oluşturduğumu library eklendi .dll

namespace UdemyCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> liste = new List<String> {"veysel","ömer " , "atıf" , "erhan" };
            foreach (String s in liste)
            {
                Console.WriteLine(s);
            }

            // c# strongly-type midir  == evet çünkü aynı tipdeki değerle aynı tipdeki değereler toplanabilir

            int sayi = 5;
            String mesaj = "veysel";
            var deger =sayi + mesaj; // burada var atadığım için int ifadeyide stringe çevirip toplama yapıyor fakat diğer türlü izin vermiyor
            Console.WriteLine(deger);// buda c# ın strongly - type bir dil olduğunu gösterir


            // c# da data type ler nasıl sınıflandırılır
            // 1-) built in data type (gömülü data tipleri) (float int string )
            // 2-) user defined data type (kullanıcı datat tipleri)  (class struct gibi )

            int builtİnDataDtype = 5;


            ornek UserDefinedDataType=new ornek();



            Console.WriteLine("---------------------------------------------------");

            // c#  da int ile Int32 arasında fark varmıdır 
            //  Hayır yoktur int sadece Int32 nin kısa yazılmış halidir 
            // sadece Int16 Int32 Int64 ralarında alanda datat için aayırdığı yer farkı vardır küçük sayılar için Int16 kullanmak optimizasyon için önemlidir
            Console.WriteLine(typeof(int));
             Console.WriteLine(typeof(Int16));

            Int16 sayi1 = 2; //-32 bin ile 32 bin arasında sayıları tutar
            Int32 sayi2 = 3; // -2 milyar ile 2 milyar arasında sayıları tutar
            Int64 sayi3 = 4; // 2 milyardan fazla olan sayılar için data space de yer ayırır
                             // 


            //c# da kaç veri tipi vardır 
            // VALUE TYPE    REFERANCE TYPE
            //Value Type = int - short - float - double - ...
            //Referance Type = String - class - interface ...
            //bunlar arasından şöyle bir fark vardır =
            // value typeler hafızada stack de tutulur ***
            // referance typeler hafızada heap da tutulur ***

            int valueType = 15;
            string referanceType = "veysel kılıçerkan";


            Console.WriteLine("---------------------------------------------------");



            // Propertyle örnekler

            ogrenci O=new ogrenci();
            //O.Name = "Veysel";  sadece okunabilir olduğu için burada değer atayamıyoruz
            O.Surname = "kılıçerkan";
            O.Age = 19;

            Console.WriteLine(O.Name);
              //Console.WriteLine(O.Surname);  sadece yazılabilir olduğundan dolayı burayı ekrana yazdırmaıyoruz
            Console.WriteLine(O.Age);


            Console.WriteLine("---------------------------------------------------");

            // Matematik sınıfının uygulamalrı



            Class1 c = new Class1();
            c.publicveri = 1;  // bu kısımda sadece publicveri ye ulaşabiliyoruz  private ve internal e ulaşamıyoruz




            Console.WriteLine("---------------------------------------------------");



            // C# DA Kaç çeşit tip dönüşümü vardır 
            //  1-) implicit (kapalı) conversion
            //  2-) explicit ( açık ) conversion

            //İMPLİCİT
            int sayi6 = 6;
            long sayi7 = sayi6;  // buarada kapalı bir şekilde tip dönüşümü yapılmıştır ve int den long a yükseltildi

            //EXPLİCİT
            long sayi8 = 455;
            int sayi9 = (int)sayi8 ;  // buarda açık bir şekilde tip dönüşümü var long dan int e döndük hatta veri kaybı yaşayabiliriz



            Console.WriteLine("---------------------------------------------------");

            //BOXİNG UNBOXİNG

            int sayi10 = 45;
            object sayi11 = sayi10;  //boxing işlemi value tipinden referance tipe dönüş

            object sayi12 = 6564;
            int sayi13 = (int)sayi12;  //Unboxing işlemi referance tip den value tipe dönüş veri kaybı oluşabilir


            //CASTİNG CASTİNG CASTİNG   EXPLİCİT İLE AYNI

            long sayi14 = 6555;
            int sayai15= Convert.ToInt32(sayi12); // bu şekilde de casting yapılabilir


            Console.WriteLine("---------------------------------------------------");


            //int.parse()  işlemi ile int.tryParse()  işlemi arasındaki fark  

            string veri = "10"; 

            int sayi16= int.Parse(veri);  //int.parse()  işleminde hata varsa hata verir 

            Console.WriteLine(sayi16);

            int result;

            bool sayi17 = int.TryParse(veri, out result);  // bool tanımlamamızın sebebi tryparse metodunda eğer dönüşüm gerçekleştiyse 
                                                           // true dönecektir dönüştürme olmadıysa false dönecektir
                                                           //ilk olarak string değeri veriyoruz sonra ise OUT parametresiyle neraber 
                                                           //hangi değişkene atanacaksa onu veriyoruz 

            Console.WriteLine(sayi17); // truemi false mi
            Console.WriteLine(result); // değer ney

            Console.WriteLine("---------------------------------------------------");




            //CONST veritipi ne işe yarar 
            // hem derleme hem de yorumlama zamanında değişkenin değişmesinin önüne geçer
            // referance tiplere uygulanamaz sadece value tiplere

            const double pI= 3.14; 


            // readonly   ile   const arasındaki fark 
            // readonly sadece nesne üzerinden ulaşılabilir

            






        }
    }





    class ornek
    {

    }






    //propertyler
    class ogrenci
    {
        // il buarad tanımladıklarım field 
        private string _name = "veysel";
        private string _surname;
        private int _age;
        // bunlar private olduğu için bunları kapsullaeyip dış alana sınırlı erişim olarak açmam lazım 

        public string Name { get { return _name.ToUpper(); }  }  // sadece get metdou var yani sadece okunabilir

        public string Surname { /*get { return _surname.ToUpper(); }*/ set { _surname = value; } }  // sadece yazılabilir okunamaz 

        public int Age { 
            get {                                 // hem get i var hem seti var hem okunabilir hem de yazılabilri
                return _age;
            } 
            set {
                if (value > 20)
                {
                    throw new Exception("Yaş 20 den büyük olamaz");
                }

                _age = value;
            } }

    }
}
