using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DieByEnemy : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Sprite newSprite;

    private ScoreManager theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "player") 
        {
			spriteRenderer.sprite = newSprite;

			SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

            print("dead");
        }
    }
}
