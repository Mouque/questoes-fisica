using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionaQuestao : MonoBehaviour
{
    public string questao;

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
}
