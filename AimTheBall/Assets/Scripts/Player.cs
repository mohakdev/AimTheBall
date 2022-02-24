using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D PlayerBody;
    public PowerSlider slider;
    public AngleDeviser angle;
    bool MovementStarted = false;
    bool PowerAccquired = false;
    float SliderVal;
    public GameObject AngleDeviser;
    public GameObject PowerBar;
    [Header("Player Settings : ")]
    public float Friction;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        PlayerBody.drag = Friction; //This applies friction
        if (Input.GetMouseButtonDown(0) && !MovementStarted && PowerAccquired)
        {
            //This gets us the angle and we start applying force
            float Angle = angle.GetAngle();
            float powerY = Angle / 100 * SliderVal;
            float powerX = SliderVal - powerY;
            PlayerBody.AddForce(new Vector2(powerX, powerY));
            Destroy(AngleDeviser);
            MovementStarted = true;
        }
        if (Input.GetMouseButtonDown(0) && !MovementStarted)
        {
            //This gets us the force to push the ball 
            SliderVal = slider.GetPowerValue();
            PowerAccquired = true;
            //Deleting stuff
            Destroy(PowerBar);
            AngleDeviser.SetActive(true);
        }
    }
}
