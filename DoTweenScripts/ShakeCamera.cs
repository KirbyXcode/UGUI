using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;


public class ShakeCamera : MonoBehaviour,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Camera.main.transform.DOShakePosition(3,new Vector3(20,20,0));
    }
}
