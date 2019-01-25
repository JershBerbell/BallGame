using UnityEngine;
using System.Collections;

public class HoldCharacter : MonoBehaviour
{
   
    void OnTriggerStay(Collider col)
    {
        col.transform.parent = gameObject.transform.parent;  
    }

    void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;
    }
}
