using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicandPrivate : MonoBehaviour
{
    // Start is called before the first frame update

    public int can;
    public int ilave_can;
    int son_can;
    float sicaklik;
    public bool oyunBittiMi = false;

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
