using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSharp
{
    partial class product      /// burada kullandığımız partial keyword ü başka bir prduct classı yaratabileceğimiz anlamına geliyor
                               /// partial classlar kod karmaşıklığını önlemek için classları bölmeye yarar
    {
        public void method()               // bu class da da saece metodları tuttarım 
                                    // diğer aynı isimli metodda da sadece propertiyleri tuttarım 
        {

        }

        public string method2() 
        {
            return "PARTİAL  veysel";
        }
    }
}
