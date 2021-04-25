using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public static float speed = 3f;
    public static float hp = 200;
    public static float ammo = 80;
    private Rigidbody _rigidbody;
    public static Color color;
    public static Renderer renderer;
    
    public abstract void Move(float x, float y, float z);
}
