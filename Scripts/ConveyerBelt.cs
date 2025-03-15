using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerBelt : MonoBehaviour
{
    [SerializeField] private Renderer targetRenderer;
    [SerializeField] private XrayHUD xrayHUD;

    private void OnTriggerEnter(Collider itemCollider) {
        Item item = itemCollider.GetComponent<Item>();

        targetRenderer.material.SetTexture("_BaseMap", item.randomTexture);
        xrayHUD.ChangeSprite(item.randomTexture);
    }

    private void OnTriggerExit(Collider other) {
        Texture2D whiteTexture = new Texture2D(1, 1);
        whiteTexture.SetPixel(0, 0, Color.white);
        whiteTexture.Apply();

        targetRenderer.material.mainTexture = whiteTexture;
    }
}
