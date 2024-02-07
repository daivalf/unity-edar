using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;

public class UIManagerDenyutNadi : MonoBehaviour
{
    public RectTransform langkah1, langkah2, langkah3, langkah4, langkah5, langkah5setengah, langkah6, langkah7, langkah8, langkah9, popupSelesai, bg1, bg2;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void pindahLangkah2()
    {
        langkah1.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah2.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pindahLangkah3()
    {
        langkah2.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah3.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pindahLangkah4()
    {
        langkah3.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah4.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pindahLangkah5()
    {
        langkah4.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah5.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pindahLangkah5setengah()
    {
        langkah5.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah5setengah.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pindahLangkah6()
    {
        langkah5setengah.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah6.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void pindahLangkah7()
    {
        langkah6.DOAnchorPos(new Vector2(-1000, 0), 0.25f);
        langkah7.DOAnchorPos(new Vector2(0, 0), 0.25f);
        bg1.DOAnchorPos(new Vector2(-1000, 0), 0f);
        bg2.DOAnchorPos(new Vector2(0, 0), 0f);
    }
    public void pindahLangkah8()
    {
        langkah7.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah8.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void pindahLangkah9()
    {
        langkah8.DOAnchorPos(new Vector2(-830, 0), 0.25f);
        langkah9.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void showPopup()
    {
        popupSelesai.DOAnchorPos(new Vector2(0, -441), 0.25f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
