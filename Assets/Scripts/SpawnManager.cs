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
        //ใช้ GameObject.FindGameObjectWithTag("Player");
        //เพื่อให้หาแค่เฉพาะ Tag ที่เป็น Player เท่านั้น ไม่ต้องมานั้งหา Player ทั้ง Sence อย่าง GameObject.Find("Player");
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
