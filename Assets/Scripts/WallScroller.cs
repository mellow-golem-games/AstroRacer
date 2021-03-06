﻿using System.Collections;
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

    void FixedUpdate() // Every frame move the wall down a bit
    {
      Vector3 currentPosition = transform.position;
      currentPosition.y = currentPosition.y - scrollSpeed / 32;
      transform.position = currentPosition;
    }

    // Moves the wall to the top of the screen to repeat
    void OnBecameInvisible() {
      if (transform != null && Camera.main != null) { // check here or it will error out on scene switch
        float newYVal = Camera.main.orthographicSize * 2f;
        transform.position = new Vector3(transform.position.x, newYVal, transform.position.z);
      }
    }
}
