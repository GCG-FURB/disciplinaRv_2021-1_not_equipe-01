using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Jogo : MonoBehaviour
{
    public TextMeshPro textDinheiro;
    private double dinheiro = 2000;
    private string StringDinheiro;
    private double animal = 100;
    private double planta = 50;
    private double animalVenda = 150;
    private double plantaVenda = 100;
    public TextMeshPro textMessage;
    private string message = "Bem Vindo";
    /*public GameObject Vaca;
    public GameObject Vaca2;
    public GameObject Vaca3;
    public GameObject Vaca4;*/
    //public GameObject Plantacao;    
    public int numeroPlantacao = 32;
    private int vaca = 4;
    private int dia = 1;
    private int cont = 1;
    private int qtdPlantacao = 0;
    private int qtdVaca = 0;
    public TextMeshPro textDia;
    private int resto;
    
    private int precoAgua = 10;
    private int precoComida = 20;
    private int precoAdubo = 15;
    private int qtdAgua = 0;
    private int qtdComida = 0;
    private int qtdAdubo = 0;
    
    

    public void comprarAgua(){
        double total = 0;
        total = precoAgua * vaca;
        dinheiro -= total;
        textDinheiro.SetText(dinheiro.ToString());
        qtdAgua = 4;
    }

    public void comprarComida(){
        double total = 0;
        total = precoComida * vaca;
        dinheiro -= total; 
        textDinheiro.SetText(dinheiro.ToString());
        qtdComida = 4;
    }

    public void comprarAdubo(){
        double total = 0;
        total = precoAdubo * numeroPlantacao;
        dinheiro -= total;
        textDinheiro.SetText(dinheiro.ToString());
        qtdAdubo = 32;
    }


    


    void Start()
    {

       textDinheiro.SetText(dinheiro.ToString());
       textMessage.SetText(message.ToString());
       textDia.SetText(dia.ToString());
        /*Vaca.SetActive(false);
        Vaca2.SetActive(false); 
        Vaca3.SetActive(false);
        Vaca4.SetActive(false);*/

       GameObject.Find("Vaca4").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("Vaca3").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("Vaca2").transform.localScale = new Vector3(0, 0, 0);
       GameObject.Find("Vaca").transform.localScale = new Vector3(0, 0, 0);
       //GameObject.Find("Tomate").transform.localScale = new Vector3(0, 0, 0);
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
        cont += 1;       
        if (cont == 1000)
        {
            dia++;
            textDia.SetText(dia.ToString());
            cont = 0;
            message = "Compre";
            textMessage.SetText(message.ToString()); 

            // Vender Vaca
            if(qtdAgua == 4 && qtdComida == 4){
                if(dia % 10 == 0){
                    vendaVaca();    
                }    
            }else{
                if(dia % 20 == 0){
                    vendaVaca();
                }
            }

            // Venda Plantação
            if (qtdAdubo == 32){
                if(dia % 10 == 0){
                    vendaPlantacao();    
                }
            }else{
                if(dia % 20 == 0){
                    vendaPlantacao();
                }
            }
             
        }
    }
    
    public void vendaPlantacao(){
        double qtdVendaPlantacao = 0;
        double qtdTotal = 0;
        qtdVendaPlantacao = qtdPlantacao * plantaVenda;
        qtdTotal = qtdVendaPlantacao + dinheiro;
        textDinheiro.SetText(qtdTotal.ToString());
        for (int i = 1; i <= numeroPlantacao; i++)
        {
            GameObject.Find("TomatoPlant_01 (" + i + ")").transform.localScale = new Vector3(0, 0, 0);
        }
        qtdPlantacao = 0;
    }

    public void vendaVaca(){
        double qtdVendaVaca = 0;
        double qtdTotal = 0;
        qtdVendaVaca = qtdVaca * animalVenda;
        qtdTotal = qtdVendaVaca + dinheiro;
        textDinheiro.SetText(qtdTotal.ToString());
        GameObject.Find("Vaca").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Vaca2").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Vaca3").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Vaca4").transform.localScale = new Vector3(0, 0, 0);
        qtdVaca = 0;
    }


    private void OnTriggerEnter(Collider other) //colisão 
    {
        Debug.Log("Entrou");
        
        if (gameObject.tag == "CenaPrincipal")
        {
            todasVacas(other.gameObject);
        }
        
        if (gameObject.tag == "CenaPrincipal")
        {
            todasPlantacoes(other.gameObject);
        }
    }
 
    public void todasVacas(GameObject other){    
        Debug.Log("Teste  de comparacao");
        double valorTotal = vaca  * animal;
        if (dinheiro < valorTotal)
        {
            message = "Dinheiro Insuficiente";
            textMessage.SetText(message.ToString());
        }
        else
        {
            if (other.gameObject.CompareTag("Animal"))
            {
                Debug.Log("Vaca comprada");
                GameObject.Find("Vaca").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("Vaca2").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("Vaca3").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("Vaca4").transform.localScale = new Vector3(1, 1, 1);
                dinheiro = dinheiro - animal;
                Debug.Log(dinheiro);
                textDinheiro.SetText(dinheiro.ToString());
                qtdVaca = 4;
            }
        }
    }

    public void todasPlantacoes(GameObject other){
        double valorTotal = planta * numeroPlantacao;

        if (dinheiro < valorTotal)
        {
            message = "Dinheiro Insuficiente";
            textMessage.SetText(message.ToString());
        }
        else{
            for (int i = 1; i <= numeroPlantacao; i++)
            {              
                Debug.Log("Teste de comparacao");
                if (other.gameObject.CompareTag("Plantacao"))
                {
                    Debug.Log("Plantacao comprada");
                    GameObject.Find("TomatoPlant_01 (" + i + ")").transform.localScale = new Vector3(3, 3, 3);
                    dinheiro -= planta;
                    Debug.Log(dinheiro);
                    textDinheiro.SetText(dinheiro.ToString());
                    qtdPlantacao++;
                }
            }
        }
    }
    

}
