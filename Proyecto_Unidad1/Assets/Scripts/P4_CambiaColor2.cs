using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_CambiaColor2 : MonoBehaviour
{

    Renderer rend;
    [SerializeField] Color colorcito;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
       // colorcito = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = colorcito;
    }
}
