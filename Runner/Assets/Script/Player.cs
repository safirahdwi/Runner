using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector2 targetPos;
    public float Yincrement;

    public float speed; //kecepatan
    public float maxHeight;
    public float minHeight;
    
    //public int health = 3;
    
    //memberi batasan ketinggian movement
    private void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); 
        //movetowards membuat pergerakan smooth dengan kecepatan tertentu
        //deltatime digunakana untuk memastikan kecepatan pergerakannya sama untuk setiap komputer
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement); //pindah keatas

        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement); //pindahkebawah

        }
    }
}
