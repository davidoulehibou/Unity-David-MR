using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = new Vector3(collision.transform.position.x, 5.0f, collision.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
