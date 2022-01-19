using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public bool deathCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        deathCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (deathCheck == true)
        {
            Debug.Log("Dead");
        }
    }
}
