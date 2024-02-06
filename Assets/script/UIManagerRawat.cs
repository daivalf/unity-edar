using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManagerRawat : MonoBehaviour
{

    public RectTransform page1, page2, page3, page4, page5, popupSelesai;
    // Start is called before the first frame update
    void Start()
    {
        page1.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void moveToPage2()
    {
        page1.DOAnchorPos(new Vector2(-800, 0), 0.25f);
        page2.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void moveToPage3()
    {
        page2.DOAnchorPos(new Vector2(-800, 0), 0.25f);
        page3.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void moveToPage4()
    {
        page3.DOAnchorPos(new Vector2(-800, 0), 0.25f);
        page4.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void moveToPage5()
    {
        page4.DOAnchorPos(new Vector2(-800, 0), 0.25f);
        page5.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void showPopup()
    {
        popupSelesai.DOAnchorPos(new Vector2(0, -441), 0.25f);
    }

}
