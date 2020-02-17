using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMotion : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject colorHolder;

    public string color;
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

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Bullet") && colorHolder.GetComponent<ColorChanger>().GetColor() == gameObject.tag)
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Destroy(other);
            Destroy(this);
        }
    }
}
