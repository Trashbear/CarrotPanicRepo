using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
 public static float speed = 4;
    void FixedUpdate() {
        if (Time.deltaTime < 14)
        {
         if (PlayerController.speed > 0)
            {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }

    }
}
