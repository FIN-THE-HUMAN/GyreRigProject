using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClickHolderModel
{
    int clicks;

    public void IncrementClicks()
    {
        clicks++;
    }

    public int GetClicks()
    {
        return clicks;
    }

    public void SetClicks(int _clicks)
    {
        clicks = _clicks;
    }
}
