using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Pingpang : MonoBehaviour, IPointerClickHandler
{
    private RectTransform imgRTF;
    private bool isMove = false;

    void Start ()
    {
        imgRTF = GameObject.Find("Image_Ping-Pang").GetComponent<RectTransform>();
        Tweener tweener = imgRTF.DOMove(new Vector3(0, 0, 0), 0.5f); //默认动画播放完成会被销毁
        //Tweener对象保存着动画的信息，每次调用do类型的方法都会创建一个Tweener对象，这个对象是DoTween来管理的
        tweener.SetAutoKill(false);
        tweener.Pause();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isMove)
        {
            //imgRTF.DOPlay(); //只会播放一次
            imgRTF.DOPlayForward();
            isMove = true;
        }
        else
        {
            imgRTF.DOPlayBackwards();
            isMove = false;
        }
    }
}
