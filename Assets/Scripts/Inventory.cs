using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int wood, tool, stone, dirt, brick;

    public int Wood
    {
        get { return Wood; }
        set 
        { 
            wood = value;
            PlayerPrefs.SetInt("Wood", wood);
        }
    }
    public int Tool
    {
        get { return tool; }
        set
        {
            tool = value;
            PlayerPrefs.SetInt("Tool", tool);
        }
    }
    public int Stone
    {
        get { return stone; }
        set
        {
            stone = value;
            PlayerPrefs.SetInt("Stone", stone);
        }
    }
    public int Brick
    {
        get { return brick; }
        set
        {
            brick = value;
            PlayerPrefs.SetInt("Brick", brick);
        }
    }
    public int Dirt
    {
        get { return dirt; }
        set
        {
            dirt = value;
            PlayerPrefs.SetInt("Dirt", dirt);
        }
    }
}
