using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public GameObject colorHolder;

    void OnTriggerEnter(Collider other)
    {
        colorHolder.GetComponent<ColorChanger>().SetColor(gameObject.tag);
    }
}
