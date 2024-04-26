using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public string questName;
    public string description;
    public bool isCompleted;
    public bool isActive;
    public int rewardGold;
    public int rewardXP;

   

    // G�revin tamamland���n� i�aretle
    public void Complete()
    {
        isCompleted = true;
        isActive = false;
    }
}
