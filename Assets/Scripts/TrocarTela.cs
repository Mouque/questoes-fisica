using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarTela : MonoBehaviour
{
    public GameObject Painel;
    public GameObject Botao;

    

    private void Update()
    {
        
        
    }
    public void BotaoClicadoAbrir()
    {
        this.abrirTela();
    }
    public void BotaoClicadoFechar()
    {
        this.FecharTela();
    }


    private void abrirTela()
    {
        this.Painel.SetActive(true);
        this.Botao.SetActive(false);       


       
    }
    
    private void FecharTela()
    {
        this.Painel.SetActive(false);
        this.Botao.SetActive(true);

       
    }


   
}
