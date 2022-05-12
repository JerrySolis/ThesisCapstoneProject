using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_HealthBar : MonoBehaviour
{
  
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = slider.maxValue;
        //changing gradient color of fill image in slider
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        //changing gradient color of fill image in slider
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (slider.value == 0)
        {
            Debug.Log("Game Over Player just Died!");
            _startGame.Instance.PauseGame();
            Debug.Log("The game is pause!");

            // Promp Game over Window using Game Manager;
        }
    }
}
