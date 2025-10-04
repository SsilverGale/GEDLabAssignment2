using UnityEngine;

public class Boat : Vehicle
{
    public override void drive()
    {
        //transform.position = new Vector3(transform.position.x * Time.deltaTime, transform.position.y, transform.position.z);
        transform.Translate(0, 0, -30 * Time.deltaTime);
        transform.Rotate(0, 40*Time.deltaTime, 0);

    }
        public void Start()
    {
        transform.Rotate(0, 270, 0);
    }
}
