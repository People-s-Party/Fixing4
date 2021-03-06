﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterReaction : MonoBehaviour
{
    public string connection;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (GetComponent<Activity>().reactive)
        {
            Messenger.Broadcast<string, string>(Events.EnterPlace, connection, name);
            GetComponent<SpriteRenderer>().color = new Color(0f, 255f, 0f, 1f);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Invoke("exit", 0.1f);
    }
    void exit()
    {
        if (GetComponent<Activity>().reactive)
        {
            Messenger.Broadcast<string, string>(Events.EnterPlaceoff, connection, name);
            GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 1f);
        }
    }
}
