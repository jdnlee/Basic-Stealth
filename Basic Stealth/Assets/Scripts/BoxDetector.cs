using System.Collections;
using UnityEngine;

public class BoxDetector : MonoBehaviour
{
 void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Found You!");
        }
    }
}