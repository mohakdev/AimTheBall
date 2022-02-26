using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerSlider : MonoBehaviour
{
    Slider MySlider;
    bool Incrementing;
    float PowerVal;
    private void Start()
    {
        MySlider = GetComponent<Slider>();
    }
    void Update()
    {
        PowerVal = MySlider.value;
        if (PowerVal.Equals(100))
        {
            Incrementing = true;
        }
        else if (PowerVal.Equals(1000))
        {
            Incrementing = false;
        }
        if (Incrementing == true)
        {
            PowerVal += 4;
        }
        else
        {
            PowerVal -= 4;
        }
        MySlider.value = PowerVal;
    }
    public float GetPowerValue()
    {
        return this.PowerVal;
    }
}
