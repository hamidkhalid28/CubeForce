using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float upForce;
    public float sideForce;
    public float torque;

    Vector2 screenBounds;
    float objectWidth;
    float objectHeight;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<MeshRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Input.mousePosition.x <= Camera.main.WorldToScreenPoint(transform.position).x)
            {
                rb.AddForce(new Vector3(-sideForce, upForce, 0),ForceMode.Impulse);
                rb.AddTorque(new Vector3(0, 0, Random.Range(-torque, torque)));
            }
            else
            {
                rb.AddForce(new Vector3(sideForce, upForce, 0),ForceMode.Impulse);
                rb.AddTorque(new Vector3(0, 0, Random.Range(-torque, torque)));
            }

            /*Vector3 objectPosition = transform.position;
            objectPosition.x = Mathf.Clamp(objectPosition.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
            transform.position = objectPosition;*/

        }
    }

    void LateUpdate()
    {
        //Vector3 objectPosition = transform.position;
        //objectPosition.x = Mathf.Clamp(objectPosition.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
        //transform.position = objectPosition;
    }
}
