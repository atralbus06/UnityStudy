using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float time;
    bool isGameover;

    int deleteCount = 3;

    [SerializeField] GameObject gameoverText;
    [SerializeField] Text timeText;
    [SerializeField] Text bestTimeText;
    [SerializeField] Text deleteCountText;

    Spawner spawner;

    void Awake()
    {
        time = 0f;
        isGameover = false;

        gameoverText.SetActive(false);
        spawner = FindObjectOfType<Spawner>().GetComponent<Spawner>();
    }

    void Update()
    {
        if (!isGameover)
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + string.Format("{0:f2}", time);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene("Dodge");
        }

        deleteCountText.text = "" + deleteCount;

        if (Input.GetKeyDown(KeyCode.Space) && deleteCount != 0)
        {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");

            foreach (GameObject bullet in bullets)
            {
                Destroy(bullet);
            }

            deleteCount--;
        }

        if (time % 5 == 0 && spawner.intervalMax > spawner.intervalMin && spawner.intervalMin > 0.2f)
        {
            spawner.intervalMax -= 0.1f;
            spawner.intervalMin -= 0.05f;
        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime", 0f);

        if (time > bestTime)
        {
            bestTime = time;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        bestTimeText.text = "Best Time: " + string.Format("{0:f2}", time);
    }
}
