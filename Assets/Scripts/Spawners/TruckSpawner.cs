using UnityEngine;

public class TruckSpawner : Spawner
{
    public GameObject TruckPrefab;

    public override Spawner SpawnVehicle()
    {
        GameObject carSpawn = Instantiate(TruckPrefab, transform.position, Quaternion.identity);
        return carSpawn.GetComponent<Spawner>();
    }
}
