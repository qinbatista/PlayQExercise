using UnityEngine;
using Unity.Collections;
using UnityEngine.Jobs;
using Unity.Jobs;

public class PhantasmController : MonoBehaviour
{
    //....
    int Index;
    void OnEnable()=>PhantasmsManager.EventJobComplete += DoSomeActions;

    void OnDisable()=>PhantasmsManager.EventJobComplete -= DoSomeActions;
    void DoSomeActions()
    {
        //....
        //PhantasmsManager._phantasmsAction[index];
        //PhantasmsManager.__phantasmsAction[index];
    }
}
