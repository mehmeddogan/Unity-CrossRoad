using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCar : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private float minCreateTime;
    [SerializeField] private float maxCreateTime;
    [SerializeField] private Transform createPos;
    private void Start()
    {
        StartCoroutine(CarSpawn());
    }
    private IEnumerator CarSpawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minCreateTime, maxCreateTime));
            Instantiate(car, createPos.position, Quaternion.identity);
        }

    }
}
