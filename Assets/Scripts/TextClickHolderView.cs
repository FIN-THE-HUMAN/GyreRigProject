using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextClickHolderView : AbstractClickHolderView
{
    public TMPro.TMP_Text text;

    public override void UpdateView(ClickHolderModel model)
    {
        text.text = model.GetClicks().ToString();
    }
}
