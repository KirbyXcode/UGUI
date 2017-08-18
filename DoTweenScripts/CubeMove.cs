using UnityEngine;
using System.Collections;


public class CubeMove : MonoBehaviour
{	

    void Update ()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(391, -52, 758), 0.05f);
    }
}
