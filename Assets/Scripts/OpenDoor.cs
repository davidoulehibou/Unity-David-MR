using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject porte;
    public GameObject key;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == key)
        {
            Debug.Log("porte ouverte");
            porte.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            Destroy(key);
        }
    }
    void Update()
    {
        
    }
}
