using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public int j;
    public double d;
    public string s;
    void concatenar(int i, double e, string t)
    {
        Debug.Log(i + j);
        Debug.Log(d + e);
        Debug.Log(t.ToString() + s.ToString());
    }

	void Start () {

        concatenar(15,4.5,"ro");
	}

}
