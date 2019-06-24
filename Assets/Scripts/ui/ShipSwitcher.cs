using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSwitcher : MonoBehaviour
{
    public int currentShip = 1;

    // updates which ship we are currently on
    // TODO pass it down to children?
    public void switchShip(string type) {
      if(type == "up") {
        if(currentShip != 3) {
          currentShip++;
        } else {
          currentShip = 1;
        }
      } else {
        if(currentShip != 1){
          currentShip--;
        } else {
         currentShip = 3;
        }
      }


      GameObject Ship1 = GameObject.Find("Ship1");
      handleShipSwitch s1Script = (handleShipSwitch) Ship1.GetComponent(typeof(handleShipSwitch));
    	s1Script.shipSwitchHandler(currentShip);

      GameObject Ship2 = GameObject.Find("Ship2");
      handleShipSwitch s2Script = (handleShipSwitch) Ship2.GetComponent(typeof(handleShipSwitch));
    	s2Script.shipSwitchHandler(currentShip);

      GameObject Ship3 = GameObject.Find("Ship3");
      handleShipSwitch s3Script = (handleShipSwitch) Ship3.GetComponent(typeof(handleShipSwitch));
    	s3Script.shipSwitchHandler(currentShip);

    }

}
