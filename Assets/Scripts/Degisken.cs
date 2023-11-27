using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degisken : MonoBehaviour
{
    public int intensityDeger;
    void Start()
    {
        intensityDeger = 10;
    }

    private void Update()
    {
        
    }

    public void DegerGoster()
    {
        print("deðer :" + intensityDeger);
    }
}
