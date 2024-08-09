using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstConstructor
{
    internal class Bebek
    {
        /*
        Bu örnekte sizlerden bir Bebek sınıfı tanımlamanız isteniyor.
        Bebek sınıfının propertyleri -> Doğum Tarihi, Ad , Soyad
        Bebek sınıfı için 2 adet constructor tanımlayınız.
        1.si Default Constructor tarzında parametre almayan bir metot.
        2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
        2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.
        Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız.
        */
        private string name; // name field
        private string surName; // surName field
        private DateTime birthdate; // birthdate field

        public string Name // Name property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string SurName // SurName property
        {
            get
            {
                return surName;
            }
            set
            {
                surName = value;
            }
        }

        public DateTime Birthdate // Birthdate property
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        public Bebek() // Default Constructor
        {
            Console.WriteLine("Ingaa");
            birthdate = DateTime.Now;
        }

        public Bebek(string a,string b) // 2 string parametresi alan Constructor
        {
            Console.WriteLine("Ingaa");
            birthdate = DateTime.Now;
            name = a;
            surName = b;
        }

        public void TellInfo()
        {
            Console.WriteLine($"Bebeğin adı {name} soyadı {surName} doğum tarihi {birthdate.ToString("dd.MM.yyyy")}"); // Çağrıldığı zaman nesne bilgilerini döner
        }
    }
}
