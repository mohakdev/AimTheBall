using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D PlayerBody;
    public PowerSlider slider;
    public AngleDeviser angle;
    bool MovementStarted = false;
    [Header("Player Settings : ")]
    public float Friction;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        PlayerBody.drag = Friction;
        if (Input.GetMouseButtonDown(0) && !MovementStarted)
        {
            float SliderVal = slider.GetPowerValue();
            float Angle = angle.GetAngle();
            float powerY = Angle / 100 * SliderVal;
            float powerX = SliderVal - powerY;
            MovementStarted = true;
            PlayerBody.AddForce(new Vector2(powerX, powerY));
            //Deleting stuff
            GameObject PowerBar = GameObject.Find("PowerBar");
            GameObject AngleDeviser = GameObject.Find("AngleDeviser");
            Destroy(AngleDeviser);
            Destroy(PowerBar);
        }
    }
}
