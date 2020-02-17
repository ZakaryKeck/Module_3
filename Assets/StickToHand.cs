using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class StickToHand : MonoBehaviour
{
    public SteamVR_Input_Sources LeftInputSource = SteamVR_Input_Sources.LeftHand;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(LeftInputSource);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.parent = LeftInputSource.transform;
    }
}
