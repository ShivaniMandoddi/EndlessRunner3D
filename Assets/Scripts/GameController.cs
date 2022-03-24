using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    //public PlayerController playerController;
    public Camera cam;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }
    }
}
