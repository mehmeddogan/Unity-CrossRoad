using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed,koşu;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>(); ///fiziksel özellikleri alınmış

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(koşu*Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0, 0, -speed*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
