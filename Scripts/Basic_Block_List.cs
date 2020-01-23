using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Block_List", menuName = "Block List")]
public class Basic_Block_List : ScriptableObject
{
    [Tooltip("only can be block gameObjects")]
    [Header("List for Block Types(access with array index)")]
    public GameObject[] basicBlocks;
    
}
