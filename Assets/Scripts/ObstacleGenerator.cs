using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public Material[] obstacleColors;
    
    private float obstacleSpawnLocation = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DoSpawnObstacle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int obstacleIndex = Random.Range(0, 3);

        GameObject obstacle = Instantiate(obstaclePrefabs[obstacleIndex]) as GameObject;
        
        var tag = "";
        if(obstacleIndex == 0)
        {
            tag = "Red";
        } else if(obstacleIndex == 1)
        {
            tag = "Blue";
        } else if(obstacleIndex == 2)
        {
            tag = "Green";
        }

        obstacle.transform.SetParent(transform);
        obstacle.transform.GetChild(0).gameObject.GetComponent<Renderer>().material = obstacleColors[obstacleIndex];
        obstacle.gameObject.tag = tag;
        obstacle.transform.position = Vector3.forward * obstacleSpawnLocation + new Vector3(0,1,0);
    }

    IEnumerator DoSpawnObstacle()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(1.0f);
        }
    }
}
