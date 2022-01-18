using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupscript : MonoBehaviour
{
    public ParticleSystem shineEffect;
    // Start is called before the first frame update
void OnTriggerEnter2D(Collider2D other)
{
    Destroy(gameObject);
}
}
