using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookItem : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler, IGvrPointerHoverHandler
{
    public void OnLookItemBox(bool isLookAt)
    {
        Debug.Log(isLookAt);
        MoveCtr1.isStopped = isLookAt;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        MoveCtr1.isStopped = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        MoveCtr1.isStopped = false;
    }
    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("Reticle On");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
