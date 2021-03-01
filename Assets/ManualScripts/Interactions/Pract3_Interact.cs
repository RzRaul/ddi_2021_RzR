using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pract3_Interact : MonoBehaviour, Interactable
{
    public float maxRange {get{return mxRange;}}
    private const float mxRange = 5f;

    public void OnHoverStart(){
        Debug.Log("Presiona E para ver práctica 3");
    }

    public void OnInteract(){
       LogPract3(9);
    }

    public void OnHoverEnd(){
        
    }

    public void LogPract3(int targetSum)
    {
        int[] nums = {2,7,11,13,15};
        List<int> numbers = new List<int>(nums);
        List<int> result = new List<int>();
        int i = 0;
        int tempPair;

        numbers.Sort();

        while(i<numbers.Count){
            tempPair = numbers.BinarySearch(targetSum-numbers[i]);
            if(tempPair!=-1){
                result.Add(i);
                result.Add(tempPair);
                i=numbers.Count;
            }
            i++;
        }
        printVector(result);
    }

    void printVector(List<int> nums){
            Debug.Log("["+string.Join(", ", nums)+"]");
    }
}