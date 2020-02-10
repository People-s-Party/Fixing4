using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Messenger.AddListener<string,string>(Events.changeScene, PlaySound);
    }

    void PlaySound(string name,string sth)
    {
        Invoke("DoorFinal",0.05f);
    }
    void DoorFinal()
    {
        GetComponent<AudioSource>().Play();        
    }
}
