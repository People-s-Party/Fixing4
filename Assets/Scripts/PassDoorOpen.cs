using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassDoorOpen : MonoBehaviour
{
    public string[] needs;
    public bool[] activecount;
    public bool active;
    void Start()
    {
        activecount = new bool[needs.Length];
    }
    void Update()
    {
        bool open =true;
        for (int i = 0; i < activecount.Length; i++)
        {
            if (!activecount[i]) open = false;
        }
        if (!open) active = false;
        else active = true;
    }
    private void OnEnable()
    {
        Messenger.AddListener<string, string>(Events.EnterPlace,Connect);
        Messenger.AddListener<string, string>(Events.EnterPlaceoff, Connectoff);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string, string>(Events.EnterPlace, Connect);
        Messenger.RemoveListener<string, string>(Events.EnterPlaceoff, Connectoff);
    }
    void Connect(string thisname, string thatname)
    {
        if (thisname == name)
            for (int i = 0; i < needs.Length; i++)
            {
                if (thatname == needs[i]) activecount[i] = true;
            }
    }
    void Connectoff(string thisname, string thatname)
    {
        if (thisname == name)
            for (int i = 0; i < needs.Length; i++)
            {
                if (thatname == needs[i]) activecount[i] = false;
            }
    }
}
