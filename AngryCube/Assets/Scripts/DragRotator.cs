using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRotator : MonoBehaviour
{
    public float rotation_speed = 100;
    Rigidbody rb;

    Vector2 mousePos;
    Vector3 screenPos;

    Vector3 startPos = Vector3.zero;
    Vector3 endPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.LogError("Here");
            mousePos = Input.mousePosition;

            if (startPos == Vector3.zero)
            {
                startPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));
            }

            screenPos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3 diff = screenPos - transform.position;
            float angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, 0, angle);


            //screenPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

            //Vector3 rotation_angle = new Vector3(0, 0, Mathf.Atan2((screenPos.y - transform.position.y), (screenPos.x - transform.position.x)) * Mathf.Rad2Deg);

            //transform.eulerAngles = rotation_angle;

        }

        if (Input.GetMouseButtonUp(0))
        {
            mousePos = Input.mousePosition;
            screenPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

            float magnitude = (screenPos - startPos).magnitude;

            //rb.AddForce(new Vector3(0,magnitude * 20,0));
            //rb.AddTorque(new Vector3(0,0, magnitude * 5));
        }



    }
}
