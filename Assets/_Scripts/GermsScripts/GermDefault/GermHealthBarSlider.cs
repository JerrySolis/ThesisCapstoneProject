using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GermHealthBarSlider : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text GermName;


    //Setting component name for Germ Above HP bar slider
    public void SetGermName(string name)
    {
        GermName.text = name;
    }
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
            Debug.Log("Destroy object");
          //  Destroy(gameObject);
        }
    }
}
