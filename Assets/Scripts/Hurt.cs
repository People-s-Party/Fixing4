using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    public float speedTemp;
    public Sprite deadSprite;
    public Sprite oriSprite;
    // Start is called before the first frame update
    void Start()
    {
        oriSprite = GameObject.Find("PlayerSprite").GetComponent<SpriteRenderer>().sprite;
        speedTemp = GetComponent<Character>().PlayerSpeed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            Hurting();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Hurting();
        }
    }
    void Hurting()
    {
        GameObject.Find("PlayerSprite").GetComponent<SpriteRenderer>().sprite = deadSprite;
        GetComponent<AudioSource>().Play();
        GetComponent<Character>().PlayerSpeed = 0;
        Invoke("WhiteAgain", 0.2f);
    }
    void WhiteAgain()
    {
        GameObject.Find("PlayerSprite").GetComponent<SpriteRenderer>().sprite = oriSprite;
        transform.position = GetComponent<Character>().StartPostion;
        GetComponent<Character>().PlayerSpeed = speedTemp;

    }
}
