using UnityEngine;

public class button : MonoBehaviour
{
    [Header("GameObject")]
    public GameObject panel;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void BlackPanelInt(int anim_ID)
    {
        animator.SetInteger("Black", anim_ID);
        Invoke("FalsePanel", 1f);
    }

    public void BlackPanelTrigger(string anim_name)
    {
        animator.SetTrigger(anim_name);
        Invoke("FalsePanel", 1f);
    }

    void FalsePanel()
    {
        panel.SetActive(false);
    }
}
