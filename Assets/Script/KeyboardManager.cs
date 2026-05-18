using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public Key[] Keys;
    // Start is called before the first frame update
    void Start()
    {
        Keys = GameObject.FindObjectsOfType<Key>();
        if (Keys.Length > 0)
        {
          int indiceAzar = Random.Range(0, Keys.Length);
          Destroy(Keys[indiceAzar].gameObject);
          Debug.Log("Se destruyó la tecla en el índice: " + indiceAzar);
        }else
        {
            Debug.LogWarning("No se encontraron teclas en la escena.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
