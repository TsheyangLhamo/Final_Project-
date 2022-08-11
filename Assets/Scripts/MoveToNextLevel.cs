using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public GameObject AllEnemy;
    public string LevelName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AllEnemy.transform.childCount <= 0)
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
