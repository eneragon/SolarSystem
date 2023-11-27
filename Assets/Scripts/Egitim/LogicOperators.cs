using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour
{
    public int sayi1, sayi2;
    public string isim;
    public bool evliMi;
    void Start()
    {
        sayi1 = 10;
        sayi2 = 20;
        isim = "enes";
        evliMi = false;
    }

    void Update()
    {
        //ve logic mantýðý &&
        if (sayi1<sayi2 && isim =="enes")
        {
            print("Sayý1 sayý2 den küçük ve isim enes");
        }
        else
        {
            print("önermenin içerisinden biri yanlýþ veya ikisi de yanlýþ");
        }

        // veya logic mantýðý || örnepi en az ikisinden biri doðruysa
        if (sayi1 < sayi2 || isim == "enes")
        {
            print("--- Sayý1 sayý2 den küçük veya ikisi de yanlýþ");
        }
        else
        {
            print("--- önermenin ikisi de yanlýþ");
        }
        if (evliMi)
        {
            print("Evli");
        }
        else
        {
            print("Evli deðil");
        }
    }
}
