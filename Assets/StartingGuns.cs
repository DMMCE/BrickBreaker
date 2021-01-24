 
public class StartingGuns : ItemSold
{
    public override bool passLimits()
    {
        if(LocalDataManager.startingGuns  >= maxToBuy)
        {
            return true;
        }
        return false;
    }
    public override void ActiveItemToSold()
    {
        LocalDataManager.addStartingGuns(1);
    }
}
