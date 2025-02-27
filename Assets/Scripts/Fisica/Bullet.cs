using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // como obtener referencia a un componente
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(
            new Vector3(0, 500, 0)
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
