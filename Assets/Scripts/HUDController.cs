using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI PlayerRightPoints;
    [SerializeField] private TMPro.TextMeshProUGUI PlayerLeftPoints;

    public void UpdateRightPoints(int RightPoints)
    {
        PlayerRightPoints.text = "" + RightPoints;
    }

    public void UpdateLeftPoints(int LeftPoints)
    {
        PlayerLeftPoints.text = "" + LeftPoints;
    }    

}
