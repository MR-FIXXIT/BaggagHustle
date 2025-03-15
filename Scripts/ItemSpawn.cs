using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject luggagePrefab;
    [SerializeField] private float spawnRate = 1f;

    private void OnEnable() {
        float firstTime = 1f;
        InvokeRepeating(nameof(Spawn), firstTime, spawnRate);
    }       

    private void OnDisable() {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn() {
        Instantiate(luggagePrefab, spawnPoint.position, spawnPoint.localRotation);  
    }
}
