using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClickController 
{
    public AbstractClickHolderView view;
    public ClickHolderModel model;

    public ClickController(ClickHolderModel _model, AbstractClickHolderView _view)
    {
        model = _model;
        view = _view;
    }

    public void Update()
    {
        model.IncrementClicks();
        view.UpdateView(model);
    }
}
