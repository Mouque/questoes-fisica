using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarAlternativas : MonoBehaviour
{
    public GameObject quest;
    public GameObject answ;
    public List <GameObject> alternativas;
    public int i;
    public bool proximo;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (proximo)
        {
            StartCoroutine(Espera());
            proximo = false;
        }
        
    }

    public void Ativar()
    {
        quest.SetActive(false);
        i = 0;       
        

        
        StartCoroutine(Espera());
       
    }

    IEnumerator Espera()
    {
        alternativas[i].SetActive(true);
        yield return new WaitForSeconds(4f);
        alternativas[i].SetActive(false);
        if (i < alternativas.Count-1)
        {
            i++;
            proximo = true;
        }
        else
        {
            answ.SetActive(true);
            gameManager.AtivarCronometro();
        }

        print(alternativas[i]);


    }

}
