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
        bool mod2Kontrol=false; // string i�erisine atacak say� olmamas� durumu i�in 
        string mod2ListeString = "";
        bool mod3Kontrol = false; // string i�erisine atacak say� olmamas� durumu i�in 
        string mod3ListeString = "";
        bool mod4Kontrol = false; // string i�erisine atacak say� olmamas� durumu i�in
        string mod4ListeString = "";
        bool mod5Kontrol = false; // string i�erisine atacak say� olmamas� durumu i�in
        string mod5ListeString = "";
        if(sayi1 <= sayi2) //�lk say�n�n ikinci say�dan k���k ve e�it olma durumu
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
            }while (sayi1 <= sayi2); //e�itlenene kadar string i�erisine atacak
        }
        else //ikinci say�n�n birinci say�dan k���k olma durumu
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
            }while (sayi2 <= sayi1); //e�itlenene kadar string i�erisine atacak
        }
        if (mod2Kontrol == false)// string i�erisine att��� say� yok ise girece�i kontrol blo�u
        {
            mod2ListeString += "�kiye tam b�l�nen sayi bulunmamaktad�r.";
        }
        if (mod3Kontrol == false)// string i�erisine att��� say� yok ise girece�i kontrol blo�u
        {
            mod3ListeString += "��e tam b�l�nen sayi bulunmamaktad�r.";
        }
        if (mod4Kontrol == false)// string i�erisine att��� say� yok ise girece�i kontrol blo�u
        {
            mod4ListeString += "D�rde tam b�l�nen sayi bulunmamaktad�r.";
        }
        if (mod5Kontrol == false)// string i�erisine att��� say� yok ise girece�i kontrol blo�u
        {
            mod5ListeString += "Be�e tam b�l�nen sayi bulunmamaktad�r.";
        }
        print("T�m liste : " + listeString);
        print("�kiye b�l�nenler : " + mod2ListeString);
        print("��e b�l�nenler : " + mod3ListeString);
        print("D�rde b�l�nenler : " + mod4ListeString);
        print("Be�e b�l�nenler : " + mod5ListeString);
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
