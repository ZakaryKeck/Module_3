using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rightHandGameObject;
    public GameObject projectile;
    public float speed = 30f;

    public SteamVR_Action_Boolean grabPinch; //Grab Pinch is the trigger, select from inspecter
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;//which controller


    public SteamVR_Input_Sources LeftInputSource = SteamVR_Input_Sources.LeftHand;
    public SteamVR_Input_Sources RightInputSource = SteamVR_Input_Sources.RightHand;

    public Material[] obstacleColors;

    public GameObject colorHolder;

    private bool wasPressed = false;
    public Material[] gunColors;

    private void Update()
    {
        if (SteamVR_Actions._default.Squeeze.GetAxis(RightInputSource).ToString() == "0")
        {
            wasPressed = false;
        }

        if (SteamVR_Actions._default.Squeeze.GetAxis(RightInputSource).ToString() == "1" && !wasPressed)
        {
            Fire_Projectile();
            wasPressed = true;
        }
        int gunColorIndex = 0;
        var color = colorHolder.GetComponent<ColorChanger>().GetColor();

        switch (color){
            case "Red":
                gunColorIndex = 0;
                break;
            case "Blue":
                gunColorIndex = 1;
                break;
            case "Green":
                gunColorIndex = 2;
                break;

        }
        GetComponent<Renderer>().material = gunColors[gunColorIndex];
    }


    void Fire_Projectile()
    {
        var colorIndex = 0;
        var color = colorHolder.GetComponent<ColorChanger>().GetColor();
        if(color == "Red")
        {
            colorIndex = 0;
        } else if(color == "Blue")
        {
            colorIndex = 1;
        } else if(color == "Green")
        {
            colorIndex = 2;
        }

        GameObject instantiatedProjectile = Instantiate<GameObject>(projectile,
                                                           transform.position + new Vector3(0,.1f,.1f),
                                                           transform.rotation);

        instantiatedProjectile.GetComponent<Renderer>().material = obstacleColors[colorIndex];
        Destroy(instantiatedProjectile, 5);

    }

}
