using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk_Generator : MonoBehaviour
{
    [Header("Basic Chunk Object")]
    public Chunk newChunk;

    private void Awake()
    {
        newChunk.createFlatChunk(60,0,0);
    }
}
