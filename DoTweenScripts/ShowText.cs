using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ShowText : MonoBehaviour,IPointerClickHandler
{
    private Text tex;
    private bool b = false;

    private void Start()
    {
        tex = GameObject.Find("Text_ShowContent").GetComponent<Text>(); 
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!b)
        {
            tex.DOText("第二篇章，黑暗森林的小木屋", 3);
            b = true;
        }
        else
        {
            tex.DOFade(0, 2);
            //tex.DOColor(Color.red, 2);
            b = false;
        }
    }
}
