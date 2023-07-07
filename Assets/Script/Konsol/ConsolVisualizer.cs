using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ConsolVisualizer : MonoBehaviour
{
    public static ConsolVisualizer Instance { get; private set; }

    [SerializeField] private TextMeshPro Line_1;
    [SerializeField] private TextMeshPro Line_2;
    [SerializeField] private TextMeshPro Line_3;
    [SerializeField] private TextMeshPro Line_4;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetQuestion();
    }

    public void SetQuestion()
    {
        string[] arr = LevelManager.Instance.GetQuestion();
        Line_1.text = arr[0];
        Line_2.text = arr[1];
        Line_3.text = arr[2];
        Line_4.text = arr[3];
    }
}
