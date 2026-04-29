public interface ISkill
{
    int Apply(int baseDamage);
}

public class FireSkill : ISkill
{
    public int Apply(int baseDamage)
    {
        return baseDamage + 10;
    }
}

public class IceSkill : ISkill
{
    public int Apply(int baseDamage)
    {
        return baseDamage + 5;
    }
}

public class PoisonSkill : ISkill
{
    public int Apply(int baseDamage)
    {
        return baseDamage + 2;
    }
}

public class SkillSystem
{
    public int ApplySkill(ISkill skill, int baseDamage)
    {
        return skill.Apply(baseDamage);
    }
}