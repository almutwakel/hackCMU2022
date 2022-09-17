using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Drop : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("On Drop");
        if (eventData.pointerDrag != null){
            string str = GetComponent<RectTransform>().name;
            Debug.Log(str);
            int num = Int32.Parse(str.Substring(str.IndexOf("e") + 1));
            //selectRole(num);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
