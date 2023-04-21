using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
using DG.Tweening;
using TDCore.UI;

[RequireComponent(typeof(CanvasGroup))]
public class MonoWindow : AbstractWindow
{
    private bool isShow => isInitTrue && state == Value.Enable;
    private bool isHide => isInitTrue && state == Value.Disable;

    public OnUpdateState onCompleted;

    private CanvasGroup canvasGroup;

    public override void Instance()
    {
        base.Instance();

        canvasGroup = GetComponent<CanvasGroup>();
    }

    public MonoWindow AddHeader(string name)
    {
        transform.name = $"Window [{name}]";
        return this;
    }

    [Button("Show"), ShowIf("isHide")]
    public override void Show()
    {
        base.Show();

        float value = canvasGroup.alpha;
        DOTween.To(() => value, x => value = x, 1f, 1f)
            .OnUpdate(() =>
            {
                canvasGroup.alpha = value;
            }).OnComplete(() =>
            {
                onCompleted?.Invoke();
            });
    }

    [Button("Hide"), ShowIf("isShow")]
    public override void Hide()
    {
        base.Hide();

        float value = canvasGroup.alpha;
        DOTween.To(() => value, x => value = x, 0f, 1f)
            .OnUpdate(() =>
            {
                canvasGroup.alpha = value;
            }).OnComplete(() =>
            {
                onCompleted?.Invoke();
            });
    }
}