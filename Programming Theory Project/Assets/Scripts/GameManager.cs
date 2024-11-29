using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text gameOverText;
    [SerializeField] private Button restartButton;

    //[SerializeField] private bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        //isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        //gameOverText.gameObject.SetActive(true);
        gameOverPanel.SetActive(true);
        //isGameActive = false;

        //restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}