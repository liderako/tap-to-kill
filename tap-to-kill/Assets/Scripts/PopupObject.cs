using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupObject : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField]private int scope = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyPopup());
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void hit()
    {
        if (GameManager.gm.IsEnd || GameManager.gm.IsPause)
        {
            return;
        }
        GameManager.gm.Scope += scope;
        Destroy(gameObject);
    }

    private IEnumerator destroyPopup()
    {
        float delta = 1f;
        for (int i = 0; i < 100; i++)
        {
            while(GameManager.gm.IsPause)
            {
                yield return null;
            }
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, delta);
            yield return new WaitForSeconds(0.01f);
            delta -= 0.01f;
        }
        Destroy(gameObject);
    }

    public void negativeActivate()
    {
        spriteRenderer.color = Color.red;
        scope = -1;
    }
}
