using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
 public float speed;
    void Update() {
        if (PlayerController.scoreValue > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
