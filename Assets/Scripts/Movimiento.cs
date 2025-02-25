using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // INPUT
        // (polling) sondeo directo a dispositivos
        if(Input.GetKeyDown(KeyCode.A)){
            // esto es true cuando la tecla estaba libre en el frame anterior
            // pero presionada en este
            print("A DOWN");
        }

        if(Input.GetKey(KeyCode.A)){
            // frame anterior estaba presionado
            // frame actual sigue presionado
            print("A KEY");
        }

        if(Input.GetKeyUp(KeyCode.A)){
            // frame anterior presionado
            // frame actual libre
            print("A UP");
        }

        if(Input.GetMouseButtonUp(0)){
            print("MOUSE BUTTON UP");
        }
    }
}
