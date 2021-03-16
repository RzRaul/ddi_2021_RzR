using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> inventoryList= new List<Item>();
    public GameObject player;
    public GameObject invPanel;
    public GameObject titlePanel;
    public GameObject uiPanel;
    public static Inventory instance;
    public Text title;

    public Text description;

    // Start is called before the first frame update

    void Start()
    {
        instance = this;
        updatePanelSlots();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updatePanelSlots(){
        int i=0;
        foreach (Transform child in invPanel.transform)
        {
            SlotManager slot = child.GetComponent<SlotManager>();
            if (i<inventoryList.Count){
                slot.item = inventoryList[i];
            }else{
                slot.item = null;
            }
            slot.updateInfo();
            i++;
        }
    }

    public void updateTitle(string txt){
        title.text = txt;
    }

    public void updateDescription(string txt){
        description.text = txt;
    }

    public void AddItem(Item item){
        if(inventoryList.Count<8){
            inventoryList.Add(item);
        }
        updatePanelSlots();
    }
    public void RemoveItem(Item item){
        inventoryList.Remove(item);
        updatePanelSlots();
    }

    public void hideInventory(){
        uiPanel.SetActive(!uiPanel.activeSelf);
    }
}
