using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerConversacion2 : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo
    {
        public string name;
        public string texto;
        public Sprite imagen;
    }

    public List<Dialogo> charla;
    [SerializeField] TextMeshProUGUI txt_mensaje;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image foto_personaje;
     [SerializeField] Image foto_personaje2;


    int contador;

    void mostrarDialogo()
    {
        if (charla.Count > 0)
        {
            if (txt_mensaje != null && txt_nombre != null && foto_personaje != null)
            {
                txt_mensaje.text = charla[contador].texto;
                txt_nombre.text = charla[contador].name;
                foto_personaje.sprite = charla[contador].imagen;
                foto_personaje2.sprite = charla[contador].imagen;

            }
            else
            {
                Debug.LogWarning("Algún componente de UI no está asignado.");
            }
        }
        else
        {
            Debug.LogWarning("No hay diálogos disponibles.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (charla.Count > 0)
            {
                contador++;
                contador = contador % charla.Count;
                Debug.Log(contador);
                mostrarDialogo();
            }
            else
            {
                Debug.LogWarning("No se puede avanzar en la conversación porque no hay diálogos.");
            }
        }
    }
}
