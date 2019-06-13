using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform[] cameraPosition;
    public Transform cameraTarget;
    public float movementSpeed = 10f;
    [SerializeField] int target;
    private Vector3 velocity = Vector3.zero;
    //[SerializeField] float step;
    private void Start()
    {
        target = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(cameraTarget);
        //transform.position = Vector3.Lerp(transform.position, cameraPosition[ranTarget].position, Time.deltaTime * movementSpeed)
        CamerMovement();
    }

    void CamerMovement()
    {
        if (target <= 8)
        {
            transform.position = Vector3.SmoothDamp(transform.position, cameraPosition[target].position, ref velocity, Time.deltaTime * movementSpeed);
            if (Vector3.Distance(transform.position, cameraPosition[target].transform.position) <= 0.5f)
            {
                target += 1;
                Debug.Log("Camera new target: " + target);

            }
        }
    }
}

