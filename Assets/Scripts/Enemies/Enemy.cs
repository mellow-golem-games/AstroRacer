﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float scrollSpeed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected void Update()
    {
      Vector3 currentPosition = transform.position;
      currentPosition.y = currentPosition.y - scrollSpeed / 32;
      transform.position = currentPosition;
    }

    void OnCollisionEnter2D(Collision2D collision) {

      // E.X on grabbing compoenent attributes here
      // Will need to do this for below steps
      // Sprite sp = GetComponent<SpriteRenderer>().sprite;


      // We need to play the death animation
      // play the death sound
      // Destroy the object
    }
}
