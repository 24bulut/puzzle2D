using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragItem : MonoBehaviour,IDropHandler , IPointerDownHandler , IDragHandler,IBeginDragHandler, IEndDragHandler
{
    [SerializeField]
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData){
        canvasGroup.blocksRaycasts =false;
    }
    public void OnDrag(PointerEventData eventData){
        rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData){
        canvasGroup.blocksRaycasts =true;
    }
    public void OnPointerDown(PointerEventData eventData){
        //Debug.Log("deneme");
    }
    public void OnDrop(PointerEventData eventData){
        throw new System.NotImplementedException();
    }
}
