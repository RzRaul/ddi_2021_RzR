using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnInteract : MonoBehaviour, Interactable
{
    public float maxRange {get{return mxRange;}}
    private const float mxRange = .7f;

    public void OnHoverStart(){
        Debug.Log("Presiona E para ver práctica 1");
    }

    public void OnInteract(){
        Debug.Log("PRACTICA 2 SCRIPT");
    }

    public void OnHoverEnd(){
    
    }
}
