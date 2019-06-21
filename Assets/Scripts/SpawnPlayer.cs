using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{

    public GameObject ship1;
    public GameObject ship2;
    public GameObject ship3;

    [SerializeField]
    private float ySpawnDistance = -4.5f;

    void Start()
    {
      // Spawns the ship
      // TODO we need to create a way to get the ship choice from the home screen - for now just
      // spawn the first one.
      GameObject Player = Instantiate(ship1, new Vector3(0,ySpawnDistance,0), Quaternion.identity);
      Player.gameObject.tag = "Player"; // We use this for collisions later
    }
}
