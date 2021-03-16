using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pract1_Interact : MonoBehaviour, Interactable
{
    public float maxRange {get{return mxRange;}}
    private const float mxRange = 5f;
    public Item item;

    public void OnHoverStart(){
        Debug.Log("Presiona E para ver práctica 1");
    }

    public void OnInteract(){
       LogPract1();
       Inventory.instance.AddItem(item);
    }

    public void OnHoverEnd(){
        
    }

    public void LogPract1()
    {
        int[] nums = {8,1,2,2,3};
        int[] result= {0,0,0,0,0};
        int i = 0;
        foreach (var n in nums){
            foreach (var m in nums){
                if(m<n) result[i]++;
            }
            i++;
        }
        printVector(result);
    }

    void printVector(int[] nums){
            Debug.Log("["+string.Join(", ", nums)+"]");
    }
}
