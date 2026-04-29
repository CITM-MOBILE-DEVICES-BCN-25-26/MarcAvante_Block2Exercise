using System;

public interface IReward
{
    void GrantReward();
}

public class CoinsReward : IReward
{
    public void GrantReward()
    {
        Console.WriteLine("Giving coins");
    }
}

public class ItemReward : IReward
{
    public void GrantReward()
    {
        Console.WriteLine("Giving item");
    }
}

public class UnlockReward : IReward
{
    public void GrantReward()
    {
        Console.WriteLine("Unlocking content");
    }
}

public class RewardSystem
{
    public void GiveReward(IReward reward)
    {
        reward.GrantReward();
    }
}