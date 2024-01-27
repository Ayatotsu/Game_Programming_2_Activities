using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwitch : MonoBehaviour
{
    
    public TestEnum testEnum;
    // Start is called before the first frame update


    void Start()
    {
        switch (testEnum)
        {
            case TestEnum.Monday: Debug.Log("may pasok sa Monday"); break;
            case TestEnum.Tuesday: Debug.Log("may pasok sa Tuesday"); break;
            case TestEnum.Wednesday: Debug.Log("may pasok sa Wednesday"); break;
            case TestEnum.Thursday: Debug.Log("may pasok sa Thursday"); break;
            case TestEnum.Friday: Debug.Log("walang pasok sa Friday"); break;
            case TestEnum.Saturday: Debug.Log("may pasok sa Saturday"); break;
            default:
                Debug.Log("Happy Gaming sa Sunday!!!");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
