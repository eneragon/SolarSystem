using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vektorler : MonoBehaviour
{
    Vector2 vec, vec2, son;
    void Start()
    {
        //vec.x = 1;
        //vec.y = 1;
        //print(vec);
        vec = new Vector2(5, 3);
        vec2 = new Vector2(5, 7);
        son = vec + vec2;
        print(son);
    }
}
