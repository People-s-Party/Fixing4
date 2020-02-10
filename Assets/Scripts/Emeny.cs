using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 StartPostion;
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
            MoveY += Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveY -= Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveX -= Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveX += Time.deltaTime * speed;
        }
        if (MoveX != 0) transform.Translate(MoveX, 0, 0);
        else transform.Translate(0, MoveY, 0);
    }
}
