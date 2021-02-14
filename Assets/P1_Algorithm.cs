using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Complejidad O(n^2), es fácil de verlo porque para cada elemento se debe recorrer el vector completo
//comparando 1 a 1, ya que no están ordenados y no se tiene "memoria" de lo recorrido

public class P1_Algorithm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
