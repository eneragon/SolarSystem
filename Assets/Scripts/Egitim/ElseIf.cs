using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseIf : MonoBehaviour
{
    private int can;

    void Start()
    {
        can = 5;
    }

    void Update()
    {

        //DURUM 1
        if(can>3)
        {
            print("Oyun devam ediyor");
        }
        else if (can == 3)
        {
            print("3 cana �zel 2 puan");
        }
        else if(can > 0)
        {
            print("0-3 aras� �zel durum");
        }
        else
        {
            print("Oyun bitti");
        }

        //DURUM 2
        if(can == 5)
        {
            print("----- 5 e �zel bir durum var");
        }
        else
        {
            print("----- �zel bir durum yok");
        }
    }
}
