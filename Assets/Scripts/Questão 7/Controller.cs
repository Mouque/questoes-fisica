using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject enunciado;
    public GameObject alternativaA;
    public GameObject alternativaB;
    public GameObject alternativaC;
    public GameObject alternativaD;
    public GameObject alternativaE;
    public GameObject todasAlternativas;
    // public GameObject feedback;
    // public GameObject loadingScreen;



    // estado da tela
    // 0 = enunciado
    // 1 = alternativa A
    // 2 = alternativa B
    // 3 = alternativa C
    // 4 = alternativa D
    // 5 = alternativa E
    // 6 = todas as alternativas 
    // 7 = pergunta de feedback
    // 8 = tela de loading
    private int state = 0;


    void Start() {
        state = 0;
        ChangeState();
    }

    // botão de próximo
    public void NextState() {
        if (state < 8) {
        state += 1;
        ChangeState();
        }
    }

    // botão de anterior
    public void PreviousState() {
        if (state > 0) {
        state -= 1;
        ChangeState();
        }
    }

    // checa o estado e muda
    public void ChangeState() {
        
        switch (state)
        {
            case 0:
                enunciado.SetActive(true);
                alternativaA.SetActive(false);
                alternativaB.SetActive(false);
                alternativaC.SetActive(false);
                alternativaD.SetActive(false);
                alternativaE.SetActive(false);
                todasAlternativas.SetActive(false);
                // feedback.SetActive(false);
                // loadingScreen.SetActive(false);
                break;
                
            case 1:
                enunciado.SetActive(false);
                alternativaA.SetActive(true);
                alternativaB.SetActive(false);
                alternativaC.SetActive(false);
                alternativaD.SetActive(false);
                alternativaE.SetActive(false);
                todasAlternativas.SetActive(false);
                // feedback.SetActive(false);
                // loadingScreen.SetActive(false);
                break;
            case 2:
                enunciado.SetActive(false);
                alternativaA.SetActive(false);
                alternativaB.SetActive(true);
                alternativaC.SetActive(false);
                alternativaD.SetActive(false);
                alternativaE.SetActive(false);
                todasAlternativas.SetActive(false);
                // feedback.SetActive(false);
                // loadingScreen.SetActive(false);
                break;
            case 3:
                enunciado.SetActive(false);
                alternativaA.SetActive(false);
                alternativaB.SetActive(false);
                alternativaC.SetActive(true);
                alternativaD.SetActive(false);
                alternativaE.SetActive(false);
                todasAlternativas.SetActive(false);
                // feedback.SetActive(false);
                // loadingScreen.SetActive(false);
                break;
            case 4:
                enunciado.SetActive(false);
                alternativaA.SetActive(false);
                alternativaB.SetActive(false);
                alternativaC.SetActive(false);
                alternativaD.SetActive(true);
                alternativaE.SetActive(false);
                todasAlternativas.SetActive(false);
                // feedback.SetActive(false);
                // loadingScreen.SetActive(false);
                break;
            case 5:
                enunciado.SetActive(false);
                alternativaA.SetActive(false);
                alternativaB.SetActive(false);
                alternativaC.SetActive(false);
                alternativaD.SetActive(false);
                alternativaE.SetActive(true);
                todasAlternativas.SetActive(false);
                // feedback.SetActive(false);
                // loadingScreen.SetActive(false);
                break;
            case 6:
                enunciado.SetActive(false);
                alternativaA.SetActive(false);
                alternativaB.SetActive(false);
                alternativaC.SetActive(false);
                alternativaD.SetActive(false);
                alternativaE.SetActive(false);
                todasAlternativas.SetActive(true);
                break;
            case 7:
                break;
            case 8:
                break;

        }
    }
}
