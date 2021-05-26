using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public ClickController clickController;

    void Start()
    {
        clickController.model = new ClickHolderModel();
        clickController.model.SetClicks(0);
        clickController.view.UpdateView(clickController.model);
    }

    public void UpdateClickController()
    {
        clickController.Update();
    }
}
