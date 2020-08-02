using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdlePosition : MonoBehaviour
{
    Transform[] child;
    // Start is called before the first frame update
    void Start()
    {
        child = new Transform[2];
        child[0] = transform.GetChild(0);
        child[1] = transform.GetChild(1);

        randomizePosition();

    }

    void randomizePosition()
    {
        child[0].transform.position = new Vector3(Random.Range(0.5f, 2.5f), transform.position.y, transform.position.z);
        child[1].transform.position = new Vector3(child[0].transform.position.x - 3, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("HurdleGenerator").GetComponent<HurdleGenerator>().spawnHurdle();
        GetComponent<BoxCollider>().enabled = false;
        GameObject.FindObjectOfType<HUDController>().UpdateScore();
        Destroy(gameObject, 10);

    }

}
