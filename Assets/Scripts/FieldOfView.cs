using UnityEngine;
using System.Collections;

public class FieldOfView : MonoBehaviour {

    public float viewRadius;
    public float viewAngle;

    public Vector3 DirFromAngle(float angleInDegress){
        Vector3 result = new Vector3(Mathf.Sin(angleInDegress * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegress * Mathf.Deg2Rad));
        return result;
    }
}
