using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>(); //MyDictionary newledik. yani iki yeni dizi oluşturdu (keys,values) arkada
            myDictionary.Add(3117,"A.Görkem ARISOY");
            myDictionary.Add(168,"İ.Selin Muratoğlu");

            myDictionary.Listele();
        }
    }
}
