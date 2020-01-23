using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName =" New Terrian Object",menuName = "Terrian Object(Chunk Block)")]
//to help break uo the code more think i will make terrain objects of 8 chunks.
//hopefully this will help in the future when i start adding biomes, that way i could assign terrain chunks to biomes 
public class Terrain_Object : ScriptableObject
{
    [Header("Chunk Grid Variables")]
    [Tooltip("chunk scriptable object to clone")]
    public Chunk chunk;
    [Tooltip("Chunk grid size (8 probably good)")]
    public int gridSize;
    [Header("Starting Pos of Draw")]
    public int startX;
    public int startZ ;
    [SerializeField]
    [Tooltip("Array size value to decide every starting block hight")]
    public int[] perlinSurfaceArray;

    public void drawFlatTerrain()
    {
        Chunk NewChunk;
        GameObject chunkRef = new GameObject("Chunk_");
        NewChunk = Instantiate(chunk);
    }
    


}
