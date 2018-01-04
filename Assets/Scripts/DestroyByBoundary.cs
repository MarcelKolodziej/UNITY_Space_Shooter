using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        Object.DestroyObject(other.gameObject);
    }
}