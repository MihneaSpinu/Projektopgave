using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderChange : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderText;

    void Start()
    {
        slider.value = Health.health;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Health.health;
        sliderText.text = ("Health: " + slider.value.ToString());
    }
}

