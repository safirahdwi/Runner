using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private Vector2 targetPos;
    public float Yincrement;

    public float speed; //kecepatan
    public float maxHeight;
    public float minHeight;
    
    public int health = 3;
    
    //public GameObject effect;
    
    //memberi batasan ketinggian movement
    private void Update()
    {
		
		if(health <= 0){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); 
        //movetowards membuat pergerakan smooth dengan kecepatan tertentu
        //deltatime digunakana untuk memastikan kecepatan pergerakannya sama untuk setiap komputer
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
			//Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement); //pindah keatas

        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
			//Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement); //pindahkebawah

        }
    }
}
