using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AritmetikOrtalamalar : MonoBehaviour
{

    public int sayi1, sayi2, toplam, fark, carpim, kalan;
    public float bolum;
    void Start()
    {
        sayi1 = 10;
        sayi2 = 20;
    }

    void Update()
    {
        toplam = sayi1 + sayi2;
        fark = sayi1 - sayi2;
        carpim = sayi1 * sayi2;
        bolum = (float)sayi1 / sayi2;
        kalan = sayi1 % sayi2;
        print(sayi1 + "ile " + sayi2 + "n�n toplam� :" + toplam);
        print(sayi1 + "ile " + sayi2 + "n�n fark� :" + fark);
        print(sayi1 + "ile " + sayi2 + "n�n �arp�m� :" + carpim);
        print(sayi1 + "ile " + sayi2 + "n�n b�l�m� :" + bolum);
        print(sayi1 + "ile " + sayi2 + "n�n kalan� :" + kalan);

    }
}
