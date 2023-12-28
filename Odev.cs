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
        bool mod2Kontrol=false; // string icerisine atacak sayi olmamasý durumu icin 
        string mod2ListeString = "";
        bool mod3Kontrol = false; // string icerisine atacak sayi olmamasý durumu icin 
        string mod3ListeString = "";
        bool mod4Kontrol = false; // string icerisine atacak sayi olmamasý durumu icin
        string mod4ListeString = "";
        bool mod5Kontrol = false; // string icerisine atacak sayi olmamasý durumu icin
        string mod5ListeString = "";
        if(sayi1 <= sayi2) //Ilk sayinin ikinci sayidan kucuk ve esit olma durumu
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
            }while (sayi1 <= sayi2); //esitlenene kadar string icerisine atacak
        }
        else //ikinci sayinin birinci sayidan kucuk olma durumu
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
            }while (sayi2 <= sayi1); //esitlenene kadar string icerisine atacak
        }
        if (mod2Kontrol == false)// string icerisine attigi sayi yok ise girecegi kontrol blogu
        {
            mod2ListeString += "Ikiye tam bolunen sayi bulunmamaktadir.";
        }
        if (mod3Kontrol == false)// string icerisine attigi sayi yok ise girecegi kontrol blogu
        {
            mod3ListeString += "Uce tam bolunen sayi bulunmamaktadir.";
        }
        if (mod4Kontrol == false)// string icerisine attigi sayi yok ise girecegi kontrol blogu
        {
            mod4ListeString += "Dorde tam bolunen sayi bulunmamaktadir.";
        }
        if (mod5Kontrol == false)// string icerisine attigi sayi yok ise girecegi kontrol blogu
        {
            mod5ListeString += "Bese tam bolunen sayi bulunmamaktadir.";
        }
        Debug.Log("Tum liste : " + listeString);
        Debug.Log("Ikiye bolunenler : " + mod2ListeString);
        Debug.Log("Uce bolunenler : " + mod3ListeString);
        Debug.Log("Dorde bolunenler : " + mod4ListeString);
        Debug.Log("Bese bolunenler : " + mod5ListeString);
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
