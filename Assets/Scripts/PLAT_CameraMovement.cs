using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAT_CameraMovement : MonoBehaviour
{
    public GameObject cameraObj;
    public GameObject playerObj;
    public GameObject cameraTarget;
    Vector3 targetPos;

    public float cameraMoveSpeed = 120.0f;
    public float clampAngle = 80.0f;
    public float inputSensitivity = 150.0f;
    public float smoothX;
    public float smoothY;

    private float rotX = 0.0f;
    private float rotY = 0.0f;
    private float camDistanceXToPlayer;
    private float camDistanceYToPlayer;
    private float camDistanceZToPlayer;
    private float mouseX;
    private float mouseY;
    private float finalInputX;
    private float finalInputY;

    Vector3 followPos;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotY = rotation.y;
        rotX = rotation.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Stick_Right_X");
        float inputY = Input.GetAxis("Stick_Right_Y");

        if (!Input.GetButton("Bumper_Left"))
        {
            finalInputX = inputX /* + mouseX */;
            finalInputY = inputY /* + mouseY */;
        }

        rotY += finalInputX * inputSensitivity * Time.deltaTime;
        rotX += finalInputY * inputSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0);
        transform.rotation = localRotation;
   
    }

    void LateUpdate()
    {
        UpdateCamera();
    }

    void UpdateCamera()
    {
        Transform target = cameraTarget.transform;

        float step = cameraMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
