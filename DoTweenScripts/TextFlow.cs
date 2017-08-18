using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;


public class TextFlow : MonoBehaviour, IPointerClickHandler
{
    private DOTweenAnimation[] anim;
    private void Start()
    {
        anim = GameObject.Find("Text_Flow").GetComponents<DOTweenAnimation>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < anim.Length; i++)
        {
            anim[i].DOPlay();
        }
    }
}
