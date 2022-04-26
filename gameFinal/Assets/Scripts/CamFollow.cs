using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
	public SpriteRenderer spriteRenderer;
	public Sprite newSprite;
	public Sprite newSprite2;

    void LateUpdate()
    {
        if(target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
		   spriteRenderer.sprite = newSprite;

        } 

		if(target.position.y < transform.position.y)
		{

		spriteRenderer.sprite = newSprite2;
		
		}
		
		if(target.position.x < transform.position.x){
		target.localRotation = Quaternion.Euler(0, 180, 0);
		} else {
		target.localRotation = Quaternion.Euler(0, 360, 0);
		}


	    if(target.position.y < transform.position.y - 15)
		{

		SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
		print("DEATH");
		}
	

    }

}
