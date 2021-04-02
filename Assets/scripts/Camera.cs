using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    float x,z;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.transform.position.x+x, transform.position.y, target.transform.position.z), cameraSpeed);
    }
}
