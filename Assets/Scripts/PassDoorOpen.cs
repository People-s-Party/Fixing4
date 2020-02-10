using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassDoorOpen : MonoBehaviour
{
    public string[] needs;
    public bool[] activecount;
    public string doorname;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        activecount = new bool[needs.Length];
    }

    // Update is called once per frame
    void Update()
    {
        bool open =true;
        foreach (bool i in activecount)
        {
            if (!i) open = false;
        }
        if (open) active = true;
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
        if (thisname == doorname) 
            for (int i = 0; i < needs.Length; i++)
            {
                if (thatname == needs[i]) activecount[i] = true;
            }

    }
    void Connectoff(string thisname, string thatname)
    {
        if (thisname == doorname)
            for (int i = 0; i < needs.Length; i++)
            {
                if (thatname == needs[i]) activecount[i] = false;
            }
    }

}
