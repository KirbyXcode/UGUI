using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;


public class FromTween : MonoBehaviour,IPointerClickHandler
{
    public Transform cubeTF;
    private bool b = false;
    private float timer;
    public void OnPointerClick(PointerEventData eventData)
    {
        //cubeTF.DOMoveX(5, 3).From();
        //cubeTF.DOMoveX(5, 3).From(true);
        //cubeTF.DOLocalMoveX(5, 3).From();
        //cubeTF.DOLocalMoveX(600, 3).From(true);
        if(!b)
        {
            cubeTF.DOLocalMoveX(600, 3).From(true);
            timer = 3;
            b = true;
        }
    }

    private void DoMoveTrigger()
    {
        if(b)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                b = false;
            }
        }
    }

    private void Update()
    {
        DoMoveTrigger();
    }
}
