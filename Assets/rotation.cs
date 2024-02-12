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
    // plane.transform.position = RotatePointAroundPivot(plane.transform.position, parent.transform.position, Quaternion.Euler(0, 50 * Time.deltaTime, 0));
    // https://docs.unity3d.com/2018.1/Documentation/ScriptReference/Transform.Rotate.html
    parent.transform.Rotate(Vector3.up * Time.deltaTime * 100);
    }

    // https://docs.unity3d.com/ScriptReference/Transform.RotateAround.html
    // https://gamedev.stackexchange.com/questions/61981/unity3d-orbit-around-orbiting-object-transform-rotatearound#62002
    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle) {
       return angle * ( point - pivot) + pivot;
    }
}
