using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boru : MonoBehaviour
{
    //-4f te 0sil 3.55f e ekle
    //borunun maks gideceði yer  y= 1.09f -0.01f
    yonetici yonet;
    void Start()
    {
        float rast = Random.Range(-0.01f, 1.09f);
        transform.position = new Vector3(3.55f, rast, transform.position.z);
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <=-4f)
        {
            yonet.skor_arttýr(10);
            Destroy(gameObject);
        }
        transform.Translate(-1f * Time.deltaTime, 0, 0);
    }
}
