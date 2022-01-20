using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    public static bool startMessage;
    // Start is called before the first frame update
    void Start()
    {
        startMessage = true;
       Destroy(gameObject, 4); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
