using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public GameObject dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        RemoveDialogue();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RemoveDialogue();
            Time.timeScale = 1;

        }
    }

    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.Dialogue, UseDialogue);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.Dialogue, UseDialogue);
    }

    void UseDialogue(string ID)
    {
        Time.timeScale = 0;
        transform.localScale = Vector3.one;
        string tempText = ((TextAsset)Resources.Load(ID)).text;
        dialogueText.GetComponent<TextMeshProUGUI>().text = tempText;

    }
    void RemoveDialogue()
    {
        transform.localScale = Vector3.zero;
        dialogueText.GetComponent<TextMeshProUGUI>().text = "";

    }
}
