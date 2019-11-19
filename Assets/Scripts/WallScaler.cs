using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScaler : MonoBehaviour
{
    // Start is called before the first frame update
    public int ypos = 0;

    void Start()
    {
      // handles scaling the walls for IOS X phones
      if(Screen.width == 1125 || Screen.width == 828) { // Iphone x widtth & Xs width
        transform.localScale = new Vector3(1f, 1.15f, 1f);
        transform.position = new Vector3(transform.position.x, ypos, transform.position.z);
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
