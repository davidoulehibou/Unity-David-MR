using UnityEngine;

public class punch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject poing1;
    public GameObject poing2;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == poing1 | collision.gameObject == poing2)
        {
            source.PlayOneShot(clip);
        }
    }
}
