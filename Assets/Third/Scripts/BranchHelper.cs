using UnityEngine;

public class BranchHelper : MonoBehaviour
{
    private void Start()
    {
        Branch.initSession(CallbackWithBranchUniversalObject);
    }

    private void CallbackWithBranchUniversalObject(BranchUniversalObject buo, BranchLinkProperties linkProps, string error)
    {
        if (error != null)
        {
            Debug.LogError("Error : " + error);
        }
        else if (linkProps.controlParams.Count > 0)
        {
            Debug.Log("Deeplink params : " + buo.ToJsonString() + linkProps.ToJsonString());
        }
    }
}