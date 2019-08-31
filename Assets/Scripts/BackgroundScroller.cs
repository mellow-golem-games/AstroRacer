using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.width == 1125 || Screen.width == 828) { // Iphone x widtth & Xs width
          Camera camera = this.GetComponent<Camera>();
          camera.orthographicSize = 7.013923F;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
