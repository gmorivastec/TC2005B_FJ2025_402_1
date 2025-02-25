// equivalente a "import"
// incluir namespaces
using UnityEngine;


// doc oficial de monobehaviour - https://docs.unity3d.com/6000.0/Documentation/ScriptReference/MonoBehaviour.html
public class Ejemplo : MonoBehaviour
{

    // lifecycle! 
    // ciclo de vida

    void Awake()
    {
        // el primer método que se invoca después de la creación del componente
        // no hay manera de saber si corre antes de otros awake
        print("AWAKE");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // corre 1 vez después de awake
        print("START");
    }

    // Empieza el loop 
    // la frecuencia se mide en FPS
    // frames per second
    // real time - 30 fps
    // ideal - 60 fps +
    // update va a correr tantas veces pueda
    // Update is called once per frame
    void Update()
    {
        Debug.Log("UPDATE");

        // QUÉ VA EN UPDATE
        // - input de jugador
        // - movimiento
    }

    // sucede cada loop al terminar todos los updates
    // normalmente utilizado para hacer setup previo al siguiente update
    void LateUpdate()
    {
        Debug.Log("LATE UPDATE");
    }

    // fixed ? - fijo 
    // hay manera de configurar intervalos regulares
    void FixedUpdate() 
    {
        Debug.Log("FIXED UPDATE");
    }
}
