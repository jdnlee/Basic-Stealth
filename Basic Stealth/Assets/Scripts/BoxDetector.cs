using System.Collections;
using UnityEngine;

public class BoxDetector : MonoBehaviour
{
 void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            Debug.Log("Found You!");
        }
    }
}