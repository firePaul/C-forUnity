using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private Color color;
    public Color RanColor()
    {
        color = Random.ColorHSV();
        return color;
    }
}
