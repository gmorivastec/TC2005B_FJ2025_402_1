using System.Collections;
using NUnit.Framework;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    //CREAR OBJETOS DINÁMICOS 
    // requisito: el original
    [SerializeField]
    private GameObject _original;

    [SerializeField]
    private GameObject _referencia;

    [SerializeField]
    private float _velocidad = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Assert.IsNotNull(_original, "ORIGINAL NO PUEDE SER NULO EN CANNON");
        Assert.IsNotNull(_referencia, "REFERENCIA NO PUEDE SER NULO EN CANNON");

        // puedo correr cualquier cantidad de corrutinas que quiera
        // las corrutinas pertenecen al componente
        StartCoroutine("CorrutinaLineal");
        StartCoroutine(CorrutinaLineal());
        StartCoroutine(CorrutinaIterativa());
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(
            horizontal * _velocidad * Time.deltaTime,
            0,
            0
        );

        if(Input.GetButtonDown("Jump"))
        {
            Instantiate(
                _original,
                _referencia.transform.position,
                _referencia.transform.rotation
            );
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            StopAllCoroutines();
        }
    }

    // CORRUTINAS
    // código pseudoconcurrente

    // 2 casos principales 
    // ejecución lineal de lógica pseudoconcurrente
    // ejecución iterativa

    IEnumerator CorrutinaLineal()
    {
        yield return new WaitForSeconds(2);
        print("HOLA DESDE LA CORRUTINA");
    }

    // CUANDO USAR UNA CORRUTINA ITERATIVA
    // cuando necesitamos un proceso recurrente en una frecuencia
    // menor al update 
    // algo que se repite que no tiene que ver con movimiento o input
    IEnumerator CorrutinaIterativa()
    {
        while(true)
        {
            print("CORRUTINA ITERATIVA");
            yield return new WaitForSeconds(2);
        }
    }
}
