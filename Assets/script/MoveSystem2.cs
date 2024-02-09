using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MoveSystem2 : MonoBehaviour
{
    public GameObject jawaban1, jawaban2, jawaban3, jawaban4, jawaban5, pilihan1, pilihan2, pilihan3, pilihan4, pilihan5;

    Vector2 pilihan1InitialPos, pilihan2InitialPos, pilihan3InitialPos, pilihan4InitialPos, pilihan5InitialPos;

    public bool pilihan1Correct, pilihan2Correct, pilihan3Correct, pilihan4Correct, pilihan5Correct = false;

    public RectTransform popupBerhasil, popupGagal;

    void Start()
    {
        pilihan1InitialPos = pilihan1.transform.position;
        pilihan2InitialPos = pilihan2.transform.position;
        pilihan3InitialPos = pilihan3.transform.position;
        pilihan4InitialPos = pilihan4.transform.position;
        pilihan5InitialPos = pilihan5.transform.position;
    }

    public void DragPilihan1()
    {
        pilihan1.transform.position = Input.mousePosition;
    }

    public void DragPilihan2()
    {
        pilihan2.transform.position = Input.mousePosition;
    }

    public void DragPilihan3()
    {
        pilihan3.transform.position = Input.mousePosition;
    }

    public void DragPilihan4()
    {
        pilihan4.transform.position = Input.mousePosition;
    }

    public void DragPilihan5()
    {
        pilihan5.transform.position = Input.mousePosition;
    }

    public void DropPilihan1()
    {
        float Distance = Vector3.Distance(pilihan1.transform.position, jawaban1.transform.position);
        if (Distance<15)
        {
            pilihan1.transform.position = jawaban1.transform.position;
            pilihan1Correct = true;
        }
        else
        {
            pilihan1.transform.position = pilihan1InitialPos;
        }
    }

    public void DropPilihan2()
    {
        float Distance = Vector3.Distance(pilihan2.transform.position, jawaban2.transform.position);
        if (Distance<15)
        {
            pilihan2.transform.position = jawaban2.transform.position;
            pilihan2Correct = true;
        }
        else
        {
            pilihan2.transform.position = pilihan2InitialPos;
        }
    }

    public void DropPilihan3()
    {
        float Distance = Vector3.Distance(pilihan3.transform.position, jawaban3.transform.position);
        if (Distance<15)
        {
            pilihan3.transform.position = jawaban3.transform.position;
            pilihan3Correct = true;
        }
        else
        {
            pilihan3.transform.position = pilihan3InitialPos;
        }
    }

    public void DropPilihan4()
    {
        float Distance = Vector3.Distance(pilihan4.transform.position, jawaban4.transform.position);
        if (Distance<15)
        {
            pilihan4.transform.position = jawaban4.transform.position;
            pilihan4Correct = true;
        }
        else
        {
            pilihan4.transform.position = pilihan4InitialPos;
        }
    }

    public void DropPilihan5()
    {
        float Distance = Vector3.Distance(pilihan5.transform.position, jawaban5.transform.position);
        if (Distance<15)
        {
            pilihan5.transform.position = jawaban5.transform.position;
            pilihan5Correct = true;
        }
        else
        {
            pilihan5.transform.position = pilihan5InitialPos;
        }
    }

    public void CekHasil()
    {
        if (pilihan1Correct && pilihan2Correct && pilihan3Correct && pilihan4Correct && pilihan5Correct)
        {
            showPopupBerhasil();
        }
        else
        {
            showPopupGagal();
        }
    }

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