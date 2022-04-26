using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        if(target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
		   
        }
	    if(target.position.y < transform.position.y - 15)
		{

		SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
		print("DEATH");
		}
	

    }
}
