 
using System; 
using UnityEngine;
using TMPro;
public class BlocksBrokenCountManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI getText;
    public static int numberofBlocks;

    public event Action<int> blockDestroyed = delegate { };

    static BlocksBrokenCountManager _Instance;
    public static BlocksBrokenCountManager Instance
    {
        get
        {
            _Instance = FindObjectOfType<BlocksBrokenCountManager>();
           
         
            return _Instance;

        }
    }
    

    public void onDestroyBlock(int valuetoadd)
    {
        if (blockDestroyed != null)
        {
            numberofBlocks += valuetoadd;
 
            getText.text = numberofBlocks.ToString();
            blockDestroyed(valuetoadd);

        }

    }
    public static void saveUserScoreInLocal()
    {
        int highscore = PlayerPrefs.GetInt("HighScore");
        if(highscore < numberofBlocks)
        {
            PlayerPrefs.SetInt("HighScore",numberofBlocks);
        }
    }
    public static int getHighScore() { return PlayerPrefs.GetInt("HighScore"); }

}
