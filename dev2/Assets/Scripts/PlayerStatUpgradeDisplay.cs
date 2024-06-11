using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerStatUpgradeDisplay : MonoBehaviour
{
    //�����츳����ť���������50�����߶��ټ��츳��չʾshowmaxlevel
    //ͨ�������ť������uicontroller�Ĺ������Ժ���
    //�����Ҿ�������ű���������о�������ν��ֻҪpublic�����ҵĵط���ȷ�Ϳ�����
    public TMP_Text valueText,costText;
    public GameObject upgradeButton;

    public void UpdateDisplay(int cost, float oldValue,float newValue)
    {
        valueText.text = "Value " + oldValue.ToString("F1") + "->" + newValue.ToString("F1");
        costText.text = "Cost: " + cost;

        if(cost <= CoinController.instance.currentCoins)
        {
            upgradeButton.SetActive(true);
        }else
        {
            upgradeButton.SetActive(false);
        }
    }

    public void ShowMaxLevel()
    {
        valueText.text = "Max Level";
        costText.text = "Max Level";
        upgradeButton.SetActive(false);
    }


}