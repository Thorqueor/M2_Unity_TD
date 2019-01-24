using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float m_speed = 100.0f;
    public Sprite m_frontSprite;
    public Sprite m_sideSprite;
    public Sprite m_backSprite;
    public SpriteRenderer m_renderer;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(-m_speed * Time.deltaTime, 0, 0));
            m_renderer.sprite = m_sideSprite;
            m_renderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(m_speed * Time.deltaTime, 0, 0));
            m_renderer.sprite = m_sideSprite;
            m_renderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector3(0, m_speed * Time.deltaTime, 0));
            m_renderer.sprite = m_backSprite;
            m_renderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector3(0, -m_speed * Time.deltaTime, 0));
            m_renderer.sprite = m_frontSprite;
            m_renderer.flipX = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        m_speed = 50.0f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        m_speed = 100.0f;
    }
}
