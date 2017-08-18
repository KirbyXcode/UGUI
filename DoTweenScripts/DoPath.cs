using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoPath : MonoBehaviour, IPointerClickHandler
{
    private DOTweenPath path;
    private void Start()
    {
        path = GameObject.Find("Image_Path").GetComponent<DOTweenPath>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        //path.DOPlay();
        path.DOTogglePause();
    }
}
