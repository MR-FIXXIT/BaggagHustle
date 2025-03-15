using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedItemVisual : MonoBehaviour
{
    [SerializeField] private Interactable interactableItem;
    [SerializeField] private GameObject[] visualGameObjects;

    private void Start() {
        Player.Instance.OnSelectItemChanged += Player_OnSelectCounterChanged;
    }

    private void Player_OnSelectCounterChanged(object sender, Player.OnSelectItemChangedEventArgs e) {
        if (e.selectedItem == interactableItem) {
            Show();
        }
        else {
            Hide();
        }
    }

    private void Show() {
        foreach (var visualGameObject in visualGameObjects) {
            visualGameObject.SetActive(true);
        }
    }

    private void Hide() {
        foreach (var visualGameObject in visualGameObjects) {
            visualGameObject.SetActive(false);
        }
    }

    private void OnDestroy() {
        if (Player.Instance != null) {
            Player.Instance.OnSelectItemChanged -= Player_OnSelectCounterChanged;
        }
    }

}
