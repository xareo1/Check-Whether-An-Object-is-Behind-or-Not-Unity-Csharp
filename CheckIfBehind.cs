using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfBehind : MonoBehaviour
{
    public bool isBehind;
    public GameObject target;

    private void FixedUpdate()
    {
        Check();
    }

    public void Check()
    {
        Vector3 objectForward = gameObject.transform.forward;
        Vector3 objectToCheck = target.transform.position - gameObject.transform.position;

        if (Vector3.Dot(objectForward, objectToCheck) > 0)
        {
            isBehind = false;
            // put logic here
        }
        else
        {
            isBehind = true;
            // put logic here
        }
    }
}
