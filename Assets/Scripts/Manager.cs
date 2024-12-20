using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }
    public GameObject pomme;

    public GameObject cabane;
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void CreatePomme()
    {
        GameObject spawnPoint = new GameObject();

        // random depth for the plane's Z axis
        //float extraDepth = Random.Range(0.5f, 1.5f);

        Vector3 cabanePosition = this.cabane.transform.position;

        // plane position
        Vector3 spawnPosition = cabanePosition;

        // set the position of the spawn
        spawnPoint.transform.position = spawnPosition;

        Instantiate(this.pomme, spawnPoint.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
