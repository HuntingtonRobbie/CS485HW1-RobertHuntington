using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
    //initialize
    void start()
    {
        
    }
    
    //Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0f,0.005f);
    }
}
