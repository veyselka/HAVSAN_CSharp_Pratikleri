using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Matematik; // kendimize ait oluşturduğumu library eklendi .dll

namespace UdemyCSharp
{
    public class Program
    {

        public static void Main(string[] args)
        {


            List<String> liste = new List<String> { "veysel", "ömer ", "atıf", "erhan" };
            foreach (String s in liste)
            {
                Console.WriteLine(s);
            }

            // c# strongly-type midir  == evet çünkü aynı tipdeki değerle aynı tipdeki değereler toplanabilir

            int sayi = 5;
            String mesaj = "veysel";
            var deger = sayi + mesaj; // burada var atadığım için int ifadeyide stringe çevirip toplama yapıyor fakat diğer türlü izin vermiyor
            Console.WriteLine(deger);// buda c# ın strongly - type bir dil olduğunu gösterir


            // c# da data type ler nasıl sınıflandırılır
            // 1-) built in data type (gömülü data tipleri) (float int string )
            // 2-) user defined data type (kullanıcı datat tipleri)  (class struct gibi )

            int builtİnDataDtype = 5;


            ornek UserDefinedDataType = new ornek();



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

            ogrenci O = new ogrenci();
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
            int sayi9 = (int)sayi8;  // buarda açık bir şekilde tip dönüşümü var long dan int e döndük hatta veri kaybı yaşayabiliriz



            Console.WriteLine("---------------------------------------------------");

            //BOXİNG UNBOXİNG

            int sayi10 = 45;
            object sayi11 = sayi10;  //boxing işlemi value tipinden referance tipe dönüş

            object sayi12 = 6564;
            int sayi13 = (int)sayi12;  //Unboxing işlemi referance tip den value tipe dönüş veri kaybı oluşabilir


            //CASTİNG CASTİNG CASTİNG   EXPLİCİT İLE AYNI

            long sayi14 = 6555;
            int sayai15 = Convert.ToInt32(sayi12); // bu şekilde de casting yapılabilir


            Console.WriteLine("---------------------------------------------------");


            //int.parse()  işlemi ile int.tryParse()  işlemi arasındaki fark  

            string veri = "10";

            int sayi16 = int.Parse(veri);  //int.parse()  işleminde hata varsa hata verir 

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

            const double pI = 3.14;


            // readonly   ile   const arasındaki fark 
            // readonly sadece nesne üzerinden ulaşılabilir







            deneme.nestedtpe d = new deneme.nestedtpe();   //nested type iç içe class tanımlama nın new lenmesi



            ///normalde interfaceler den nesene örneği yaratılamaz 
            ///hangi class taraffından iplement edilmişse onun üzerinden new leme yani nesne örenği yaratılabilir
            IDataIslem dataIslem = new Kırtasiye();  ///gibi




            Console.WriteLine("---------------------------------------------------");




            /// inetrfacelerde explicit (açık) dönüşüm

            IUcgen ucgen = new Sekil();

            ucgen.ciz();

            IKare kare = new Sekil();

            kare.ciz();

            Sekil sekil = new Sekil();
            sekil.ciz();






            Console.WriteLine("---------------------------------------------------");



            ///abstarcat class uygulamaları  
            ///







            İsci isci = new İsci("veysel", "kılıçerkan");  // constructor çalıştırma

            isci.yaz();   // ismi yazdırma 



            isci.calis(); // işçi çalıştı yazdırma

            Editor editor = new Editor("atıf", "kan");  // constructor çalıştırma

            editor.yaz();  // ismi yazdırma 

            editor.calis();  // editör çalıştı yazdırma

            Yonetici yonetici = new Yonetici("erhan", "turan");  // constructor çalıştırma

            yonetici.yaz();   // ismi yazdırma 

            yonetici.calis();  // yönetici çalıştı yazdırma






            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");



            mainClass con = new mainClass();  // constructor tanımladığım bir class ı çağırdığımda otomatik olarak ilk 
                                              // constructoru çalışır 



            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");



            ///Partial class için örenekler 
            ///

            product product = new product();

            product.id = 1;    /// hem diğer classdan alabiliyorum

            string yaz = product.method2();    // hemed diğer partial classdan nesne örenği yaratabilirim

            Console.WriteLine(yaz);




            ///parial class lar farklı interfaceleri iplemante edebilir.
            ///interfaceler  de partial olabiliri yani interfacelerde de PARTİAL keyword ü kullanılabiilir
            ///

            ///partial metod da oluşturlabilir 
            ///ama oluşturulan partial metodlardan biri sadece METDUN İMZASI DIR
            ///DİĞER METOD İSE SADECE GÖVDESİDİR
            ///PARTİAL METODLAR OVERRİDE EDİLEMEZ 
            ///SADECE AYNI CLASSLAR İÇİNDE KULLANILABİLİRLER
            ///





            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");



            /// delegate ler metodlara referance sağlarlar
            /// dönüş tipi ise hangi metoda referance vercekse o metodun geri dönüş tipi yazılır 
            /// SİNGLECAST DDELEGATE
            /// MULTİCASTE DELEGATE


            // FullnameDelegate fullnameDelegate = new FullnameDelegate(fullanmeMethod1);


            // public static void fullanmeMethod1(string isim, string soyisim);



            isci1 isci1 = new isci1 { isim = "veysel", soyisim = "kılıçerkan", maas = 1000, tecrube = 1 };
            isci1 isci2 = new isci1 { isim = "ömer", soyisim = "narçiçeği", maas = 2000, tecrube = 2 };
            isci1 isci3 = new isci1 { isim = "erhan", soyisim = "turan", maas = 3000, tecrube = 3 };
            isci1 isci4 = new isci1 { isim = "atıf", soyisim = "kan", maas = 4000, tecrube = 4 };
            isci1 isci5 = new isci1 { isim = "zehra", soyisim = "çelikel", maas = 5000, tecrube = 5 };

            List<isci1> isciler = new List<isci1>();
            isciler.Add(isci1);
            isciler.Add(isci2);
            isciler.Add(isci3);
            isciler.Add(isci4);
            isciler.Add(isci5);


            isci1.maasİlePromosyon(isciler, 4000);
            isci1.tecrubeİlePromosyon(isciler, 3);





            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");

            
            /// event örnekleri
            /// 
            car a = new car();
            a.Model = "Ford";

            a.speedEvent += A_speedEvent;


            for (int i = 50; i < 100; i += 5)
            {
                System.Threading.Thread.Sleep(1000);  /// döngüde her 1000 ms de bir duracak
                a.Speed = i;
                Console.WriteLine("Araç Hızlanıyor = " + i);
            }

            ///out keywordu bir metodda birden fazla değer dönebilir
            ///ref keywordu ise value type leri referance type olmasını sağlar 
            ///yani bir int tanımlandığında bir class gibi davranır ve 
            ///bir kopyasını oluşturmadan direk gönderiri
            ///





        }

        private static void A_speedEvent(int speedValue)
        {
            Console.WriteLine("Araba Hızını Aştı  :::::  anlık hzı durmu =" +speedValue);
        }

        public delegate void speedDelegate(int speedValue);

        public class car
        {
            public event speedDelegate speedEvent;
            private int _speed;

            public string Model { get; set;}
            public int Speed { get => _speed;
                set {
                    if(value > 80 && speedEvent != null)
                    {
                        speedEvent(value);
                    }
                    else
                    {
                        _speed = value;
                    }
                } }




        }

    }
        


    //deleaget ile çözüm


    
        

    public delegate bool promosyonDelegate(isci1 isciler);

    //public static bool maas_promosyon (isci1 i)
    //{
    //    if (i.maas > 3000)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}




    /// <summary>
    /// delegateler classalr dışında imzalı method olarak tanımlanırlar
    /// </summary>
    /// 
    public delegate void FullnameDelegate(string isim , string soyisim);

    /// <summary>
    /// Delegate tanımlanması bu şekilde
    /// </summary>


    /// Delegate örnek için class alısştırması 
    /// 
    public class isci1
    {
        public string isim;
        public string soyisim;
        public int tecrube;
        public int maas;




        ///DELEGATE İLE ÇÖZÜM
        ///

        public static void promosyon(List<isci1> isci1 , promosyonDelegate promosyonDelegate)
        {
            foreach (var item in isci1)
            {
                if (promosyonDelegate(item))
                {
                    Console.WriteLine(item.isim + " " + item.soyisim);
                }
            }
        }





        /// <summary>
        /// NIORMAL ÇÖZÜM
        /// </summary>
        

        public static void maasİlePromosyon(List<isci1> iscis,int maas)
        {
            foreach(var item in iscis)
            {
                if (item.maas > maas)
                {
                    Console.WriteLine(item.isim+" "+item.soyisim);
                }
            }
        }
        public static void tecrubeİlePromosyon(List<isci1> iscis ,int tecrube)
        {
            foreach (var item in iscis)
            {
                if (item.tecrube > tecrube)
                {
                    Console.WriteLine(item.isim + " " + item.soyisim);
                }
            }

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

        public string Name { get { return _name.ToUpper(); } }  // sadece get metdou var yani sadece okunabilir

        public string Surname { /*get { return _surname.ToUpper(); }*/ set { _surname = value; } }  // sadece yazılabilir okunamaz 

        public int Age
        {
            get
            {                                 // hem get i var hem seti var hem okunabilir hem de yazılabilri
                return _age;
            }
            set
            {
                if (value > 20)
                {
                    throw new Exception("Yaş 20 den büyük olamaz");
                }

                _age = value;
            }
        }

    }


    //classlar miras alabilirken structlar miras alamaz

    class uyeclass : ornek          //miras alabilir
    {

    }

    struct uyestruct        //miras alamaz
    {

    }


    //*******default olarak tanımlanan class constructorları yeni bir parametre alan contructor tanımlandığında kaybolur *********

    class deneme
    {
        public String mesaj { get; set; }
        // şuan bir constuructor tanımlamadık ve kendisi default olarak tanımladı deneme() diye
        //ne zamanki parametre alan bir constructor tanımlarız o zaman default olan constructor iptal ve geçersiz olur

        deneme(String mesaj)
        {
            this.mesaj = mesaj;   //gibi
        }


        /////nested type nedir 
        ///class içinde class oluşturmaktır
        public class nestedtpe
        {
            public int sayi { get; set; }
        }
    }


    /// bir class sadece bir class ı miras alabilir fakat
    /// bir class birden fazla interfaceyi miras alabilir
   
    public class ChildClass :BaseClassOne ,mainone , maintwo  //sadece bir class ve birden çok interfaceden miras alabilir
    {

    }
    public interface mainone
    {

    }
    public interface maintwo
    {

    }
    public class BaseClassOne
    {

    }
    public class BaseClassTwo 
    { 

    }

    // interfaceler classlara klavuzluk yaparlar  
    //interface içinde metodalr tanımlanır fakat içleri doldurulmaz içleri miras lan kişi doldurur


    interface IDatayapı
    {

    }


    interface IDataIslem:IDatayapı     //gibi       **********> ///Bir interface başka bir interfaceden miras alabilir*****
    {                                 ///interfacelerin içinde sadece method ve property tanımlanabilir
        void ekle(string veri);        /// ama interface içinde field olamaz sadece property oluşturulabilir
        void sil(string veri);
        string oku(String veriId);
        string güncelle(String veriId);

    }

    class Kırtasiye : IDataIslem   //interfacelerde miras alınmaz iplement edilir yani uygulanır 
    {                               // ben interface içindeki metodları burada doldurmadığım sürece kırmızı yanacak
        public void ekle(string veri)
        {
            throw new NotImplementedException();
        }

        public string güncelle(string veriId)
        {
            throw new NotImplementedException();
        }

        public string oku(string veriId)
        {
            throw new NotImplementedException();
        }

        public void sil(string veri)
        {
            throw new NotImplementedException();
        }
    }



    ///interfacelerden nesne örneği alınamaz yani new lwmw yapılamaz fakat 
    ///implement edilen class tarafından nesne örenği oluşturulabilir
    ///polymorphizm olayı devreye girer
    ///





    ///interfacelerde explicit (açık)  dönüşüm nedir nasıl yaplır
    ///


    public class Sekil : IKare ,IUcgen
    {
        public void ciz()
        {
            Console.WriteLine("şekil çizilmeye başlandı...");
        }
        void IKare.ciz()
        {
            Console.WriteLine("IKare çizilmeye başlandı...");
        }
        void IUcgen.ciz()                                              /// interfacelerdeki ciz metdolerını ayrı ayrı 
                                                                       /// dönüştürme yaptık explicit (açık) dönüşüm
        {
            Console.WriteLine("IUcgen çizilmeye başlandı...");
        }
    }




    interface IKare
    {
        void ciz();
    }

    interface IUcgen
    {
        void ciz();
    }





    //// ABSTRACT classlar kod tekrarını azaltmak için base class görevini görür 
    ///nesne örenği alınmaz 
    ///örenkelerele devam edelim
    /// <summary>
    /// nesne örenği alınmaz  abstract methodlar ve normal metodlar yazılabilir
    /// </summary>

    public abstract class baseKisi    /// Soyut sınıflar STATİC olarak adlandırılamaz kabul edilemez fakat ststic field alırlar
    {

        public int yas;
        public static int ucret;    ///interface içerisinde field tanımlanabilir
        public String isim { get; set; }
        public String soyİsim { get; set; }   //en başta tanımladım base kisi den abstact class olduğundan diğer sınıflara miras giderse direk kullanılabilir

        
        public abstract void calis();   /// buarada yazdığımız abstract netod diğer miras alan class lar tarafından override edilmeli


        /// Soyut sınıflar constructar lara sahip olabilirler amaçları ise ilk değerleri vermek
        /// 
        public baseKisi (string isim ,string soyisim)
        {
            this.isim = isim;
            this.soyİsim = soyisim;
        }

        public void yaz()  // bu method miras alınan claslar tafaından kullanılabilir ama zorunluluk yoktur
        {
            Console.WriteLine(this.isim + " " + this.soyİsim);
        }
    }
    public class İsci : baseKisi 
    {
        public override void calis()  //override method
        {
            Console.WriteLine("isci sınıfı çalıştı...");
        }

        public İsci(string isim, string soyisim) : base(isim, soyisim)
        {
            Console.WriteLine("isçinin constructo u çalıştı");
        }
    }
    public class Editor : baseKisi
    {
        public Editor(string isim, string soyisim) : base(isim, soyisim)
        {
            Console.WriteLine("editörün constructo u çalıştı");
        }

        public override void calis()   //override method
        {
            Console.WriteLine("editör sınıfı çalıştı...");
        }
        public string  tip { get; set; }
    }
    public class Yonetici : baseKisi
    {
        public Yonetici(string isim, string soyisim) : base(isim, soyisim)
        {
            Console.WriteLine("yöneticinin constructo u çalıştı");
        }

        public override void calis()    //override method
        {
            Console.WriteLine("yönetici sınıfı çalıştı...");
        }

        public string unvan { get; set; }
    }





    ///Virtual method örnekler  
    ///

    public abstract class baseClass
    {
        public abstract string getProduct(int id);


        public virtual int count(int id)
        {
            return 0;  /// burada da görüldüğü gibi virtual metodların gövdeleri tanımlandığı alanda doldurulabiliyor
                       ///işte abstract tan farkı budu bide override edilmek zorunda değil
        }


    }

    public class subClass : baseClass
    {
        public override string getProduct(int id)
        {
            throw new NotImplementedException();  // abstract olarak basClass da tanımlanan metod burada override edilmek zorunda
                                                   // fakat virtual olarak tanımlanan metod burada override edilmek zorunda değil
        }


    }


    ///***** Eğerki ben yarattığım class dan miras almak istemiyorsam
    ///yeni miras almaya engellemek istiyorsam SEALED class kullanacağım  ÖRNEĞİN
    /// <summary>
    /// ***** Eğerki ben yarattığım class dan miras almak istemiyorsam
    /// </summary>
    /// SEALED METHOD var oda override edilemez method dur


    public sealed class paternClass
    {

    }

    //public class childClass :paternClass       yan taarftaki class kullanılamaz çünki paternClass altında kırmızılık olur 
    //{                                           nedeni ise biz SEALED wordkeyini kullanarak bir erişim sınırlayıcı getirmiş olduk

   // }


    public class base1Class
    {
        public  string Name { get; set; }

        public virtual string getName()
        {
            return Name;
        }

    }

    public class childClass : base1Class 
    {
        public sealed override string getName()         /// bakın burada sealed kullanarak override edilmesinin önüne geçiyoruz
        {
            return Name.ToLower();
        }
    }

    public class childClass1 :childClass
    {
        /// artık buradaki getNmae metodum burada override edilemez
    }



    /// CONSTRUCTOR method lar nelerdir 
    /// 

    public class mainClass
    {
        public mainClass()
        {
            Console.WriteLine("OTOMOTİK OLARAK bu metin çağırıldı");
        }
    }


    /// 1-) default constructor
    /// 2-) Parameterized constructor   parametre alan
    /// 3-) Copy constructor    Örnek olarak mainClass dan pametre alan constructor 
    /// 4-) static constructor   ilk nesne örneği alındığı zaman çalışır başka da çalışmaz  her zaman ilk olarak ststic constructorlar çalışırlar
    /// 5-) private constructor  dışarıdan bir nesne örneği alınmasını istemiyorsak private erişim belirleyicisiyle sınırlandırılır
    /// 




}
