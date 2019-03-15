using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class meintwo : MonoBehaviour {


     public double Cstref = 12;
     public int Pergor = 20;
     public int Perimp = 8;
    
    void Start ()
    {
        soma(12,20,8 );
	}
    void soma(double Cstref, int Pergor, int Perimp)
    {
        double gorjeto = Cstref * ((double)Pergor / 100);
        double imposto = Cstref * ((double)Perimp / 100);
        var custototal = Cstref + gorjeto + imposto;

        Debug.Log(Math.Round(custototal));
    }
    
}
