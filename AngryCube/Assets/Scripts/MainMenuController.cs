using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    bool cam_switch = false;
    public void OnPlayBtnClick()
    {
        cam_switch = true;
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
    }

    private void Update()
    {
        if(cam_switch)
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 2.66f, Time.deltaTime*1.5f);

        if (Camera.main.orthographicSize <= 2.66f)
        {
            cam_switch = false;

        }
    }
}
