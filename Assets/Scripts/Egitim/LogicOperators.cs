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
        //ve logic mant��� &&
        if (sayi1<sayi2 && isim =="enes")
        {
            print("Say�1 say�2 den k���k ve isim enes");
        }
        else
        {
            print("�nermenin i�erisinden biri yanl�� veya ikisi de yanl��");
        }

        // veya logic mant��� || �rnepi en az ikisinden biri do�ruysa
        if (sayi1 < sayi2 || isim == "enes")
        {
            print("--- Say�1 say�2 den k���k veya ikisi de yanl��");
        }
        else
        {
            print("--- �nermenin ikisi de yanl��");
        }
        if (evliMi)
        {
            print("Evli");
        }
        else
        {
            print("Evli de�il");
        }
    }
}
