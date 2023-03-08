using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Algorithm;

public class ScriptTester : MonoBehaviour
{
    // Start is called before the first frame update
    public Container container = new Container();
    bool value1;
    bool value2;

    void Start()
    {
        bool ptr = container.Value;
        // Debug.Log(container.TestGetN());
        // unsafe
        // {
        //     Debug.Log((int)&(container.TestGetValue()));
        // }
    }

    unsafe void GetAddress(bool value)
    {
        Debug.Log((int)&value);
    }

    // Update is called once per frame
    void Update() { }
}
