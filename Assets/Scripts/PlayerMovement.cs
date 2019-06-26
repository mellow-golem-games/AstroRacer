using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f; // Speed of the ship
    public int reboundForceAmount = 3; // Amount of force to apply to the ship when it hits the wall
    public PlayerHealth playerHealth;
    public int playerHealthInitialCount = 4;

    private Rigidbody2D rb;
    private Vector2 target;
    private Vector2 currentPosition;
    private bool isRebounding = false;
    private int reboundTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      playerHealth.health = playerHealthInitialCount; // set the health to our starting value
    }

    void OnCollisionEnter2D(Collision2D col) {
      // The only other rigidBody that will trigger here is the walls
      // all enemies are triggers so use OnTriggerEnter2D
      handleWallCollision();
    }

    void OnTriggerEnter2D(Collider2D col) { // collision to check if running into another entity
      playerHealth.health--;
    }

    private void handleWallCollision() {
      if (gameObject.transform.position.x < 0) {
        rb.AddForce(new Vector2(reboundForceAmount,0), ForceMode2D.Impulse);
      } else {
        rb.AddForce(new Vector2(reboundForceAmount * -1,0), ForceMode2D.Impulse);
      }
      isRebounding = true;
    }

    private void killPlayer() {
      // handle destruction of the player here
      // we can play an animation with a callback to trigger this
      SceneManager.LoadScene("Over");
    }

    // Update is called once per frame
    void Update()
    {
      if(playerHealth.health == 0) {
        killPlayer();
      }
      if(!isRebounding) { // Can't move while we're rebouding from the wall
        if (Input.GetMouseButton(0)) {
    			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          currentPosition = gameObject.transform.position;

          // manually override non moveable direction
          target.y = currentPosition.y;

    			transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    		}
      } else {
        reboundTimer++;

        if(reboundTimer >= 30) { // 30 frame of force then we stop rebounding
          reboundTimer = 0;
          isRebounding = false;
          rb.velocity = Vector2.zero;
        }
      }
    }
}
