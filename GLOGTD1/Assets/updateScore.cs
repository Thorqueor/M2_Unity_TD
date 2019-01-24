using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour {
    public PlayerXp monxp;
    public Text montexte;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        montexte.text="score :"+monxp.m_score;
		
	}
}
