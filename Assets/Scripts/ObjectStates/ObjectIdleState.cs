using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIdleState : ObjectBaseState
{
    ObjectStateManager iOsm;

    public override void EnterState(ObjectStateManager osm)
    {
        this.iOsm = osm;
        this.iOsm.GetComponent<MeshRenderer>().material = osm.defaultMat;
        this.iOsm.isGrabbed = false;
    }

    public override void UpdateState(ObjectStateManager osm)
    {
        
    }
}