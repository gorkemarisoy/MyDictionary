using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <T, Z> //T tipli anahtar ve Z tipli değer gönderilecek
    {
        T[] keys;
        Z[] values;

        public MyDictionary()
        {
            keys = new T[0];    //0 elemanlı anahtarlar dizimizi oluşturduk
            values = new Z[0];  //0 elemanlı değerler dizimizi oluşturduk
        }

        public void Add(T key, Z value)
        {
            T[] tempKeys = keys;        //geçici keys
            Z[] tempValues = values;       //geçici values
            keys = new T[keys.Length + 1]; //keys'de 1 yer açtık
            values = new Z[values.Length + 1];  //values'de 1 yer açtık
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];    //eski keysleri atadık
                values[i] = tempValues[i];    //eski valuesleri atadık 
            }
            
            keys[keys.Length - 1] = key;    //yeni gönderilen keyi yazdık
            values[values.Length - 1] = value;  //yeni gönderilen values yazdık
        }

        public void Listele()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Öğ.No    :" +keys[i]);
                Console.WriteLine("Öğ.Ad Soyad  :"+values[i]);
            }

            
        }
    }
}
