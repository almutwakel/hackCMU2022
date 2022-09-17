using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

   private RectTransform rectTransform;
   private CanvasGroup canvasGroup;

   private string str;
   
   private void Awake()
   {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
   }

   public void OnPointerDown(PointerEventData eventData)
   {
        //throw new System.NotImplementedException();
        //Debug.Log("OnPointerDown");
   }

   public void OnDrag(PointerEventData eventData)
   {
        //Debug.Log("Dragging");
        rectTransform.anchoredPosition += eventData.delta;
   }

   public void OnBeginDrag(PointerEventData eventData){
        //Debug.Log("BeginDrag");
        str = rectTransform.name;
        Debug.Log(str);
        int num = Int32.Parse(str.Substring(str.IndexOf("d") + 1));
        //selectFriend(num);
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
   }

   public void OnEndDrag(PointerEventData eventData){
        //Debug.Log("EndDrag");
        canvasGroup.alpha = 1f; 
        canvasGroup.blocksRaycasts = true;
        
   }
}
