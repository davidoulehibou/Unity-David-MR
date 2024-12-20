using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject porte;
    public GameObject key;

    public AudioSource source;
    public AudioClip clip;

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
            source.PlayOneShot(clip);
        }
    }
    void Update()
    {
        
    }
}
