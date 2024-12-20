using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class VolHibou : MonoBehaviour
{
    public float height = 9.5f;
    private bool up;
    private bool inviniteup;
    public GameObject hibou;
    public float speed = 0.01f;

    public GameObject aileGauche;
    public GameObject aileDroite;
    private float vitesseRotation = 1000f;
    private bool rotationGauchePositive = true;
    private bool rotationDroitePositive = true;

    private float angleGauche = 5f;
    private float angleDroite = -5f;

    public AudioSource audioSource;

    public TextMeshProUGUI texte;

    public AudioSource source;
    public AudioClip clip;
    private bool hibouTalked = false;

    


    void Start()
    {
        up = true;
        inviniteup = false;
    }

    public void MortHibou()
    {
        up = true;
        inviniteup = true;
        speed = 0.5f;
        vitesseRotation = 1200f;
        audioSource.Play();
        texte.text = "";
    }

    public void OnGazeEntered()
    {
        if(hibouTalked == false){
            hibouTalked = true;
            source.PlayOneShot(clip);
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.transform.tag == "Pine")
        {
            MortHibou();
        }
    }

    void Update()
    {
        if (up)
        {
            hibou.transform.position = new Vector3(-22f, height, 25.6f);
            height += speed * Time.deltaTime;

            if (height >= 10.5f)
            {
                if (inviniteup == true)
                {
                    up = true;
                }
                else
                {
                    up = false;
                    vitesseRotation = 600f;
                }


            }
        }
        else
        {
            hibou.transform.position = new Vector3(-22f, height, 25.6f);
            height -= speed * Time.deltaTime;

            if (height <= 9.5f)
            {
                up = true;
                vitesseRotation = 1000f;
            }
        }

        if (rotationGauchePositive)
        {
            angleGauche += vitesseRotation * Time.deltaTime;
            if (angleGauche >= 80f)
            {
                rotationGauchePositive = false;
            }
        }
        else
        {
            angleGauche -= vitesseRotation * Time.deltaTime;
            if (angleGauche <= 5f)
            {
                rotationGauchePositive = true;
            }
        }
        if (rotationDroitePositive)
        {
            angleDroite -= vitesseRotation * Time.deltaTime;
            if (angleDroite <= -80f)
            {
                rotationDroitePositive = false;
            }
        }
        else
        {
            angleDroite += vitesseRotation * Time.deltaTime;
            if (angleDroite >= -5f)
            {
                rotationDroitePositive = true;
            }
        }
        aileGauche.transform.localRotation = Quaternion.Euler(0, 0, angleGauche);
        aileDroite.transform.localRotation = Quaternion.Euler(0, 0, angleDroite);
    }
}
