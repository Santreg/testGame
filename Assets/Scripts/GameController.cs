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
    public Text score;


    public static GameController Instance;
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartEarthLevel()
    {

    }
    void StartMoonLevel()
    {

    }
    void StartJupiterLevel()
    {

    }
}
