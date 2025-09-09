using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{  //Components 
    private Rigidbody rb;

    //Movement
    public float speed = 5;
    private Vector3 direction = Vector3.zero;
    private Vector3 velocity = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        //Get Components 
        rb = GetComponent<Rigidbody>();

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Debug.Log(direction); 

        //Left/Right 
        direction.x = Input.GetAxisRaw("Horizontal");

        //Up/Down
        direction.z = Input.GetAxisRaw("Vertical");

        //Construct the velocity vector 
        velocity = direction * speed;
        velocity *= Time.fixedDeltaTime;

        //Normalize the direction. 
        direction = direction.normalized; 

        //Move 
        rb.MovePosition(rb.position + velocity); 
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + direction * 2); 
    }
}
