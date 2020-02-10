using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSprite : MonoBehaviour
{
    public Sprite[] sprites;
    private int num = 0;

    // Update is called once per frame
    void Start()
    {
        spriteChange();
    }
    void spriteChange()
    {
        if (num < 18) Invoke("spriteChange", 0.75f);
        else Invoke("quit", 3f);
        GetComponent<SpriteRenderer>().sprite = sprites[num];
        num += 1;
    }
    void quit()
    {
        Application.Quit();
    }
}
