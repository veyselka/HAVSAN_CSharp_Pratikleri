using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSharp
{
    partial class product    /// burada da partial kullanıldı ve aynı isimde iki tane classımızı var
                             ///  mesela burada sadece propertyleri rurualım
    {    
        public string name { get; set; }
        public string model { get; set; }
        public int id { get; set; }

    }
}
