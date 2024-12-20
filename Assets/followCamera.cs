using UnityEngine;

public class followCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (mainCamera != null)
        {
            Vector3 directionToCamera = mainCamera.transform.position - transform.position;

            directionToCamera.y = 0;

            transform.rotation = Quaternion.LookRotation(directionToCamera);
        }
    }
}
