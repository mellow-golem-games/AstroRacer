﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Enemy
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    new void FixedUpdate()
    {
        base.FixedUpdate(); // call the parent update method for movement
    }
}
