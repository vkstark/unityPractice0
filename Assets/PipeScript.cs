using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed ) * Time.deltaTime;
        if (transform.position.x < deadZone)
    {
        Debug.Log("pipe Deleted");
        Destroy(gameObject);
    }
    }
    
}
