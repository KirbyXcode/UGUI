using UnityEngine;
using System.Collections;


public class CubeRotate : MonoBehaviour
{
    private float speed;
    private RotateSpeedChange m_CubeRotate;
    
    private void Start()
    {
        m_CubeRotate = FindObjectOfType<RotateSpeedChange>();
    }

    public void Rotate(float speed)
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
    void Update ()
    {
        Rotate(m_CubeRotate.rotSpeed);
    }
}
