using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    public abstract Spawner SpawnVehicle();

    private float timer;
    public float spawnFreqency;
    public void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnFreqency)
        {
            timer -= spawnFreqency;
            SpawnVehicle();
        }
    }
}
