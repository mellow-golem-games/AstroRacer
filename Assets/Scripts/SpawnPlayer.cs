using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{

    public GameObject ship1;
    public GameObject ship2;
    public GameObject ship3;

    private GameObject Player;

    [SerializeField]
    private float ySpawnDistance = -4.5f;

    void Start()
    {
      int currentShip = PlayerPrefs.GetInt("currentShip");
      // at this point logic for ship should have already happened. If the ship is saved here
      // we can assume that the player has it unlocked
      switch (currentShip) {
        case 1:
          Player = Instantiate(ship1, new Vector3(0,ySpawnDistance,0), Quaternion.identity);
          break;
        case 2:
          Player = Instantiate(ship2, new Vector3(0,ySpawnDistance,0), Quaternion.identity);
          break;
        case 3:
          Player = Instantiate(ship3, new Vector3(0,ySpawnDistance,0), Quaternion.identity);
          break;
        break;
      }

      Player.gameObject.tag = "Player"; // We use this for collisions later
    }
}
