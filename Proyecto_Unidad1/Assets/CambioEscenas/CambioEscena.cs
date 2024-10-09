using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex; //0,1,2,3 

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (escena_actual == 0)
            {
                cambioDeEscena(1);
            }
            else if (escena_actual == 1)
            {
                cambioDeEscena(2);
            }
            else
            {
                cambioDeEscena(0);
            }
        }
    }

    public void cambioDeEscena(int index_escena_ir)
    {
        SceneManager.LoadScene(index_escena_ir);
    }
}
