using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_CambiaColorInspector : MonoBehaviour
{

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = Color.red;
    }
}
