using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCol : MonoBehaviour
{
    void Start()
    {
        print(GetComponent<BoxCollider>().bounds.max.y);
    }

}
