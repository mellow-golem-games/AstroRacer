using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScrollbar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Slider slider;

    void Update()
    {
      // Debug.Log(playerHealth.health);
      slider.value = playerHealth.health;
    }
}
