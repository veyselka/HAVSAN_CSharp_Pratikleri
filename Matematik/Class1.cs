using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Class1
    {
        public int publicveri { get; set; }  //her yerden ulaşılabilir 

        private int privateveri { get; set; }  //sadece tanınmlandığı sınıf içinde kullanılabilir

        internal int internalveri { get; set; }  
        // git
        protected int protectedveri { get; set; }   //sadece sınıftan kalıtım alındığında kullanılabilen access modify

        void topla()
        {

        }
    }

    class Class2
    {
        void hesapla()
        {
            Class1 c = new Class1();
            c.internalveri = 5;  //farklı classdan erişim var aslında her yerden erişim var çünli public
            c.publicveri = 51;  // farklı calssdan erişim var tanımlandığı class içinden de erişim var fakat diğer türlü erişim yok
            // private zaten sadece tanımlı olduğu class içinden erişilebilir başka yok
            
        }
    }

    // diğer projenin referanslarına add referance ile eklendi gerisi UdemyCSharp dan devam edilecek
}
