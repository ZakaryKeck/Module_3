using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMotion : MonoBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 0)
        {
            transform.Translate((Vector3.back * speed * Time.deltaTime));
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
