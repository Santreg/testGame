using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update



    [SerializeField]
    public PlanetData earth;
    public PlanetData moon;
    public PlanetData jupiter;

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
        
    }
    public void IncrScore() {
        score++;

        scoreText.text = score.ToString();
    }
    public void StartEarthLevel()
    {
        menu.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        platforms.gameObject.SetActive(true);

        

        Physics.gravity = new Vector3(0, earth.Gravity,0);
        Camera.main.backgroundColor = earth.Col;
    }
    public void StartMoonLevel()
    {
        menu.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        platforms.gameObject.SetActive(true);

        var ball = Instantiate(ballPrefab);


        Physics.gravity = new Vector3(0, moon.Gravity, 0);
        Camera.main.backgroundColor = moon.Col;
    }
    public void StartJupiterLevel()
    {
        menu.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        platforms.gameObject.SetActive(true);

        var ball = Instantiate(ballPrefab);


        Physics.gravity = new Vector3(0, jupiter.Gravity, 0);
        Camera.main.backgroundColor = jupiter.Col;
    }
    public void Back() {
        Camera.main.backgroundColor = menuColor;
        menu.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        platforms.gameObject.SetActive(false);

         Destroy(instanceBall);
    }
    public void SpawnBall()
    {
        var ball = Instantiate(ballPrefab);
        instanceBall = ball;
    }

    
}
