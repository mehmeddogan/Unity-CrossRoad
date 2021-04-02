using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private Animator animator;
    private bool isHopping;
    private float puan;
    [SerializeField] private TerrainGenerate terrainGenerator;
    [SerializeField] private Text score;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        puan = transform.position.x * 10;
    }
    /*private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && !isHopping)
        {
            //zıplama animasyonu calıstırır.
            animator.SetTrigger("hop");
            isHopping = true;
            float zDifference = 0;
            if(transform.position.z % 1 != 0)
            {
                zDifference = transform.position.z - Mathf.RoundToInt(transform.position.z + 1);
            }
            transform.position = (transform.position + new Vector3(1, 0, zDifference));
        }
    }
    
    public void FinisHob()
    {
        isHopping = false;
    }*/
    private void Update()
    {
        score.text = "Score:" + puan;
        if (Input.GetKeyDown(KeyCode.W) && !isHopping)
        {
            animator.SetTrigger("hop");
            isHopping = true;
            float zDifference = 0;
            if(transform.position.z % 1 != 0)
            {
                zDifference = Mathf.RoundToInt(transform.position.z) - transform.position.z;
            }
            MoveCharacter(new Vector3(1, 0, zDifference));
        }
        else if(Input.GetKeyDown(KeyCode.A) && !isHopping)
        {
            MoveCharacter(new Vector3(0, 0, 1));
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isHopping)
        {
            MoveCharacter(new Vector3(0, 0, -1));
        }
    }
    
    private void MoveCharacter(Vector3 difference)
    {
        animator.SetTrigger("hop");//animation Idle ile Hop arasnda ki geçiş saglanıyor.
        isHopping = true;
        transform.position = (transform.position + difference);//kullanılan yöne göre hareket etme
        terrainGenerator.SpawnTerrain(false, transform.position);
    }
    public void FinishHop()
    {
        isHopping = false;
    }
}
