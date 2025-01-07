using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Rendering;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 14;
    //created a variable of type integer
    //my int is a global variable



    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }
   
    // Update iscalled once per frame
    void Update()
    {

    }
    
    int MultiplyByTwo(int number)
    {
    int results;
    results = number* 2;
        return results;
    }
}
