using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField]
    private float _fuerza = 500;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // como obtener referencia a un componente
        _rigidbody = GetComponent<Rigidbody>();
        // restricción: la física funciona en espacio global
        // transform.right
        // transform.forward
        // transform.up
        // vectores en espacio global con misma dirección y sentido 
        // que x, y, z local
        // todos están normalizados
        _rigidbody.AddForce(
            transform.up * _fuerza
        );

        // en cualquier juego donde creemos objetos de manera dinámica
        // por higiene es necesario implementar estrategias de destrucción
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);


        /// 
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);       
    }
}
