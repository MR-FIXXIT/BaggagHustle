using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Item : Interactable
{
    [SerializeField] private float speed;
    [SerializeField] private bool onBelt;

    private bool isFlagged;

    [SerializeField] private List<Texture2D> textureList;

    public Texture2D randomTexture;

    private void Awake() {
        isFlagged = Random.Range(0, 2) == 0;
    }

    private void Start() {
        onBelt = true;

        randomTexture = textureList[Random.Range(0, textureList.Count)];
    }
    private void Update() {
        if (onBelt) { 
            BeltMovement();
        }
    }

    private void BeltMovement() { 
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
    }

    public override void Interact(Player player) {
        if (!player.isCarryingItem()) {
            transform.parent = player.GetItemFollowTransform();
            transform.localPosition = Vector3.zero;

            onBelt = false;
            player.SetItem(this);
        }
    }

    public void DestroySelf() {
       Destroy(gameObject);
    }

    public bool IsFlagged() {
        return isFlagged;
    }
}
