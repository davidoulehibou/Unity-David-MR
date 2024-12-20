using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DetectPommeCylindre : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public TextMeshProUGUI texte;
    public AudioSource source;
    public AudioClip clip;
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
            //Create pomme
            source.PlayOneShot(clip);
            Manager.Instance.CreatePomme();
            Destroy(collision.gameObject);
            texte.text = "Mercccccci!";
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
