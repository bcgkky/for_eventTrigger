using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class eventtrigger :  MonoBehaviour
{

    public void OnPointerClick()
    {
        Debug.Log("Tıklandı");
    }

    public void OnPointerDown()
    {
        Debug.Log("butonu Basıldı down ile geldim");
    }

    public void OnPointerEnter()
    {
        Debug.Log("butonun üzerine gelindi");
    }

    public void OnPointerExit()
    {
        Debug.Log("butonun  Üzerinden ayrıldı");
    }

    public void OnPointerUp()
    {
        Debug.Log("Tıklama Bitti");
    }


    public void OnBeginDrag()
    {
        Debug.Log("Objenin üzerinde sürükleme başladı.");
    }

    public void OnDrag()
    {
        Debug.Log("obje sürükleniyor.");
    }

    public void OnEndDrag()
    {
        Debug.Log("Sürükleme bitti");
    }

    public  void OnCancel()
    {
        Debug.Log("vazgeçildi");
    }

    public  void OnDeselect()
    {
        Debug.Log("OnDeselect called.");
    }
      

    public  void OnDrop()
    {
        Debug.Log("OnDrop called.");
    }  
   
    public  void OnMove()
    {
        Debug.Log("hareket etti.");
    }   

    public  void OnScroll()
    {
        Debug.Log("OnScroll çalıştı.");
    }

    public  void OnSelect()
    {
        Debug.Log("Seçim yapıldı");
    }

    public  void OnSubmit()
    {
        Debug.Log("Seçimden vazgeçildi. Mouse ile boşluğuna tıklandı");
    }

    public  void OnUpdateSelected()
    {
        Debug.Log("Eleman Seçildi.");
    }


}
