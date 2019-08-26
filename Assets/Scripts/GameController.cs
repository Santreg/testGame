using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameController : MonoBehaviour/*,IPointerDownHandler*/
{
    // Start is called before the first frame update

    public Transform menu;
    public Color menuColor;
    public int score;
    public Text scoreText;

    public GameObject instanceBall;

    public Transform platforms;

    public GameObject ballPrefab;

    public static GameController Instance;
    void Start()
    {
        Instance = this;
        score = 0;
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Back();
        }
    }

    public void IncrScore() {
        score++;

        scoreText.text = score.ToString();
    }
  
    public void Back() {
        Camera.main.backgroundColor = menuColor;
        menu.gameObject.SetActive(true);
        platforms.gameObject.SetActive(false);

         Destroy(instanceBall);
    }
    public void SpawnBall()
    {
        var ball = Instantiate(ballPrefab);
        instanceBall = ball;
    }
    public void StartLvl(PlanetData data)
    {
        Physics.gravity = new Vector3(0, data.Gravity, 0);
        Camera.main.backgroundColor = data.Col;
        menu.gameObject.SetActive(false);
        platforms.gameObject.SetActive(true);
        var ball = Instantiate(ballPrefab);

    }
   
}
