using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerate : MonoBehaviour
{
    [SerializeField] private int minDistanceFromPlayer;
    [SerializeField] private int maxTerrainCount;
    [SerializeField] private List<TerrainData> terrainDatas = new List<TerrainData>();
    [SerializeField] private Transform terrainHolder;
    private List<GameObject> currentTerrains = new List<GameObject>();
    [HideInInspector] public Vector3 currentPos = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    private void Start()
    {
        for (int i=0; i < maxTerrainCount ; i++)
        {
            SpawnTerrain(true, new Vector3(0,0,0));
        }
        maxTerrainCount = currentTerrains.Count;
    }

    public void SpawnTerrain(bool isStart, Vector3 PlayerPos)
    {
        //player'ın kullanıcı tarafından belirlenen mesafeye playerın ulasmasından sonra yeni terrainlerinler olusmasına sağlıyor.
        if((currentPos.x - PlayerPos.x < minDistanceFromPlayer) || (isStart))
        {
            int whichTerrain = Random.Range(0, terrainDatas.Count);
            int terrainInSuccession = Random.Range(1, terrainDatas[whichTerrain].maxInSuccession);
            for (int i = 0; i < terrainInSuccession; i++)
            {
                GameObject terrain = Instantiate(terrainDatas[whichTerrain].PossibleTerrain[Random.Range(0, terrainDatas[whichTerrain].PossibleTerrain.Count)], currentPos, Quaternion.identity, terrainHolder);
                currentTerrains.Add(terrain);
                if (!isStart)
                {
                    if (currentTerrains.Count > maxTerrainCount)
                    {
                        Destroy(currentTerrains[0]);
                        currentTerrains.RemoveAt(0);
                    }
                }
                currentPos.x++;
            }
        }
        
        /*
    GameObject terrain = Instantiate(terrains[Random.Range(0, terrains.Count)], currentPos, Quaternion.identity);
    currentTerrains.Add(terrain);
    if(currentTerrains.Count> maxTerrainCount)
    {
        Destroy(currentTerrains[0]);
        currentTerrains.RemoveAt(0); 
    }
    currentPos.x++;*/
    }
}
