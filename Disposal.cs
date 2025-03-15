using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disposal : Interactable
{
    public override void Interact(Player player) {
        if (player.isCarryingItem()) {
            //Player is carrying a luggage
            if (player.GetItem().IsFlagged()) {
                //Luggage is flagged
                Debug.Log("Right Luggage Disposed");
            }
            else {
                //Luggage is not flagged
                Debug.Log("Wrong Luggage Disposed");
                player.Strike();
            }

            Destroy(player.GetItem().gameObject);
            player.SetItem(null);
        }
        else {
            //Player is not carrying a luggage
            Debug.Log("Not carrying an item");
        }
    }
}
