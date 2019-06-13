using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelerRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
