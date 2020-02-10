using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotateSpeed = 2f;
    private Quaternion targetAngels = Quaternion.Euler(0, 0, 0);
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            targetAngels = Quaternion.Euler(0, 0, -90);
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetAngels = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKey(KeyCode.A))
        {
            targetAngels = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetAngels = Quaternion.Euler(0, 0, 180);
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, targetAngels, rotateSpeed * Time.deltaTime);
        if (Quaternion.Angle(targetAngels, transform.rotation) < 1)
        {
            transform.rotation = targetAngels;
        }
    }
}
