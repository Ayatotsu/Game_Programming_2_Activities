using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{

    public string name;
    public int attack;

    //base class that will override subclasses
    public virtual void Attack() 
    {
        Debug.Log("Adventurer!!!");
    }


    
    
    ///public abstract void Attack();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
