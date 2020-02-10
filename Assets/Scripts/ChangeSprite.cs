using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite[] sprites;
    private int num = 0;
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[num];
    }
    public void Changesprite()
    {
        if (num < sprites.Length-1) num += 1;
        else num = 0;
        GetComponent<SpriteRenderer>().sprite = sprites[num];
    }
}
