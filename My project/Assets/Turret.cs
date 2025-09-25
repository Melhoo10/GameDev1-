using UnityEngine;





public class Turret : MonoBehaviour
    


{//shooting 
    public GameObject target;
    public GameObject bullet;
    public float rate_of_fire = 0.2f; 
    public float shoot_timer = 0;

  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
       
    {
        //If there is time on the shoot_timer...
        if (shoot_timer > 0)
            shoot_timer -= Time.deltaTime; //Subrtact delta time from it. 
        else //Otherwise. 
        {
            //Spawn Bullets
            //Reset the timer.
            shoot_timer = rate_of_fire; 

            //Instance a new bullet. 
            GameObject new_bullet = Instantiate(bullet);

            //Move the bullet to the position of the turret. 
            new_bullet.transform.position = transform.position;

            //Find the direction that the bullets need to travel in and then pass it to the bullet.
            Vector3 bullet_dir = (target.transform.position - transform.position).normalized;
            new_bullet.GetComponent<Bullet>().SetVelocity(bullet_dir);
        }

    }
}
