using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class yonetici : MonoBehaviour
{
    public GameObject boru;
    int skor = 0;
    public TextMeshProUGUI skor_txt;
    
    void Start()
    {
        InvokeRepeating("boru_ekle", 0.0f, 6.0f);
        skor_txt.text = skor.ToString();
    }

    void boru_ekle()
    {
        GameObject yeni_boru = Instantiate(boru);
    }
    public void skor_arttýr(int deger)
    {
        skor += deger;
        skor_txt.text = skor.ToString();
    }
}
