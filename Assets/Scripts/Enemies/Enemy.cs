﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float scrollSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col) {
      if(GetComponent<Animator>() && col.tag == "Player") { // For Testing as it prevents non-animated objects from erroring out
        GetComponent<Animator>().Play("Ship_Explode");
      }
    }

    // Used to as callback for animation to destory the objects
    public void destroyObject() {
  		Destroy(gameObject);
  	}

    // Update is called once per frame
    protected void Update()
    {
      Vector3 currentPosition = transform.position;
      currentPosition.y = currentPosition.y - scrollSpeed / 32;
      transform.position = currentPosition;
    }

    void OnCollisionEnter2D(Collision2D collision) {
      // Debug.Log("Collision Entered");
      // E.X on grabbing compoenent attributes here
      // Will need to do this for below steps
      // Sprite sp = GetComponent<SpriteRenderer>().sprite;


      // We need to play the death animation
      // play the death sound
      // Destroy the object
    }

    void OnBecameInvisible() {
      // all the enemies in this game we can simply destroy when they go off screen
      Destroy(gameObject);
    }
}
