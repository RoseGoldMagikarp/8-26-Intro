using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    //public means it can be changed from the editor
    public float Speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //assigning a variable to the position
        Vector3 tempP = this.gameObject.transform.position;

        //tempP.x = tempP.x + Speed;
        //modifying what that variable is
        tempP.z += Speed * Time.deltaTime;

        //float val = 0;
        //va; = val +Speed;

        //making the position the variable
        this.gameObject.transform.position = tempP;
    }
}
