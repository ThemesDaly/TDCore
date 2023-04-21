using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class UI : MonoBehaviour
{
    [BoxGroup(), SerializeField] private Canvas canvas;
    [BoxGroup(), SerializeField] private Window[] windows;

    private List<IWindow> instancesWindows;

    private Transform mainCanvas;

    private void Start()
    {
        Instance();
    }

    private void Instance()
    {
        mainCanvas = Instantiate(canvas, transform).transform;
        mainCanvas.name = $"Canvas [Main]";

        instancesWindows = new List<IWindow>();

        foreach (Window window in windows)
            Create(window);
    }

    private void Create(Window window)
    {
        var instanceWindow = Instantiate(window).AddHeader(window.name);

        switch (instanceWindow.space)
        {
            case TDC.UI.Space.MainCanvas:
                instanceWindow.transform.SetParent(mainCanvas);
                break;

            case TDC.UI.Space.NewCanvas:
                Transform newCanvas = Instantiate(canvas, transform).transform;
                newCanvas.name = $"Canvas [{window.name}]";
                instanceWindow.transform.SetParent(newCanvas);
                break;
        }

        if (instanceWindow is IWindow iWindow)
        {
            iWindow.Instance();
            instancesWindows.Add(iWindow);
        }
    }
}