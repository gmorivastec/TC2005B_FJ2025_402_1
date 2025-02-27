using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class Movimiento : MonoBehaviour
{

    // atributo accesible desde editor 
    // cuáles sirven? primitivos, tipos de unity serializables

    [SerializeField]
    private float _speed = 5;


    [SerializeField]
    private TMP_Text _textito;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Assert.IsNotNull(_textito, "TEXTITO NO PUEDE SER NULO");


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

        // entrada un poquito más refinada
        // por medio de ejes
        // ejes son una capa de abstracción de input
        // separa el dispositivo físico del código final
        // los valores representados por un eje están en el rango [-1, 1]

        // GetAxis - utiliza valores de suavizado del editor
        // GetAxisRaw - utiliza valores de entrada directamente
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Jump"))
        {
            print("JUMPING!");
        }

        // transform vs Transform

        // PROBLEMA - la frecuencia del update no es constante
        transform.Translate(
            horizontal * Time.deltaTime * _speed,
            vertical * Time.deltaTime * _speed,
            0,
            Space.World
        );
    }

    // colisiones - 2 maneras
    // 1. con el engine de física
    // 2. con el componente CharacterController

    // colisiones con engine de física tiene requerimientos:
    // 1. todos los involucrados tienen un collider
    // 2. al menos 1 tiene rigidbody
    // 3. el objeto que tiene el rigidbody se está moviendo

    // se detona al iniciar la colisión
    void OnCollisionEnter(Collision c)
    {
        // este método se invoca en TODOS los involucrados en la colisión
        // el argumento coliision nos da información relacionada a la colisión
        print(c.collider.transform.name);
        print(c.collider.transform.tag);
        print(c.collider.gameObject.layer);

    }

    void OnCollisionStay(Collision c)
    {
        // mientras los objetos sigan colisionando
        print("COLLISION STAY");
    }

    void OnCollisionExit(Collision c)
    {
        // el momento en el que se separan
        print("COLLISION EXIT");
    }

    // trigger - colision con objetos que no provocan una reacción física
    void OnTriggerEnter(Collider c)
    {
        print("TRIGGER ENTER");
        _textito.text = "AY CHOQUE!";

    }

    void OnTriggerStay(Collider c)
    {
        print("TRIGGER STAY");
    }

    void OnTriggerExit(Collider c)
    {
        print("TRIGGER EXIT");
    }



    
}
