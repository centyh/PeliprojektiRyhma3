using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform Image;
    

    public void Start()
    {
        Image.GetComponent<Animator>().Play("Base Layer.HoverOff");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {        
        Image.GetComponent<Animator>().Play("Base Layer.HoverOn");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Image.GetComponent<Animator>().Play("Base Layer.HoverOff");
    }
}
