using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPShandler : MonoBehaviour
{
    public Text FPStext;
    public int FPS;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FPS = (int)(1f / Time.unscaledDeltaTime);
        FPStext.text = "FPS: " + FPS;
    }
}
