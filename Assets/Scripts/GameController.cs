using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    //public PlayerController playerController;
    public Camera cam;
    public GameObject player;
    
    public GameObject[] platformPrefab;
    public float spawnPoint = 0f;
    GameObject currentPlatform;
    public float safeMargin;
    public Vector3 offset;
    void Start()
    {


       // currentPlatform = Instantiate(platformPrefab[0], transform.position + offset, Quaternion.identity);
        //Instantiate(platformPrefab[k], tempblock.transform.position + new Vector3(7.5f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       while(spawnPoint<player.transform.position.x+safeMargin )
        {
            int k = Random.Range(0, platformPrefab.Length);
            GameObject currentPlatform = Instantiate(platformPrefab[k], transform.position, Quaternion.identity);
            PlatformController platform = currentPlatform.GetComponent<PlatformController>();
            Debug.Log(platform.name);
            Debug.Log(platform.platformSize);
            currentPlatform.transform.position = new Vector3(platform.platformSize / 2 + spawnPoint, 0f, 0f);
            Debug.Log("Platform Size "+platform.platformSize / 2);
            Debug.Log(platform.platformSize / 2 + spawnPoint);
            spawnPoint = 35;
        }
        if (player != null) // Camera following player based on player position
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }
    }
}
