using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit) {
        if (hit.TryGetComponent(out Item item)) {
            Debug.Log("Destroyed");
            if (item.IsFlagged()) {
                Debug.Log("Wrong Luggage let go");
                Player.Instance.Strike();
            }
            item.DestroySelf();
        }
    }
}
