using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewManager : MonoBehaviour
{
    [SerializeField]private Text scope;
    [SerializeField]private Slider timer;
    public static ViewManager vm;

    void Update()
    {
        if (!GameManager.gm.IsEnd)
        {
            scope.text = "Scope:" + GameManager.gm.Scope;
            timer.value = GameManager.gm.Timer;
        }
    }

    void Awake()
    {
        if (vm == null)
        {
            vm = this;
        }
    }
}
