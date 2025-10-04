using UnityEngine;

public class Truck : Vehicle
{
    int swirv;
    public override void drive()
    {
        //transform.position = new Vector3(transform.position.x * Time.deltaTime, transform.position.y, transform.position.z);
        transform.Translate(0, 0, -30 * Time.deltaTime);
        swirv = Random.Range(-100, 100);
        transform.Rotate(0, swirv * Time.deltaTime, 0);

    }
    public void Start()
    {
        transform.Rotate(0, 90, 0);
    }
}
