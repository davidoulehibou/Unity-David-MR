using UnityEngine;

public class voixserpent : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    private bool HibouTalked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "XR Origin (XR rig)")
        {

            if(HibouTalked == false){
                HibouTalked = true;
                source.PlayOneShot(clip);
                Debug.Log("blabla");
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
