using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class suruklemeisi : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject panel;
    public Vector3 ilkPozisyon;

    void Start()
    {
        ilkPozisyon = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //print("Sürükleme Başladı.");
        transform.position = Input.mousePosition; //mouse ile objeyi hareket ettirme (sürükleme)
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float mesafe = Vector3.Distance(transform.position, panel.transform.position);
        if (mesafe < 256f)
        {
            transform.SetParent(panel.transform);  //panel objene bunu evlatlık verdin.
        }
        else
        {
            transform.position = ilkPozisyon;
        }
        //print(mesafe.ToString());
        //print("Sürükleme Bitti.");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print("tıklandı");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("bırakıldı.");
    }
}
