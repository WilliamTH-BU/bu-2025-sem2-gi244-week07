using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    //public PlayerController player;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2);
    }

    void Spawn()
    {
        GameObject playerGo = GameObject.FindGameObjectWithTag("Player");
        PlayerController player = playerGo.GetComponent<PlayerController>();
        if (player.isGameOver)
        {
            return;
        }
        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );

    }
}
