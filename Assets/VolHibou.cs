using UnityEngine;

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

    void Start()
    {
        up = true;
        inviniteup = false;
    }

    public void Ok(){
        up = true;
        inviniteup = true;
        }

    void Update()
    {
        if (up)
        {
            hibou.transform.position = new Vector3(-22f, height, 25.6f);
            height += speed * Time.deltaTime;

            if (height >= 10.5f)
            {
                if(inviniteup != true){
                    up = false;
                }

                up = false;
                vitesseRotation = 600f;
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
