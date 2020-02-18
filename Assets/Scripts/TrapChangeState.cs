using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapChangeState : MonoBehaviour
{
    public SpriteRenderer spR;
    // Start is called before the first frame update
    void Start()
    {
        spR = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (spR.sprite.name == "Trap0")
        {
            gameObject.tag = "Untagged";

        }
        else if (spR.sprite.name == "Trap1" || spR.sprite.name == "Trap2")
        {
            gameObject.tag = "Trap";

        }

    }
}
