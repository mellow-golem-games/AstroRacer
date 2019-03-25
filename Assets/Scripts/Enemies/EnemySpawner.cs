using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject CircleEnemy;
    public float xSpawnDistance = 0f;
    public float ySpawnDistance = 6f;

    private int tickCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      tickCounter++;

      if(tickCounter % 60 == 0) {
        Instantiate(CircleEnemy, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
      }
    }
}
