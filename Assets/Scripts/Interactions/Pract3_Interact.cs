using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pract3_Interact : MonoBehaviour, Interactable
{
    public float maxRange {get{return mxRange;}}
    private const float mxRange = 5f;
    public Item item;

    public void OnHoverStart(){
        Debug.Log("Presiona E para ver práctica 3");
    }

    public void OnInteract(){
       LogPract3(9);
       Inventory.instance.AddItem(item);
    }

    public void OnHoverEnd(){
        
    }

    // Complejidad de tiempo: O(n log n) para ordenar, y luego O(n log n) para buscar, por tanto O(n log n)
    // Complejidad de espacio: O(n log n) para ordenar y O(n) luego, ya que solo se crea una copia del vector y se trabaja in place. Por lo tanto O(n log n) 

    public void LogPract3(int targetSum)
    {
        int[] nums = {2,7,11,13,15};
        List<int> numbers = new List<int>(nums);
        List<int> numsTemp = new List<int>(nums);
        List<int> result = new List<int>();
        int i = 0;
        int tempPair;

        numsTemp.Sort();

        while(i<numbers.Count){
            tempPair = numsTemp.BinarySearch(targetSum-numsTemp[i]);
            if(tempPair!=-1){
                result.Add(numbers.IndexOf(numsTemp[i]));
                result.Add(numbers.IndexOf(numsTemp[tempPair]));
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