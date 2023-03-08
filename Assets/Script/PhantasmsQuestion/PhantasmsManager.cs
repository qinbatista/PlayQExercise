using UnityEngine;
using Unity.Collections;
using UnityEngine.Jobs;
using Unity.Jobs;
using System;

public class PhantasmsManager : MonoBehaviour
{
    public static NativeArray<int> _userBehaviorData;
    public static NativeArray<int> _phantasmsAction;
    public Vector3 _phantasmsLocation;
    public static Action EventJobComplete;
    JobHandle _jobHandle;
    PhantasmsJob _phantasmsJob;
    TransformAccessArray _transformAccessArray = new TransformAccessArray(100);
    public void Update(int index, TransformAccess transform)
    {
        _phantasmsJob = new PhantasmsJob
        {
            _userBehaviorData = _userBehaviorData,
            _phantasmsAction = _phantasmsAction,
        };
        _jobHandle = _phantasmsJob.Schedule(_transformAccessArray);
        _jobHandle.Complete();
        EventJobComplete?.Invoke();
    }
}
