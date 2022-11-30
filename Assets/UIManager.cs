using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;

    public void ToggleDeathpanel()
    {
        deathPanel.SetActive(!deathPanel.activeSelf);
    }

}
