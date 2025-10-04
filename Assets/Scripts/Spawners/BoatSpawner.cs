using UnityEngine;

public class BoatSpawner : Spawner
{
    public GameObject BaotPrefab;

    public override Spawner SpawnVehicle()
    {
        GameObject carSpawn = Instantiate(BaotPrefab, transform.position, Quaternion.identity);
        return carSpawn.GetComponent<Spawner>();
    }
}
