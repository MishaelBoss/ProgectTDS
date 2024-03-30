using System.Collections.Generic;
using UnityEngine;

public class SpawnerAidKit : MonoBehaviour
{
    public AidKit aidKitPref;
    private AidKit _aidKit;

    private List<Transform> spawnerPoints;

    public float timeSpawnAidKit = 10;
    public float timeSpawnAidKitMax = 15;

    private void Start()
    {
        spawnerPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
    }

    private void Update()
    {
        if (_aidKit != null) return;
        if (IsInvoking()) return;

        Invoke("CreateAidKit", Random.Range(timeSpawnAidKit, timeSpawnAidKitMax));
    }

    private void CreateAidKit() {
        _aidKit = Instantiate(aidKitPref);
        _aidKit.transform.position = spawnerPoints[Random.Range(0, spawnerPoints.Count)].position;
    }
}
