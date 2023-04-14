using System;

using static StarterAssets.CharacterMainController;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class AbilityUsage : Attribute
{
    public AbilityUsage(GameplayTypeFlags gameplayType)
    {
        GameplayType = gameplayType;
    }

    public GameplayTypeFlags GameplayType { get; private set; }
}