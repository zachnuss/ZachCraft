using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Chunk", menuName ="Chunk")]
public class Chunk : ScriptableObject
{
    public Basic_Block_List chunkBuildingBlocks;
    [Header("Chunk Left Down Corner Coords")]
    public int Xposition;
    public int Zposition;
    [Header("Chunk Array Locator (X,Z,Y)")]
    public GameObject[ , , ] chunkBlocks;

    

    public void createFlatChunk( int maxHight,int startX,int startZ)
    {
        //chunks always are the same size 16x16x256
        chunkBlocks = new GameObject[16,16,256];
        //ints to keep track of loop position
        int X, Y, Z;
        for (Y = 0; Y < maxHight; Y++)
        {
            for ( X = 0; X < startX +16; X++)
            {
                for ( Z = 0; Z < 16; Z++)
                {
                    //creating block in the space
                    GameObject newBlock = null;
                    
                    if(Y == maxHight - 1)
                    {
                        newBlock = Instantiate(chunkBuildingBlocks.basicBlocks[0]);
                    }
                    else if(Y >= maxHight - 4)
                    {
                        newBlock = Instantiate(chunkBuildingBlocks.basicBlocks[1]);
                    }
                    else if (Y < maxHight - 4)
                    {
                        newBlock = Instantiate(chunkBuildingBlocks.basicBlocks[2]);
                    }
                    
                    chunkBlocks[X, Z, Y] = newBlock;
                    newBlock.transform.position = new Vector3(startX+X, Y, startZ+Z);
                    newBlock.GetComponent<_Block>().setFacesFalse();
                    if (X == 0)
                    {
                        newBlock.GetComponent<_Block>().xNegVisable();
                    }
                    if (X == 15)
                    {
                        newBlock.GetComponent<_Block>().xPosVisable();
                    }
                    if (Z == 0)
                    {
                        newBlock.GetComponent<_Block>().zNegVisable();
                    }
                    if (Z == 15)
                    {
                        newBlock.GetComponent<_Block>().zPosVisable();
                    }
                    if (Y == 0)
                    {
                        newBlock.GetComponent<_Block>().bottemVisable();
                    }
                    if (Y == maxHight-1)
                    {
                        newBlock.GetComponent<_Block>().topVisable();
                    }
                    if (!newBlock.GetComponent<_Block>().areFacesActive())
                    {
                        newBlock.SetActive(false);
                    }



                }
               
            }
            
        }
    }
}
