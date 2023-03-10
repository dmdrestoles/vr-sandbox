using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabHoverState : ObjectBaseState
{
    ObjectStateManager iOsm;
    public override void EnterState(ObjectStateManager osm)
    {
        this.iOsm = osm;
        this.iOsm.GetComponent<MeshRenderer>().material = osm.onRaycastMat;
        this.iOsm.isGrabbed = true;
    }

    public override void UpdateState(ObjectStateManager osm)
    {
        if (!this.iOsm.EmitRay())
        {
            this.iOsm.SwitchState(this.iOsm.objectGrabbedState);
        }
    }
}