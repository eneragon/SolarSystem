using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{

    public int can;
    int ilave_can;
    int son_can;
    // Start is called before the first frame update
    void Start()
    {
        can = 10;
        ilave_can = 10;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        son_can = can + ilave_can;
        if(son_can<0)
        {
            print("Oyun bitti");
        }
    }
}
