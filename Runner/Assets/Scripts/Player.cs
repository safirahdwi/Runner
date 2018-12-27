using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private Vector2 targetPos;
	public float increment;
   
    public float speed;
    public float maxY;
    public float minY;

    public int health = 3;

    public GameObject moveEffect;
    public Animator camAnim;
    public Text healthDisplay;

    public GameObject spawner;
    public GameObject restartDisplay;
    
    //public GameObject explosionSound;

    private void Update()
    {
		healthDisplay.text = health.ToString();
		
        if (health <= 0) {
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
        }
		
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
		//movetowards membuat pergerakan smooth dengan kecepatan tertentu
        //deltatime digunakan untuk memastikan kecepatan pergerakannya sama untuk setiap komputer
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}
