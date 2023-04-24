using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] GameObject OptionPanel;
    public void ActivateOptionPanel()
    {
        OptionPanel.SetActive(true);
    }
    public void DeactivateOptionPanel()
    {
        OptionPanel.SetActive(false);
    }

}//Class
