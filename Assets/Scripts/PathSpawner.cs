using UnityEngine;

public class PathSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] paths;
    [SerializeField] float spawnInterval =2.5f;
    public Transform spawner;
    void Start()
    {
        SpawnPath();
        InvokeRepeating("SpawnPath", 2.5f, spawnInterval);
    }
    public void SpawnPath()
    {
        int randomIndex = Random.Range(0, paths.Length);
        GameObject path = Instantiate(paths[randomIndex], spawner.position, spawner.rotation);
        path.transform.SetParent(spawner);
    }
}
