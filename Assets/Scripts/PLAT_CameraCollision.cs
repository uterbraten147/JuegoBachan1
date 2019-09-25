using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAT_CameraCollision : MonoBehaviour
{
    public float minDistance = 1.0f;
    public float maxDistance = 4.0f;
    public float smooth = 10.0f;
    Vector3 dollyDir;
    bool changeCamDolly = false;
    public Transform aim;
    //public Vector3 dollyDirectionAdjusted;
    public float distance;

    // Start is called before the first frame update
    void Awake()
    {
        dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredCameraPos = transform.parent.TransformPoint(dollyDir * maxDistance);

        RaycastHit hit;

        if (Input.GetAxis("Trigger_Left") > 0.5f)
        {
            distance = 1.0f;
            aim.transform.position = transform.position + transform.forward * 3;
            if (!changeCamDolly)
            {
                
                dollyDir = new Vector3(dollyDir.x+.5f, dollyDir.y + .5f, dollyDir.z);
                changeCamDolly = true;
              
            }
            
        }
        else
        {
            if (changeCamDolly)
            {
                dollyDir = new Vector3(dollyDir.x-.5f, dollyDir.y - .5f, dollyDir.z);
                changeCamDolly = false;
            }
            if (Physics.Linecast(transform.parent.position, desiredCameraPos, out hit))
            {
                distance = Mathf.Clamp(hit.distance * 0.9f, minDistance, maxDistance);
            }
            else
            {
                distance = maxDistance;
            }
        }

       

        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * distance, smooth * Time.deltaTime);
    }
}
