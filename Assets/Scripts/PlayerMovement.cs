using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f; // Speed of the ship
    public int reboundForceAmount = 3;

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

    void OnCollisionEnter2D(Collision2D col) {
      if (col.gameObject.tag == "wall") {
        handleWallCollision();
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
      if(!isRebounding) {

        if (Input.GetMouseButton(0)) {
    			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          currentPosition = gameObject.transform.position;

          // manually override non moveable direction
          target.y = currentPosition.y;

    			transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    		}
      } else {
        reboundTimer++;

        if(reboundTimer >= 30) {
          reboundTimer = 0;
          isRebounding = false;
          rb.velocity = Vector2.zero;
        }
      }
    }
}
