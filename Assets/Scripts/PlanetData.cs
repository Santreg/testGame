using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PData", menuName = "Planet Data", order = 51)]
public class PlanetData : ScriptableObject
{
    [SerializeField]
    Color color;
    [SerializeField]
    float gravity;
}
