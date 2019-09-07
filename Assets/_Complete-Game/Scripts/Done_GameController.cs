using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text scoreText;
    public Text score_end;

    //public Text restartText;
    public GameObject Gameover_endUI;
   
    public Text gameOverText;


    public static bool gameOver;
    public bool restart;
    public int score;

    public GameObject GameOverUI;

    void Start()
    {
        gameOver = false;
        restart = false;
        gameOverText.text = " ";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        //重玩游戏
        if (restart)
        {
            Gameover_endUI.SetActive(true);

        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restart = true;
                //restartText.text = "Press 'R' for Restart！！";
                
                break;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
        score_end.text = "最终分数 " + score;
    }

    public void GameOver()
    {
        //gameOverText.text = "Game Over!";
        GameOverUI.SetActive(true);
        //Time.timeScale = 0;
        gameOver = true;

    }
}