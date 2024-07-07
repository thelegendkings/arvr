using UnityEngine;

public class VRControllerInteraction : MonoBehaviour
{
    private GameObject grabbedObject;
    private Vector3 offset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && hit.collider.CompareTag("Sphere"))
            {
                grabbedObject = hit.collider.gameObject;
                offset = grabbedObject.transform.position - hit.point;
            }
        }

        if (Input.GetMouseButton(0) && grabbedObject != null)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 100f;
            grabbedObject.GetComponent<Rigidbody>().MovePosition(Camera.main.ScreenToWorldPoint(mousePos) + offset);
        }

        if (Input.GetMouseButtonUp(0) && grabbedObject != null)
        {
            Rigidbody rb = grabbedObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = (Input.mousePosition - Camera.main.WorldToScreenPoint(grabbedObject.transform.position)) * 0.1f;
            }

            grabbedObject = null;
        }
    }
}
