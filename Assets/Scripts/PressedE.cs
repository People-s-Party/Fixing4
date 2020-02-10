using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedE : MonoBehaviour
{
    public string subjectname="";
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Messenger.Broadcast<string>(Events.Epressed, subjectname);
        }
    }
}
