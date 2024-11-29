using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private HeroSlime player;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private bool isGameOver = false;

    private float xBound = 22.0f;
    private float yBound = 3.5f;

    // Update is called once per frame
    private void Start()
    {
        player = GameObject.Find("Hero_Slime").GetComponent<HeroSlime>();
    }
    void Update()
    {
        DestroyPlayerOutOfBound();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void DestroyPlayerOutOfBound()
    {
        if (player.gameObject.transform.position.y < -yBound)
        {
            isGameOver = true;
            Destroy(player.gameObject);
            GameOver();
        }

        else if (player.gameObject.transform.position.x < -xBound)
        {
            isGameOver = true;
            Destroy(player.gameObject);
            GameOver();
        }
    }
}