using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _scope;
    [SerializeField]private int _timer;
    private bool _isEnd;

    public static GameManager gm;

    public void Start()
    {
        InvokeRepeating("DecreaseTime", 2.0f, 1f);
    }

    void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    void Update()
    {
        if (_timer == 0)
        {
            _isEnd = true;
        }
    }

    private void DecreaseTime()
    {
        if (!_isEnd)
        {
            _timer -= 1;
        }
    }

    public int Scope
    {
        get { return _scope; }
        set { _scope = value; }
    }

    public bool IsEnd
    {
        get { return _isEnd; }
    }

    public int Timer
    {
        get { return _timer; }
    }
}
