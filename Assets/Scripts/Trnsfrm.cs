using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trnsfrm : MonoBehaviour
{
    public Vector3 yon;
    void Update()
    {
        //GetComponent<Transform>().Translate(yon);
        transform.Rotate(yon);
    }
}
