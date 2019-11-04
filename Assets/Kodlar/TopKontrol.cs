using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public int hiz;
    int sayac=0;
    Rigidbody fizik;
    public int toplanicakObjeSayisi;
    public Text sayacText;
    public Text oyunBittiText;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");   // topu saga sola hareket
        float dikey = Input.GetAxisRaw("Vertical");
        
        Vector3 vec = new Vector3(yatay, 0, dikey); // y = 0, x ve z değeri yukarıdan geliyor

        fizik.AddForce(vec*hiz);
    }

    // trigger bir objeye temas edıldıgınde bu metot calısır.
    // ontriggerenter temas oldugunda 1 kera calısır
    // ontriggerstay temas oldugu surece calısır
    // ontriggerexit temas olduktan cıktıktan sonra calısır.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel") // gelen objenin tag'i engel ise onu yok eder
        {
            other.gameObject.SetActive(false);
            sayac++; // objeye her carpıldıgında sayacı 1 arttır
            Debug.Log(sayac);
            //Destroy(other.gameObject); // temas edilen objeyi yok eder

            sayacText.text = "Sayac : " + sayac;

            if (sayac == toplanicakObjeSayisi)
            {
                oyunBittiText.text = "Tebrikler!! Hepsini topladınız";
            }
        }
    }
}
