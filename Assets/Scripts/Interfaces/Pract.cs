using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName="new Pract", menuName="Items/Pract")]
public class Pract : Item
{
    public override void Use(){
        Inventory.instance.updateTitle(ItemName);
        Inventory.instance.updateDescription(description);
    }
    
}
