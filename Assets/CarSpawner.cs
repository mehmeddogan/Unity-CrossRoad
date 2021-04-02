using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private Transform positionCar;
    [SerializeField] private float minCreateTime;
    [SerializeField] private float maxCreateTime;
    private void Start()
    {
        StartCoroutine(SpawnCar());
    }

    private IEnumerator SpawnCar()
    {
        yield return new WaitForSeconds(Random.Range(minCreateTime,maxCreateTime));
        Instantiate(car, positionCar.position, Quaternion.identity);
    }
}
