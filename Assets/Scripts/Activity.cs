using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity : MonoBehaviour
{
    public bool reactive;

    private void Start()
    {
        reactive = true;
    }
    private void OnEnable()
    {
        Messenger.AddListener<string, string>(Events.changeScene, changeS);
    }
    void changeS(string name, string playerposition)
    {
        if (name != transform.parent.name)
        {
            reactive = false;
        }
        else
        {
            reactive = true;
        }
    }
}
