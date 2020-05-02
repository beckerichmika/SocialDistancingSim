using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Camera Camera;
    public Transform OrbitObject;
    private Vector3 OrbitCenterPos;
    public float distance = 7f;
    public float sensitivity = 6f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        OrbitCenterPos = OrbitObject.position;
        transform.localPosition = OrbitCenterPos - Vector3.forward * distance;
        Quaternion cameraAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
