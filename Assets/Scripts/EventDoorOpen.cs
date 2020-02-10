using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoorOpen : MonoBehaviour
{
    public string doorID;
    void Update()
    {
        if (GameObject.Find(doorID).GetComponent<PassDoorOpen>().active) gameObject.GetComponent<ItemInform>().needName = "";
        else gameObject.GetComponent<ItemInform>().needName = "Qifei";
    }
}
