 
public class StartingBullets : ItemSold
{
    public override bool passLimits()
    {
        if (LocalDataManager.StartingBullets >= maxToBuy)
        {
            return true;
        }
        return false;
    }
    public override void ActiveItemToSold()
    {
        LocalDataManager.addStartingBullets(1);
    }
}
