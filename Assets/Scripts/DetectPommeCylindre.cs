using UnityEngine;

public class DetectPommeCylindre : MonoBehaviour
{
    public ParticleSystem particleSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pomme")
        {
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Pomme")
        {
            if (particleSystem != null)
            {
                particleSystem.Stop();
            }
        }
    }
}
