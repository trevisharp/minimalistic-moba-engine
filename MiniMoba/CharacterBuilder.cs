/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */
using System;

namespace MiniMoba;

public abstract class CharacterBuilder
{
    private int resilience = 0;
    private int stubbornness = 0;
    private int zeal = 0;
    private int aggressiveness = 0;
    private int mobility = 0;
    private int control = 0;
    private int prosperity = 0;

    private CharacterBuilder setProperties(
        int resilience,
        int stubbornness,
        int zeal,
        int aggressiveness,
        int mobility,
        int control,
        int prosperity
    )
    {
        this.resilience = resilience;
        this.stubbornness = stubbornness;
        this.zeal = zeal;
        this.aggressiveness = aggressiveness;
        this.mobility = mobility;
        this.control = control;
        this.prosperity = prosperity;
        return this;
    }

    public Character Build()
    {
        setCharacter();
        return build();
    }

    protected abstract void setCharacter();

    protected Character build()
    {
        throw new NotImplementedException();
    }

    protected CharacterBuilder AsTank()
        => setProperties(3, 0, 0, 0, 0, 0, 0);
    
    protected CharacterBuilder AsConquer()
        => setProperties(2, 1, 0, 0, 0, 0, 0);
    
    protected CharacterBuilder AsFigther()
        => setProperties(1, 2, 0, 0, 0, 0, 0);
    
    protected CharacterBuilder AsBerserker()
        => setProperties(0, 3, 0, 0, 0, 0, 0);
    
    protected CharacterBuilder AsBarbarian()
        => setProperties(0, 2, 1, 0, 0, 0, 0);
    
    protected CharacterBuilder AsPaladin()
        => setProperties(0, 1, 2, 0, 0, 0, 0);
    
    protected CharacterBuilder AsRanger()
        => setProperties(0, 0, 3, 0, 0, 0, 0);
    
    protected CharacterBuilder AsMercenary()
        => setProperties(0, 0, 2, 1, 0, 0, 0);
    
    protected CharacterBuilder AsDuelist()
        => setProperties(0, 0, 1, 2, 0, 0, 0);
    
    protected CharacterBuilder AsAssassin()
        => setProperties(0, 0, 0, 3, 0, 0, 0);
    
    protected CharacterBuilder AsNinja()
        => setProperties(0, 0, 0, 2, 1, 0, 0);
    
    protected CharacterBuilder AsHunter()
        => setProperties(0, 0, 0, 1, 2, 0, 0);
    
    protected CharacterBuilder AsExplorer()
        => setProperties(0, 0, 0, 0, 3, 0, 0);
    
    protected CharacterBuilder AsMage()
        => setProperties(0, 0, 0, 0, 2, 1, 0);
    
    protected CharacterBuilder AsSorcerer()
        => setProperties(0, 0, 0, 0, 1, 2, 0);
    
    protected CharacterBuilder AsWizard()
        => setProperties(0, 0, 0, 0, 0, 3, 0);
    
    protected CharacterBuilder AsWitchie()
        => setProperties(1, 0, 0, 0, 0, 2, 0);
    
    protected CharacterBuilder AsGladiator()
        => setProperties(2, 0, 0, 0, 0, 1, 0);
}