using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject parent;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        // item = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
    plane.transform.position = RotatePointAroundPivot(plane.transform.position, parent.transform.position, Quaternion.Euler(0, 50 * Time.deltaTime, 0));
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle) {
       return angle * ( point - pivot) + pivot;
    }
}
