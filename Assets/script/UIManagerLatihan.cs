using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManagerLatihan : MonoBehaviour
{

    public RectTransform popupBerhasil, popupGagal;

    public void showPopupBerhasil()
    {
        popupBerhasil.DOAnchorPos(new Vector2(0, -441), 0.25f);
    }

    public void showPopupGagal()
    {
        popupGagal.DOAnchorPos(new Vector2(0, -441), 0.25f);
    }

    public void hidePopupGagal()
    {
        popupGagal.DOAnchorPos(new Vector2(0, -1280), 0.25f);
    }
}
