using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HightLight : MonoBehaviour
{
    public float colorValue = 180;
    public bool flip = false;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("ChangeColor", 0.0f, 0.2f);
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.01f)
        {
            if (flip) colorValue -= 1;
            else colorValue += 1;
            time = 0;
            GetComponent<SpriteRenderer>().color = new Color(colorValue / 255, colorValue / 255, colorValue / 255);
            if (colorValue >= 255 | colorValue <= 160)
            {
                flip = !flip;
            }

        }
    }
}
