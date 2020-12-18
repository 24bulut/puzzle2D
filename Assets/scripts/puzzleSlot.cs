using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class puzzleSlot : MonoBehaviour,IDropHandler
{
    public bool matched = false;
    public void OnDrop(PointerEventData eventData){
       if (eventData.pointerDrag != null)
       {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //Debug.Log(eventData.pointerDrag.tag);
            if (eventData.pointerDrag.tag==gameObject.tag)
            {
                //Debug.Log("eşleşti !!!!!!");
                matched=true;
            }else
            {
                matched=false;                
            }
       }
    }
}
