using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    public Item item;
    public void Use(){
        if (item){
            item.Use();
        }
    }

    public void updateInfo(){
        Text displayText = transform.Find("Text").GetComponent<Text>();
        Image displayImg = transform.Find("Image").GetComponent<Image>();
        if (item){
            displayText.text = item.ItemName;
            displayImg.sprite = item.icon;
            displayImg.color = Color.white;
        }else{
            displayText.text = "";
            displayImg.sprite = null;
            displayImg.color = Color.clear;
        }
    }
}
