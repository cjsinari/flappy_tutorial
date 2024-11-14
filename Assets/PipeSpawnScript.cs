using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    //create pipe prefab
    public GameObject pipe;
    public float spawnRate = 2; //spawn pipes at interval
    private float timer = 0;
    public float heightOffset = 10;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        //spawn at interval
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            //spawn the pipes at beginning of game
            spawnPipe();
            timer = 0 ;
        }

       
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        //spawn the pipes at particular position
        Instantiate(pipe, transform.position, transform.rotation);
    }

}
