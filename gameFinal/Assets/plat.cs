using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}