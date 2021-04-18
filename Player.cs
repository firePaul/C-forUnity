using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float speed = 3f;
    public static float hp = 200;
    public static float ammo = 80;
    private Rigidbody _rigidbody;
    public static Color color;
    public static Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        _rigidbody = GetComponent<Rigidbody>();
        renderer.material.color = Color.green;
    }

    protected void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce(movement * speed);
    }
    
}
