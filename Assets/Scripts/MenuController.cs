using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject simulationButton;
    public GameObject navButton;
    public GameObject navMenu;
    public GameObject navMenuText;

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }	

    public void NavButton()
    {
        simulationButton.SetActive(false);
        navButton.SetActive(false);
        navMenu.SetActive(true);
        navMenuText.SetActive(true);
        
    }
}
