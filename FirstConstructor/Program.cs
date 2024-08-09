using Microsoft.VisualBasic;
using System;

namespace FirstConstructor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bebek newBaby = new Bebek(); // Default Constructor ile oluşturulan nesne
            newBaby.Name = "Ahmet";
            newBaby.SurName = "Yıldırım";          
            newBaby.TellInfo(); // newBaby nesnesine ait bilgilerin geleceği metot

            Bebek newBaby2 = new Bebek("Serhat", "Yıldız"); // 2 parametre alan Constructor ile oluşturulan nesne
            newBaby2.TellInfo();  // newBaby2 nesnesine ait bilgilerin geleceği metot
        }
    }
}