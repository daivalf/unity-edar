using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konfirmasiKeluar : MonoBehaviour
{

    [SerializeField] GameObject konfirmasi;

    public void keluar()
    {

    }

    public void bukaKonfirmasi()
    {
        konfirmasi.SetActive(true);
    }

    public void tutupKonfirmasi()
    {
        konfirmasi.SetActive(false);
    }
}
