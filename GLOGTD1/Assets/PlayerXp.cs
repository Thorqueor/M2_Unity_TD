using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXp : MonoBehaviour {
    public int m_score;
    public AudioManager m_sounds= AudioManager.instance;
    public AudioClip monclip;
    public AudioClip mamusique;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        AudioManager.instance.PlaySound(mamusique);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "coins"){
            AudioManager.instance.PlaySound(monclip);
            Destroy(other.gameObject);
            m_score++;
        }
        
    }
}
