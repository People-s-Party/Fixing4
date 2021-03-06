﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGenerader : MonoBehaviour
{
    public Transform[] PrefabForEvent;
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.EventHappened, MakeEvent);
    }
    private void OnDisable()
    {
        Messenger.AddListener<string>(Events.EventHappened, MakeEvent);
    }
    void MakeEvent(string name)
    {
        if(name == "heart" && transform.name=="Stage1-left")
        {
            Vector3 Place = new Vector3(-4.8f, 2.14f);
            Instantiate(PrefabForEvent[0],Place,Quaternion.identity,transform);
            Messenger.Broadcast<string>(Events.Dialogue, "AfterBraveHeart");
            
        }
        if(name == "BoxGenerader" && transform.name == "Stage3-down")
        {
            Vector3 Place = new Vector3(-4.8f, 2.14f);
            Instantiate(PrefabForEvent[0], Place, Quaternion.identity, transform);
        }
        if (name == "liver" && transform.name == "Stage3-down") 
        {
            Vector3 Place = new Vector3(-9.8f, 1.5f);
            Instantiate(PrefabForEvent[1], Place, Quaternion.identity, transform);
            Messenger.Broadcast<string>(Events.Dialogue, "Darkness");
        }
        if (name == "liver" && transform.name == "Stage3-up")
        {
            Vector3 Place = new Vector3(-9.8f, 1.5f);
            Instantiate(PrefabForEvent[0], Place, Quaternion.identity, transform);
        }
        /*if (name == "CodeH")
        {
            Vector3 Place = new Vector3(-8.0f, -5.75f);
            Instantiate(PrefabForEvent, Place, Quaternion.identity, MainObject);

        }
        if(name == "breadbw")
        {
            Vector3 Place = Vector3.zero;
            Instantiate(PrefabForEvent, Place, Quaternion.identity, MainObject);
        }
        if (name == "key")
        {
            Vector3 Place = Vector3.zero;
            Instantiate(PrefabForEvent, Place, Quaternion.identity, MainObject);
        }*/
    }
}
