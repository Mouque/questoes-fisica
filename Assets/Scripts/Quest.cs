using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
       gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DefResposta(string answ)
    {
        gameManager.resposta = answ;
        gameManager.PausarCronometro();
    }

    public void DefQuest(string Q)
    {
        gameManager.quest = Q;
    }

    public void DefCtz(int C)
    {
        gameManager.certeza = C;

    }
}
