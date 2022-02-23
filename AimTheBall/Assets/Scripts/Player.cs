using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D PlayerBody;
    [Header("Player Settings : ")]
    public float Friction;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
        PlayerBody.AddForce(new Vector2(100, 300));
    }
    private void Update()
    {
        PlayerBody.drag = Friction;
    }
}
