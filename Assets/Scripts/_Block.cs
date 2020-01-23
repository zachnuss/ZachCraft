using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Block : MonoBehaviour
{
    [Header("All Block GameObject Pieces")]
    [Tooltip("Complete block")]
    public GameObject block;
    [Tooltip("Block faces")]
    public GameObject Ypos,Yneg,Xpos,Xneg,Zpos,Zneg;
    [Header("Block Variables")]
    [Tooltip("Amount of time in Seconds(Modified by pick axe)")]
    public float breakSpeed;

    //sets certain faces active
    public void topVisable()
    {
        Ypos.SetActive(true);
    }
    public void bottemVisable()
    {
        Yneg.SetActive(true);
    }
    public void xPosVisable()
    {
        Xpos.SetActive(true);
    }
    public void xNegVisable()
    {
        Xneg.SetActive(true);
    }
    public void zPosVisable()
    {
        Zpos.SetActive(true);
    }
    public void zNegVisable()
    {
        Zneg.SetActive(true);
    }
    //sets all faces inactive
    public void setFacesFalse()
    {
        Ypos.SetActive(false);
        Yneg.SetActive(false);
        Xpos.SetActive(false);
        Xneg.SetActive(false);
        Zpos.SetActive(false);
        Zneg.SetActive(false);
    }
    //returns false if all faces are false
    public bool areFacesActive()
    {
        if (Ypos.activeSelf == false && Yneg.activeSelf == false && Xpos.activeSelf == false && Xneg.activeSelf == false &&
            Zpos.activeSelf == false && Zneg.activeSelf == false)
            return false;
        else
            return true;
        
       
    }

   
}
