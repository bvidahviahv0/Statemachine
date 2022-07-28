using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAgent : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionToPlayer = player.transform.position - transform.position;

        directionToPlayer.Normalize();
        directionToPlayer *= speed * Time.deltaTime;

        transform.position += (Vector3)directionToPlayer;
    }
}
