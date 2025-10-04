using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    public abstract void drive();

    public void Update()
    {
        drive();
    }
}
