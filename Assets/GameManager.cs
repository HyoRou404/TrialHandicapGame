using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    Vector3[] clonePosition =
    {
        new Vector3(55f,-8f,0),
        new Vector3(10f,-8f,0),
        new Vector3(55f,23f,0),
        new Vector3(10f,23f,0)
    };
    [SerializeField] private List<Character> characters = new List<Character>();
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(characters[0].parts[0], clonePosition[0],Quaternion.identity);
        Instantiate(characters[0].parts[1], clonePosition[1], Quaternion.identity);
        Instantiate(characters[0].parts[2], clonePosition[2], Quaternion.identity);
        Instantiate(characters[0].parts[3], clonePosition[3], Quaternion.identity);



    }

    // Update is called once per frame

   
}


[Serializable]
 public class Character
{
    public List<GameObject> parts;

    public string answer;
}

