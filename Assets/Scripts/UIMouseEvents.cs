using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIMouseEvents : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // private Transform parent;
    public GameObject copyLocation;

    /*
    private void Start()
    {
        copyLocation = transform.parent.parent.parent.parent;
    }
    */


    public void OnBeginDrag(PointerEventData eventData)
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<BoxCollider2D>().isTrigger = false;

        if (this.GetComponent<Identities>().positionStatus == Identities.Position.Column)
        {
            GameObject copy = Instantiate(this.gameObject, eventData.position, Quaternion.identity);
            copy.transform.SetParent(copyLocation.transform, false);
            copy.GetComponent<Identities>().positionStatus = Identities.Position.Canvas;
            eventData.pointerDrag = copy;
        }
        
    }



    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }



    public void OnEndDrag(PointerEventData eventData)
    {
        this.GetComponent<BoxCollider2D>().enabled = true;
        this.GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
