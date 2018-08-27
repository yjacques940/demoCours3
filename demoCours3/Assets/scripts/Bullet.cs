using UnityEngine;

//pour éviter que le bullet sortent et entrent en collisions

public class Bullet : MonoBehaviour
{
    Rigidbody rigidbody;
  
    // Use this for initialization
    void Start()
    {
        rigidbody =GetComponent<Rigidbody>();
        Vector3 ajustedMovement = transform.TransformDirection(Vector3.forward);
        rigidbody.AddForce(ajustedMovement * 1000);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}

