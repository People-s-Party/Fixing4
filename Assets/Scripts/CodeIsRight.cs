using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeIsRight : MonoBehaviour
{
    public string rightcode,connection;

    // Update is called once per frame
    void Update()
    {
        if (rightcode == GetComponent<SpriteRenderer>().sprite.name) Messenger.Broadcast<string, string>(Events.EnterPlace, connection, transform.name);
        else Messenger.Broadcast<string, string>(Events.EnterPlaceoff, connection, transform.name);
    }
}
