using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessingControlls : MonoBehaviour
{
    [SerializeField] PostProcessLayer postProcessLayer;
    public Toggle enableDisablePPS;
    public Toggle freezeCamera;
    [SerializeField] CameraMove cameraMove;
    [SerializeField] GameObject ppsEnabledTxt;
    [SerializeField] GameObject ppsDisabledTxt;


    // Start is called before the first frame update
    void Start()
    {
        ppsEnabledTxt.SetActive(true);
        ppsDisabledTxt.SetActive(false);

        postProcessLayer = gameObject.GetComponent<PostProcessLayer>();
        cameraMove = gameObject.GetComponent<CameraMove>();

        enableDisablePPS.onValueChanged.AddListener(delegate
        {
            TogglePPSValueChanged(enableDisablePPS);
        });

        freezeCamera.onValueChanged.AddListener(delegate 
        {
            ToggleCameraFreezeValueChange(freezeCamera);
        });

    }

    void TogglePPSValueChanged(Toggle change)
    {
        if (enableDisablePPS.isOn)
        {
            postProcessLayer.enabled = true;
            ppsEnabledTxt.SetActive(true);
            ppsDisabledTxt.SetActive(false);

        }
        else
        {
            postProcessLayer.enabled = false;
            ppsEnabledTxt.SetActive(false);
            ppsDisabledTxt.SetActive(true);
        }
    }

    void ToggleCameraFreezeValueChange(Toggle change)
    {
        if (freezeCamera.isOn)
        {
            cameraMove.enabled = false;
        }

        else
        {
            cameraMove.enabled = true;
        }
    }
}
