using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XrayHUD : MonoBehaviour
{
    [SerializeField] private Image image;
    public void ChangeSprite(Texture2D texture) {
        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }
}
