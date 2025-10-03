using UnityEngine;

public class CarSpawner : Spawner
{
    public GameObject CarPrefab;

    public override Spawner SpawnVehicle()
    {
        GameObject carSpawn = Instantiate(CarPrefab, transform.position, Quaternion.identity);
        return carSpawn.GetComponent<Spawner>();
    }
}
