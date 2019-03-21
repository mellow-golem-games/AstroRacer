using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScroller : MonoBehaviour
{

    public float scrollSpeed = 0.25f;
    private Vector3 startPosition;

    void Start()
    {
      startPosition = transform.position;
    }

    void Update() // Every frame move the wall down a bit
    {
      Vector3 currentPosition = transform.position;
      currentPosition.y = currentPosition.y - scrollSpeed / 32;
      transform.position = currentPosition;
    }

    // Moves the wall to the top of the screen to repeat
    void OnBecameInvisible() {
      float newYVal = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).y * 2;
      transform.position = new Vector3(transform.position.x, newYVal, transform.position.z);
    }
}
