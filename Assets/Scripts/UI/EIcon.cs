using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EIcon : MonoBehaviour
{
    private void Start()
    {
        RemoveText();
    }
    private void OnEnable()
    {
        Messenger.AddListener(Events.Interactoff, RemoveText);
        Messenger.AddListener<string>(Events.Interact, PrintText);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener(Events.Interactoff, RemoveText);
        Messenger.RemoveListener<string>(Events.Interact, PrintText);
    }

    void PrintText(string name)
    {
        transform.Find("EName").gameObject.SetActive(true);
        transform.Find("EName").GetComponent<TextMeshProUGUI>().text = name;
        transform.Find("EName").GetComponent<PressedE>().subjectname = name;
    }
    void RemoveText()
    {
        transform.Find("EName").gameObject.SetActive(false);
    }

}