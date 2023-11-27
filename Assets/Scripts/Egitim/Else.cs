using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Else : MonoBehaviour
{
    public int can;

    void Start()
    {
        can = 5;
    }

    void Update()
    {
        if (can > 5)
        {
            print("Oyun devam ediyor");
        }
        else
        {
            print("Oyun bitti!");
        }
    }
}
