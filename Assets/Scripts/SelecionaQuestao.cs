using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionaQuestao : MonoBehaviour
{
    public string questao;
    public int gm; // 0 para simulação, 1 para navegação

    private void Start()
    {   
        gm = PlayerPrefs.GetInt("GameMode");
        if(gm == 0){
            HideButton();
        }    
    }

    public void SetNextQuestion(string questao){
        PlayerPrefs.SetString("NextQuestion", questao);
    }

    public void GetNextQuestion(){
        questao = PlayerPrefs.GetString("NextQuestion");
    }

    public void loadScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("NextQuestion"));
    }	

    public void voltar()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void HideButton()
    {
        GameObject.Find("VoltarAoMenu").SetActive(false);
    }

    public void ChangeGameMode(int gm){
        PlayerPrefs.SetInt("GameMode", gm);
    }
}
