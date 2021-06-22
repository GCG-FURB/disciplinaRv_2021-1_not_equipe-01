using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Jogo : MonoBehaviour
{
    private TextMeshPro textDinheiro;
    private double dinheiro = 1000;
    private string StringDinheiro;
    private double animal = 100;
    private double planta = 50;
    private int dia = 1;
    public GameObject Vaca;
    public GameObject Vaca2;
    public GameObject Vaca3;
    public GameObject Vaca4;
    //public GameObject Plantacao;    
    public int numeroPlantacao = 32;
    
    void Start()
    {

       textDinheiro = GetComponent<TextMeshPro>(); 
       textDinheiro.SetText(dinheiro.ToString());
        Vaca.SetActive(false);
        Vaca2.SetActive(false); 
        Vaca3.SetActive(false);
        Vaca4.SetActive(false);

       /*GameObject.Find("Vaca4").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("Vaca3").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("Vaca2").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("Vaca").transform.localScale = new Vector3(0, 0, 0);*/
       
       GameObject.Find("TomatoPlant_01 (1)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (2)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (3)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (4)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (5)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (6)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (7)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (8)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (9)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (10)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (11)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (12)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (13)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (14)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (15)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (16)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (17)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (18)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (19)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (20)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (21)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (22)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (23)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (24)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (25)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (26)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (27)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (28)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (29)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (30)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (31)").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("TomatoPlant_01 (32)").transform.localScale = new Vector3(0, 0, 0);

    }

    void Update()
    {
    }
    
    private void OnTriggerEnter(Collider other) //colisão 
    {
        Debug.Log("Entrou");
        if (gameObject.tag == "CenaPrincipal")
        {
            Debug.Log("Teste  de comparacao");
            if (other.gameObject.CompareTag("Animal"))
            {
                Debug.Log("Vaca comprada");
                GameObject.Find("Vaca").transform.localScale = new Vector3(10, 10,10);
                dinheiro = dinheiro - animal;
                Debug.Log(dinheiro);
                textDinheiro.SetText(dinheiro.ToString());
            }
        }

        if (gameObject.tag == "Animal")
        {
            if (dinheiro < animal)
            {
                //MessageBox.Show("Dinheiro Insuficiente");
            }else{
                Debug.Log("Teste  de comparacao");
                if (other.gameObject.CompareTag("CenaPrincipal"))
                {
                    Debug.Log("Vaca comprada");
                    GameObject.Find("Vaca").transform.localScale = new Vector3(10, 10, 10);
                    dinheiro = dinheiro - animal;
                    Debug.Log(dinheiro);
                    textDinheiro.SetText(dinheiro.ToString());
                }
            }
        }

        if (gameObject.tag == "Plantacao")
        {
            todasPlantacoes(other.gameObject);
        }
    }
 
    public void todasPlantacoes(GameObject other){
        double valorTotal = planta * numeroPlantacao;

        if (dinheiro < valorTotal)
        {
            //MessageBox.Show("Dinheiro Insuficiente");
        }else{
            for (int i = 1; i <= numeroPlantacao; i++)
            {              
                Debug.Log("Teste de comparacao");
                if (other.gameObject.CompareTag("CenaPrincipal"))
                {
                    Debug.Log("Plantacao comprada");
                    GameObject.Find("TomatoPlant_01 (" + i + ")").transform.localScale = new Vector3(10, 10, 10);
                    dinheiro -= planta;
                    Debug.Log(dinheiro);
                    textDinheiro.SetText(dinheiro.ToString());
                }
            }
        }
    }


}
