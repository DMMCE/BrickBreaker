using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalDataManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public static int HighScore { get => getHighScore(); }
    public static void saveUserScoreInLocal(int currentscore)
    {
        int highscore = PlayerPrefs.GetInt("HighScore");
        if (highscore < currentscore)
        {
            PlayerPrefs.SetInt("HighScore" , currentscore);
        }
    }
    static   int getHighScore() { return PlayerPrefs.GetInt("HighScore"); }

    public static int startingGuns { get => getStartingGuns(); }
    public static void addStartingGuns(int addValue)
    {
        if (addValue > 1) return;
        PlayerPrefs.SetInt("StartingGuns" , startingGuns + addValue);
    }
    static int getStartingGuns() { return PlayerPrefs.GetInt("StartingGuns")+1; }


    public static int StartingBullets { get => getStartingBullets(); }
    public static void addStartingBullets(int addValue)
    {
        if (addValue > 1) return;
        PlayerPrefs.SetInt("StartingBullets" , StartingBullets + addValue);
    }
    static int getStartingBullets() { return PlayerPrefs.GetInt("StartingBullets") + 10; }


    public static int StartingBalls { get => getStartingBalls(); }
    public static void addStartingBalls(int addValue)
    {
        if (addValue > 1) return;
        PlayerPrefs.SetInt("StartingBalls" , StartingBalls + addValue);
    }
    static int getStartingBalls() { return PlayerPrefs.GetInt("StartingBalls") + 3; }


}
