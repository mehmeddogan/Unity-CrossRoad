using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Terrain Data",menuName ="Terrain Data")]
public class TerrainData : ScriptableObject
{
    public List<GameObject> PossibleTerrain=new List<GameObject>();
    public int maxInSuccession;

}
