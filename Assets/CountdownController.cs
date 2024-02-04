using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public float waktuMulai;
    private float waktuSisa;

    public TMP_Text countdownText;
    public Button buttonMulai;

    // Update is called once per frame
    void Update()
    {
        if(waktuSisa > 0)
        {
            waktuSisa -= Time.deltaTime;
            countdownText.text = waktuSisa.ToString("0");
        }
        else
        {
            buttonMulai.gameObject.SetActive(true);
            countdownText.gameObject.SetActive(false);
        }
    }

    public void startClicked()
    {
        waktuSisa = waktuMulai;
        buttonMulai.gameObject.SetActive(false);
        countdownText.gameObject.SetActive(true);
    }
}
