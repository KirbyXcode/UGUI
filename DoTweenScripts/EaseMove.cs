using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;

public class EaseMove : MonoBehaviour,IPointerClickHandler
{	
    private RectTransform imgRTF;
    private bool isMove;
    private Tweener tweener;

    void Start()
    {
        imgRTF = GameObject.Find("Image_Ease").GetComponent<RectTransform>();
        tweener = imgRTF.DOMove(new Vector3(0, 0, 0),2);
        
        tweener.SetAutoKill(false);
        tweener.Pause();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(!isMove)
        {
            tweener.SetEase(Ease.OutBounce); //动画曲线
            //tweener.SetLoops(-1); //动画循环
            imgRTF.DOPlayForward();

            tweener.OnStepComplete(OnTweenCompleteDown); //动画播放完毕执行相应事件
            isMove = true;
        }
        else
        {
            tweener.SetEase(Ease.InBounce);
            imgRTF.DOPlayBackwards();

            tweener.OnStepComplete(OnTweenCompleteUp);
            isMove = false;
        }
    }

    private void OnTweenCompleteDown()
    {
        Debug.Log("下拉动画执行完毕");
    }

    private void OnTweenCompleteUp()
    {
        Debug.Log("上拉动画执行完毕");
    }
}
