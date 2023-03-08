using UnityEngine;
using Unity.Burst;
using Unity.Collections;
using UnityEngine.Jobs;
using System.Collections.Generic;

[BurstCompile]
public struct PhantasmsJob : IJobParallelForTransform
{
    public NativeArray<int> _userBehaviorData;
    public NativeArray<int> _phantasmsAction;
    public Vector3 _phantasmsLocation;
    public void Execute(int index, TransformAccess transform)
    {
        ParseUserBehaviorFromString(index, transform);
    }
    void ParseUserBehaviorFromString(int index, TransformAccess transform)
    {
        //after complex parse....
        //Got users position
        Vector3 position = new Vector3(0, 0, 0); //can be ....
        //Got users actions
        int actions = 25; // can be....
        //set this user's position(we can do parallel in Job system)
        transform.position = position;
        //save the action code
        _phantasmsAction[index] = actions;
    }
}
