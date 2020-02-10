using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanges : MonoBehaviour
{
    private void OnEnable()
    {
        Messenger.AddListener<string,string>(Events.changeScene, changeS);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string,string>(Events.changeScene, changeS);
    }
    void changeS(string name,string playerposition)
    {
        if (name == gameObject.scene.name){
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(true);
            }
        }
        else
        {
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(false);
            }
        }
        if (playerposition == "left") GameObject.Find("Player").transform.position = new Vector3(8, 0, 0);
        if (playerposition == "right") GameObject.Find("Player").transform.position = new Vector3(-10, 0, 0);
        if (playerposition == "up") GameObject.Find("Player").transform.position = new Vector3(0, -5, 0);
        if (playerposition == "down") GameObject.Find("Player").transform.position = new Vector3(0, 5, 0);
    }
}
