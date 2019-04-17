using UnityEngine;
using UnityEngine.AI;
public class CharacterController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent  agent;

    // Update is called once per frame
    void Update()
    {   
        // CHECK IF THE MOUSE IS PRESSED
        if (Input.GetMouseButtonDown(0))
        {
            // SENDING OUT A RAY TO WHERE THE MOUSE IS LOCATED
           Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit; 

            // CHECKING IF THE RAY HITS SOMETHING 
           if (Physics.Raycast(ray, out hit))
           {
               // MOVE OUR AGENT
               agent.SetDestination(hit.point);
           }

        }
    }
}
