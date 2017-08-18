using UnityEngine;
using System.Collections;
using DG.Tweening;


public class MoveValue : MonoBehaviour
{
    //public Vector3 pos = Vector3.zero;
    private Vector3 pos;
    
    void Start()
    {
        pos = transform.position;
        float yy = transform.position.y;
        //DOTween.To(() => pos, x => pos = x,new Vector3(10,10,10),2);
        DOTween.To(() => pos, y => pos = y, new Vector3(0, 0, 0), 3);
    }

    void Update()
    {
        transform.position = pos;
    }
}
