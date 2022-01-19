using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
 public float speed;
    void FixedUpdate() {
        if (Time.deltaTime < 16)
        {
         if (PlayerController.speed > 0)
            {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }

    }
}
