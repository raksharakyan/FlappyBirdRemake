using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

    public GameObject[] pipes;
    private float spawnX;
    private float spawnY;
    public float  deletePipe = 2f;
    private float distance = 5f;
    public Transform playerTransform;
    private List<GameObject> amtOfPipes;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        spawnX = transform.position.x;
        spawnY = transform.position.y;
        amtOfPipes = new List<GameObject>(10);
        for (int i = 0; i < 10; i++)
        {
            SpawnPipe();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isDead)
            return;
       
        if (amtOfPipes[0].transform.position.x * deletePipe < playerTransform.position.x)
        {
            SpawnPipe();
            Destroy(amtOfPipes[0]);
            amtOfPipes.RemoveAt(0);
        }
        
    }

    public void SpawnPipe()
    {
        GameObject go;
        go = Instantiate(pipes[Random.Range(0, 2)]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(spawnX, spawnY, 0);
        spawnX += distance;
        amtOfPipes.Add(go);
        
       
    }
  
    
}
