using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset;

    Vector3 currPos;

    void Awake()
    {
        offset = transform.position - Player.transform.position;
        transform.position = Player.transform.position + offset;
    }

    void LateUpdate()
    {
        currPos.Set(0,Player.transform.position.y + offset.y,transform.position.z);
        transform.position = currPos;
    }
}