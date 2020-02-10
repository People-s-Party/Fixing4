using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 StartPostion;
    public float PlayerSpeed;
    void Start()
    {
        transform.position = Vector3.MoveTowards(transform.position, StartPostion, 10000);
    }

    void Update()
    {       
        Vector3 playerposition = transform.position;
        float MoveX = 0;
        float MoveY = 0;
        if (Input.GetKey(KeyCode.W))
        {            
            MoveY += Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveY -= Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveX -= Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveX += Time.deltaTime * PlayerSpeed;
        }
        //if (playerposition.x + MoveX <= -8 || playerposition.x + MoveX >= 8.5) MoveX = 0;
        //if (playerposition.y + MoveY <= -4.5 || playerposition.y + MoveY >= 3) MoveY = 0;
        if (MoveX!=0)transform.Translate(MoveX, 0, 0);
        else transform.Translate(0, MoveY, 0);
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Messenger.Broadcast(Events.Interactoff);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Interface")
        {
            Messenger.Broadcast<string>(Events.Interact, collision.gameObject.name);
        }
    }
}
