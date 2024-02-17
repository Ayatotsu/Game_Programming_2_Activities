using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons2 : MonoBehaviour
{
    public GameObject activeUI;
    public GameObject inactiveUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowUi() 
    {
        activeUI.SetActive(true);
        inactiveUI.SetActive(false);
    }
}
