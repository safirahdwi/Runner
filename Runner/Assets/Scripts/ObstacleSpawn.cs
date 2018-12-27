using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {

    public GameObject obstacle;
	//inisalisasi
    private void Start() {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
