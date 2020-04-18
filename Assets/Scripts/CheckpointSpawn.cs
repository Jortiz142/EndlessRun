using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSpawn : MonoBehaviour
{
    private float checkpointStartDelay = 5;
    private float checkpointRepeatRate = 5;
    public GameObject checkpointPrefab;
    private Vector3 checkpointSpawnPos = new Vector3(25, 6, 0);
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnCheckpoint", checkpointStartDelay, checkpointRepeatRate);
    }
    void SpawnCheckpoint()
    {
        if (playerControllerScript.gameOver == false && playerControllerScript.finished == false)
        {
            Instantiate(checkpointPrefab, checkpointSpawnPos, checkpointPrefab.transform.rotation);
            checkpointRepeatRate++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
