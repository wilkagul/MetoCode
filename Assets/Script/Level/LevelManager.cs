using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; }
    public List<LevelDataScriptableObject> levelList = new List<LevelDataScriptableObject>();
    private int LevelIndex { get; set; }

    private void Awake()
    {
        Instance = this;
        LevelIndex = 0;
    }

    #region Level Process
    public void SetLevelIndex()
    {
        if (LevelIndex == (levelList.Count - 1))
        {
            LevelIndex = 0;
            return;
        }
        LevelIndex++;
    }

    public int GetLevelIndex()
    {
        return LevelIndex;
    }
    #endregion

    public LevelData GetLevel()
    {
        return levelList[LevelIndex].levelData;
    }

    public string[] GetQuestion()
    {
        string[] arr = new string[4];
        arr[0] = levelList[LevelIndex].levelData.LineOne;
        arr[1] = levelList[LevelIndex].levelData.LineTwo;
        arr[2] = levelList[LevelIndex].levelData.LineThree;
        arr[3] = levelList[LevelIndex].levelData.LineFour;
        return arr;
    }

    public string[] GetOption()
    {
        string[] arr = new string[3];
        arr[0] = levelList[LevelIndex].levelData.PrepareResult[0].Result;
        arr[1] = levelList[LevelIndex].levelData.PrepareResult[0].WrongOne;
        arr[2] = levelList[LevelIndex].levelData.PrepareResult[0].WrongTwo;
        return arr;
    }

    public string GetResult()
    {
        string res = levelList[LevelIndex].levelData.Result;
        return res;
    }
}
