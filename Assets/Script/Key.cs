using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float cantidadAlBajar = 0.2f; 
    
    private Vector3 posicionOriginal;
    private Vector3 posicionPresionada;
    void Start()
    {
        // Guardamos la posición exacta donde empezó la tecla
        posicionOriginal = transform.position;
        
        // Calculamos la posición hacia abajo
        posicionPresionada = posicionOriginal + new Vector3(0, -cantidadAlBajar, 0);
    }
    void OnMouseDown(){
        Debug.Log("Click");
        transform.position=posicionPresionada;
    }

    void OnMouseUp()
    {
        Debug.Log("se solto la tecla");
        transform.position=posicionOriginal;
    }
}
