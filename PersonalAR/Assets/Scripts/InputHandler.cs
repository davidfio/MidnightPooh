using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Ray ray;
    private RaycastHit raycastHit;
    private TouchableObject currentTouchableObject;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out raycastHit, Mathf.Infinity))
            {
                TouchableObject touchableObj = raycastHit.collider.gameObject.GetComponent<TouchableObject>();
                if (touchableObj)
                {
                    //Set off the hitted object
                    //currentTouchableObject.gameObject.SetActive(false);

                    currentTouchableObject = touchableObj;

                    Debug.Log(touchableObj.name);
                    Debug.Log(Vector3.Distance(this.gameObject.transform.position, currentTouchableObject.transform.position));
                }
                else
                {
                    if (currentTouchableObject)
                        currentTouchableObject = null;
                }

                Debug.Log(Vector3.Distance(this.gameObject.transform.position, currentTouchableObject.transform.position));
            }
        }
    }
}
