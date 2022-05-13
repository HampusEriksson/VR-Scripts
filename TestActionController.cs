using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class TestActionController : MonoBehaviour
{
    private List<UnityEngine.XR.InputDevice> leftHandDevices;
    // Start is called before the first frame update
    void Start()
    {
        leftHandDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.LeftHand, leftHandDevices);

    }

   

    // Update is called once per frame
    void Update()
    {

        bool triggerValue;
        if (leftHandDevices[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton,
                                      out triggerValue)
            && triggerValue)
        {
            GameScore sn = GameObject.Find("ScoreText").GetComponent<GameScore>();
            sn.updateScore();
        }

    }
}
