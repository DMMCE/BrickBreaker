 
public class StartingBalls : ItemSold
{
    public override bool passLimits()
    {
        if (LocalDataManager.StartingBalls >= maxToBuy)
        {
            return true;
        }
        return false;
    }
    public override void ActiveItemToSold()
    {
        
        LocalDataManager.addStartingBalls(1);
    }
}
