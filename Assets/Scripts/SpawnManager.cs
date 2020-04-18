using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject checkpointPrefab;
    private Vector3 obstacleSpawnPos = new Vector3(25, 0, 0);
    private Vector3 checkpointSpawnPos = new Vector3(25, 6, 0);
    private float obstacleStartDelay = 2;
    private float obstacleRepeatRate = 2;
    private float checkpointStartDelay = 5;
    private float checkpointRepeatRate = 5;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", obstacleStartDelay, obstacleRepeatRate);
        InvokeRepeating("SpawnCheckpoint", checkpointStartDelay, checkpointRepeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false && playerControllerScript.finished == false)
        {
            Instantiate(obstaclePrefab, obstacleSpawnPos, obstaclePrefab.transform.rotation);
            Instantiate(checkpointPrefab, checkpointSpawnPos, checkpointPrefab.transform.rotation);
            checkpointRepeatRate++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
