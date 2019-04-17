using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject CircleEnemy;
    public GameObject RockLeft;
    public GameObject RockRight;
    public GameObject LargeRockLeft;
    public GameObject LargeRockRight;
    public GameObject Ship;
    public float xSpawnDistance = 0f;
    public float ySpawnDistance = 6f;
    public int framesToSpawn = 120; // This sets a delay in spawning. Needed or else you end up with waves of enemies which looks weird

    // Set the percentrage chances of each enemy spawning. We can update this per spawner to
    // get a different flow for each one and force certain enemies to spawn where we want
    public float spawnCircle = 0.75f;
    public float spawnLeftWall = 0;
    public float spawnRightWall = 0;
    public float spawnEnemyShip = 0;
    public float spawnLargeRockLeft = 0;
    public float spawnLargeRockRight = 0;


    private int tickCounter;

    // Update is called once per frame
    void Update()
    {
      tickCounter++; // probably a better way to do this

      if(tickCounter % framesToSpawn == 0) {
        float randomNumber = Random.Range(0, 1f);

        // We simply cycle through the list of enemies and if the random number is less than the spawn chance
        // we show it. There's probably a better way to handle this but this works for a small game like this
        // Anything bigger than all the numbers is simply the no spawn chance
        if (randomNumber < spawnCircle) {
          Instantiate(CircleEnemy, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
        } else if (randomNumber < spawnLeftWall) {
          Instantiate(RockLeft, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
        } else if (randomNumber < spawnRightWall) {
          Instantiate(RockRight, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
        } else if (randomNumber < spawnEnemyShip) {
          Instantiate(Ship, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
        } else if (randomNumber < spawnLargeRockLeft) {
          Instantiate(LargeRockLeft, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
        } else if (randomNumber < spawnLargeRockRight) {
          Instantiate(LargeRockRight, new Vector3(xSpawnDistance,ySpawnDistance,0), Quaternion.identity);
        }
      }
    }
}
