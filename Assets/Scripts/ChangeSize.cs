using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeBig()
    {

        transform.localScale = new Vector3(transform.localScale.x + 1, transform.localScale.y + 1, transform.localScale.z + 1);


    }

    public void MakeSmall()
    {
        transform.localScale = new Vector3(transform.localScale.x - 1, transform.localScale.y - 1, transform.localScale.z - 1);


    }
}
