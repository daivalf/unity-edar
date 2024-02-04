using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float sisaWaktu;

    private void Update()
    {
        {
            if (sisaWaktu > 0)
            {
                sisaWaktu -= Time.deltaTime;
            }
            else if (sisaWaktu < 0)
            {
                sisaWaktu = 0;
            }
        }
        int menit = Mathf.FloorToInt(sisaWaktu / 60);
        int detik = Mathf.FloorToInt(sisaWaktu % 60);

        timer.text = string.Format("{0:00}:{1:00}", menit, detik);

    }
}
