using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degiskenler2 : MonoBehaviour
{
    // Start is called before the first frame update

    int can;
    int ilave_can;
    int son_can;
    float sicaklik;
    bool oyunBittiMi = false;

    void Start()
    {
        can = 10;
        ilave_can = 3;
        sicaklik = 28.2f;
        print(can);
        
    }

    // Update is called once per frame
    void Update()
    {
        son_can = can + ilave_can;
        print(son_can);
        print(sicaklik);
        print(oyunBittiMi);
    }
}
