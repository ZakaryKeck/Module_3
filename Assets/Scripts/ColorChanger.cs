using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public string Color;

    public string GetColor()
    {
        return this.Color;
    }

    public void SetColor(string newColor)
    {
        this.Color = newColor;
    }
}
