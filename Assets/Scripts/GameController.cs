using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public Image winScreen;
    public PlayerController other;

    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioSource musicSource;

    private bool gameOver;
    private bool restart;
    private int score;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        winScreen.enabled = false;

        score = 0;

   
    }


    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

     

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.tag == "pickup")
            {
                score += 1;
         
                Destroy(collision.collider.gameObject);
            }
        }

        void UpdateScore()
        {
            scoreText.text = "Bottles: /3" + score;
            if (score >= 3)
            {
                GameObject.Find("PlayerController");
                musicSource.clip = musicClipTwo;
                musicSource.Play();
                winScreen.enabled = true;
                gameOver = true;
                restart = true;
            }
        }


        void GameOver()
        {
            gameOverText.text = "Game Over!";
            gameOver = true;
        }


    }
}