using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScroller : MonoBehaviour
{

    public float scrollSpeed = 0.25f;

    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
      startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 currentPosition = transform.position;
      currentPosition.y = currentPosition.y - scrollSpeed / 32;
      transform.position = currentPosition;
    }
}
