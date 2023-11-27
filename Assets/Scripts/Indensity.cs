using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indensity : MonoBehaviour
{
    //public GameObject kup;
    public Light isik;
    void Start()
    {
        
    }

    private void Update()
    {
        GetComponent<Light>().intensity = 7;
       //kup.GetComponent<Light>().intensity = GetComponent<Degisken>().intensityDeger;
       //GetComponent<Degisken>().DegerGoster();
    }
}
