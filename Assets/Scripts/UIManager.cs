using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Logo (Sprite GameObject)")]
    public Transform logoTransform;
    public Vector3 logoDropOffset = new Vector3(0, 8f, 0);
    public float dropDuration = 1.2f;

    [Header("UI Buttons")]
    public RectTransform newGameButton;
    public RectTransform continueButton;
    public RectTransform guideButton;

    [Header("Help Popup")]
    public Canvas canvasHelp;
    public RectTransform helpPanel;

    public float delayBetweenButtons = 0.3f;

    void Start()
    {
        AnimateLogo();
    }

    void AnimateLogo()
    {
        Vector3 targetPos = logoTransform.position;

        logoTransform.position = targetPos + logoDropOffset;

        logoTransform.DOMove(targetPos, dropDuration)
            .SetEase(Ease.OutBounce)
            .OnComplete(() => ShowUIButtons());
    }

    void ShowUIButtons()
    {
        newGameButton.localScale = Vector3.zero;
        continueButton.localScale = Vector3.zero;
        guideButton.localScale = Vector3.zero;

        newGameButton.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
        continueButton.DOScale(Vector3.one, 0.5f)
            .SetDelay(delayBetweenButtons).SetEase(Ease.OutBack);
        guideButton.DOScale(Vector3.one, 0.5f)
            .SetDelay(delayBetweenButtons * 2).SetEase(Ease.OutBack);
    }

    public void ShowHelpPopup()
    {
        canvasHelp.gameObject.SetActive(true);

        helpPanel.localScale = Vector3.zero;

        helpPanel.DOScale(Vector3.one, 0.6f)
            .SetEase(Ease.OutBack)
            .SetDelay(0.05f);
    }

}
