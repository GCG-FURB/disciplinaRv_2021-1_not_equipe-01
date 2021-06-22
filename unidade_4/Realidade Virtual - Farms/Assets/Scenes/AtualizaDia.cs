using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class AtualizaDia : MonoBehaviour
{
    // Start is called before the first frame update
    private int dia = 1;
    private int cont = 1;
    private TextMeshPro textDia;
    void Start()
    {
        textDia = GetComponent<TextMeshPro>();
        textDia.SetText(dia.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        dia += 1;
        if (dia == 1000) {
            cont++;
            textDia.SetText(cont.ToString());
            dia = 0;
        }
        //Thread.Sleep(100);
    }
  
}
