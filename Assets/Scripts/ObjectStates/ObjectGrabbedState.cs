using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabbedState : ObjectBaseState
{
    ObjectStateManager iOsm;

    public override void EnterState(ObjectStateManager osm)
    {
        this.iOsm = osm;
        this.iOsm.GetComponent<MeshRenderer>().material = osm.onGrabMat;
        this.iOsm.isGrabbed = true;
    }

    public override void UpdateState(ObjectStateManager osm)
    {
        if(this.iOsm.EmitRay())
        {
            this.iOsm.SwitchState(this.iOsm.objectGrabHoverState);
        }
    }
}