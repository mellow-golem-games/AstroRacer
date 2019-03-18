using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f; // Speed of the ship
    private Vector2 target;
    private Vector2 currentPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButton(0)) {
  			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        currentPosition = gameObject.transform.position;

        // manually override non moveable direction
        target.y = currentPosition.y;

  			transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
  		}
    }
}
