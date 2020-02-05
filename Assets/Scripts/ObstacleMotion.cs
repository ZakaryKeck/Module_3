using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMotion : MonoBehaviour
{
    private float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.back * speed * Time.deltaTime));

    }
}
