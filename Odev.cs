using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Odev : MonoBehaviour
{

    void bolenleriBul(int sayi1, int sayi2)
    {
        string listeString = "";
        bool mod2Kontrol=false; // string içerisine atacak sayý olmamasý durumu için 
        string mod2ListeString = "";
        bool mod3Kontrol = false; // string içerisine atacak sayý olmamasý durumu için 
        string mod3ListeString = "";
        bool mod4Kontrol = false; // string içerisine atacak sayý olmamasý durumu için
        string mod4ListeString = "";
        bool mod5Kontrol = false; // string içerisine atacak sayý olmamasý durumu için
        string mod5ListeString = "";
        if(sayi1 <= sayi2) //Ýlk sayýnýn ikinci sayýdan küçük ve eþit olma durumu
        {
            do
            {
                listeString += " / " + sayi1.ToString();
                if (sayi1 % 2 == 0)
                {
                    mod2ListeString += " / " + sayi1.ToString();
                    mod2Kontrol = true;
                }
                if (sayi1 % 3 == 0)
                { 
                    mod3ListeString += " / " + sayi1.ToString();
                    mod3Kontrol = true;
                }
                if (sayi1 % 4 == 0)
                {
                    mod4ListeString += " / " + sayi1.ToString();
                    mod4Kontrol = true;
                }
                if (sayi1 % 5 == 0)
                {
                    mod5ListeString += " / " + sayi1.ToString();
                    mod5Kontrol = true;
                }
                sayi1++;
            }while (sayi1 <= sayi2); //eþitlenene kadar string içerisine atacak
        }
        else //ikinci sayýnýn birinci sayýdan küçük olma durumu
        {
            do
            {
                listeString += " / " + sayi2.ToString();
                if (sayi2 % 2 == 0)
                {
                    mod2ListeString += " / " + sayi2.ToString();
                    mod2Kontrol = true;
                }
                if (sayi2 % 3 == 0)
                {
                    mod3ListeString += " / " + sayi2.ToString();
                    mod3Kontrol = true;
                }
                if (sayi2 % 4 == 0)
                {
                    mod4ListeString += " / " + sayi2.ToString();
                    mod4Kontrol = true;
                }
                if (sayi2 % 5 == 0)
                {
                    mod5ListeString += " / " + sayi2.ToString();
                    mod5Kontrol = true;
                }
                sayi2++;
            }while (sayi2 <= sayi1); //eþitlenene kadar string içerisine atacak
        }
        if (mod2Kontrol == false)// string içerisine attýðý sayý yok ise gireceði kontrol bloðu
        {
            mod2ListeString += "Ýkiye tam bölünen sayi bulunmamaktadýr.";
        }
        if (mod3Kontrol == false)// string içerisine attýðý sayý yok ise gireceði kontrol bloðu
        {
            mod3ListeString += "Üçe tam bölünen sayi bulunmamaktadýr.";
        }
        if (mod4Kontrol == false)// string içerisine attýðý sayý yok ise gireceði kontrol bloðu
        {
            mod4ListeString += "Dörde tam bölünen sayi bulunmamaktadýr.";
        }
        if (mod5Kontrol == false)// string içerisine attýðý sayý yok ise gireceði kontrol bloðu
        {
            mod5ListeString += "Beþe tam bölünen sayi bulunmamaktadýr.";
        }
        print("Tüm liste : " + listeString);
        print("Ýkiye bölünenler : " + mod2ListeString);
        print("Üçe bölünenler : " + mod3ListeString);
        print("Dörde bölünenler : " + mod4ListeString);
        print("Beþe bölünenler : " + mod5ListeString);
    }
    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(7, 77);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
