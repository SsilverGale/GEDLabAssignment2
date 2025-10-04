using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    public abstract void drive();

    public void Update()
    {
        //Moives vehicles in unique ways
        drive();
        
        //Cleans up off screen vehicles
        if (transform.position.x > 50 || transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    }
}
