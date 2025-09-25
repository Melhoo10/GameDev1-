using Mono.Cecil;
using UnityEngine;



public class Bullet : MonoBehaviour
{ //Components 
    private Rigidbody rb;

    //Movement
    public float speed = 16f;
    private Vector3 velocity; 





    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void SetVelocity(Vector3 direction) 
    {
        //set the velocity since thge turret is passing in the direction.
        //And we have the speed declared in the bullet 
        velocity = direction * speed;
    }
  
    void Start()
    {
        //Get Components
        rb = GetComponent<Rigidbody>();

        //Destroy the bullet after 5 seconds.
        //This way bullets don't last forever and eventually lag in the game.
        Destroy(gameObject, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        //Move the bullet. 
        rb.MovePosition(rb.position +  velocity * Time.fixedDeltaTime); 
    }
}