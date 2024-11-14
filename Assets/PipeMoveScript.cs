using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;   //speed which pipes are moving

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //code to move the pipes
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;    
    }
}
