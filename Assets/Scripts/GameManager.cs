using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    //banco de dados
    MongoClient client = new MongoClient("mongodb+srv://userDS:tLoZQ7UacyaGfHOC@cluster0.s7umrfl.mongodb.net/login?retryWrites=true&w=majority");
    IMongoDatabase database;
    IMongoCollection<BsonDocument> collection;

    //dados a serem coletados
    public string quest;
    public string resposta;
    public int certeza;
    public string tempo;

    //cronometro
    public bool Cronometro;

    public float segundos;
    public int min;
    public int horas;
   


    // Start is called before the first frame update
    void Start()
    {
        database = client.GetDatabase("Quest");
       
    }

    public void Awake()
    {


        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }



    }


    void FixedUpdate()
    {
        //Cronometro
        if (Cronometro)
        {
            segundos += Time.deltaTime;
        }

        if (segundos >= 60)
        {
            min++;
            segundos = 0;
        }
        if (min >= 60)
        {
            horas++;
            min = 0;
        }
        
    }


    public void Salvar()
    {        
        atualizarTempo();
        SalvarDadosMongo();
        ZerarCronometro();
    }   

    public void atualizarTempo()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString();
        if (horas <= 1)
        {
            if (horas == 0)
            {
                 tempo = time + " Tempo de escolha = " + min.ToString() + "min e " + segundos.ToString("00") + "s";
            }
            else
            {
                tempo = time + " Tempo de escolha = " + horas.ToString() + "h e " + min.ToString() + "min";
            }

        }
        else
        {
            tempo = time + " Tempo de escolha = " + horas.ToString() + "hrs e " + min.ToString() + "min";
        }

        print(tempo);
    }

    // Controle Cronometro

    public void ZerarCronometro()
    {
        segundos = 0;
        min = 0;
        horas = 0;
    }   

    public void PausarCronometro()
    {
        Cronometro = false;
    }
    public void AtivarCronometro()
    {
        Cronometro = true;
    }

    // Base de dados

    public class Dados
    {
        public ObjectId _id { get; set; }

        public string Questao { get; set; }    
        public string Resposta { get; set; }
        public int Certeza { get; set; }
        public string Tempo { get; set; }
        

    }

    public void SalvarDadosMongo()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString();
        var dados = new Dados { Questao = quest, Resposta = resposta, Certeza = certeza, Tempo= tempo };

        inserirRecord(dados);
        print("dados salvos");
    }

    public async void inserirRecord<T>(T record)
    {
        var collection = database.GetCollection<T>("dados");
        await collection.InsertOneAsync(record);
    }

}
