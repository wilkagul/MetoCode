[System.Serializable]
public class LevelData
{
    public int LevelNumber;
    public string LineOne;
    public string LineTwo;
    public string LineThree;
    public string LineFour;
    public string Result;
    public ResultData[] PrepareResult;
}

[System.Serializable]
public class ResultData
{
    public string Result;
    public string WrongOne;
    public string WrongTwo;
}
