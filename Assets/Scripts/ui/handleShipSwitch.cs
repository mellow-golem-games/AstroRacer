using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleShipSwitch : MonoBehaviour
{
    public int shipNumber = 1; // the number of the ship we want to perform an action on

    public void shipSwitchHandler(int switchedTo) {
        if(shipNumber == switchedTo) {
          transform.localPosition = new Vector3(6,6.59f,0);
        } else {
          transform.localPosition = new Vector3(20,20,0);
        }
    }
}
