using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Change : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene()
    {
      SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
