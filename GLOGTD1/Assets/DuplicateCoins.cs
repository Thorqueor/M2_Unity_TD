using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateCoins : MonoBehaviour {
    public GameObject monObject; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 1000; i++)
        {
            if (i % 15 == 0) { Instantiate(monObject, new Vector3(i * 2.0F, 0, 0), Quaternion.identity); }
            
        }
    }
}
