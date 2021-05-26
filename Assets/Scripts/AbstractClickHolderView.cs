using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractClickHolderView : MonoBehaviour
{
    public abstract void UpdateView(ClickHolderModel model);
}
