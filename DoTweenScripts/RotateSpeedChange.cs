using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RotateSpeedChange : MonoBehaviour
{
    private Slider slider;
    public float rotSpeed;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        rotSpeed = (float)slider.value;
    }
}
