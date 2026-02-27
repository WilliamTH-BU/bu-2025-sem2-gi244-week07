using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    public PlayerController player;
    public GameObject playerGo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerGo = GameObject.FindGameObjectWithTag("Player");
        player = playerGo.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGameOver == false)
        {
            transform.Translate( speed * Vector3.left * Time.deltaTime);
        }
    }
}
