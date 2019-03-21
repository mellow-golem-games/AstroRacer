using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f; // Speed of the ship
    public int reboundForceAmount = 3; // Amount of force to apply to the ship when it hits the wall

    private Rigidbody2D rb;
    private Vector2 target;
    private Vector2 currentPosition;
    private bool isRebounding = false;
    private int reboundTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Simple game so we can just use an simple if to differentiate between the 2 collisions
    // that could happen. If we had more this might not be the best approach.
    void OnCollisionEnter2D(Collision2D col) {
      if (col.gameObject.tag == "wall") {
        handleWallCollision();
      } else {
        // Everything else we can collide with is an enemy so handle health here
        // The actual cleanup of the object is handled there
      }
    }

    private void handleWallCollision() {
      if (gameObject.transform.position.x < 0) {
        rb.AddForce(new Vector2(reboundForceAmount,0), ForceMode2D.Impulse);
      } else {
        rb.AddForce(new Vector2(reboundForceAmount * -1,0), ForceMode2D.Impulse);
      }
      isRebounding = true;
    }

    // Update is called once per frame
    void Update()
    {
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
