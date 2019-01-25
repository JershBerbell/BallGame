using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.parent.SetParent(transform, true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.parent.SetParent(null, true);
        }
    }
}