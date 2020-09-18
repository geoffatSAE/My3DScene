using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsUp : MonoBehaviour
{
    public float tolerance = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsUpsideDown()){
            
            Debug.Log("Is upside down");
        } else {
            Debug.Log("Is Right side up");
        }
    }

    public bool IsUpsideDown()
    {
     return (Vector3.Dot(transform.up, Vector3.up) < -tolerance);
    }
}
