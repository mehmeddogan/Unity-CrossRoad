using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private GameObject Takip;
    [SerializeField] private Vector3 mesafe;
    [SerializeField] private float smoothness;
    private void Update()
    {
        if(Takip!=null)
        {
            transform.position = Vector3.Lerp(transform.position, Takip.transform.position + mesafe, smoothness);
        }
    }

}
