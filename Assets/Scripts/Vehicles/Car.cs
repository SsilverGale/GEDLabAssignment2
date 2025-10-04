using UnityEngine;

public class Car : Vehicle
{
    public override void drive()
    {
        //transform.position = new Vector3(transform.position.x * Time.deltaTime, transform.position.y, transform.position.z);
        transform.Translate(0, 0, -30*Time.deltaTime);
    }
    public void Start()
    {
        transform.Rotate(0, 270, 0);
    }

}
