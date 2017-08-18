using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoAnim : MonoBehaviour,IPointerClickHandler
{
    private DOTweenAnimation anim;
    private bool b = false;

    private void Start()
    {
        anim = GameObject.Find("Image_Animation").GetComponent<DOTweenAnimation>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!b)
        {
            anim.DOPlay();
            b = true;
        }
        else
        {
            anim.DOPause();
            b = false;
        }
    }
}
