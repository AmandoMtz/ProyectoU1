using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImputExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("A");

      }
        if (Input.GetKey(KeyCode.B)) {
            Debug.Log("B");

            
      }
        if (Input.GetKey(KeyCode.C)) {
            Debug.Log("C");

      }
        if (Input.GetKey(KeyCode.D)) {
            Debug.Log("D");

      }

    }
}
