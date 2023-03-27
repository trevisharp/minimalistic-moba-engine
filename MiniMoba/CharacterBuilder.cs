/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */

using System;

namespace MiniMoba;

public class CharacterBuilder
{
    protected int resilience = 0;
    protected int stubbornness = 0;
    protected int zeal = 0;
    protected int aggressiveness = 0;
    protected int mobility = 0;
    protected int control = 0;
    protected int prosperity = 0;

    private CharacterBuilder setProperties(
        int resilience,
        int stubbornness,
        int zeal,
        int aggressiveness,
        int mobility,
        int control
    )
    {
        this.resilience = resilience;
        this.stubbornness = stubbornness;
        this.zeal = zeal;
        this.aggressiveness = aggressiveness;
        this.mobility = mobility;
        this.control = control;
        return this;
    }

    private void setProsperityBasedProperty(ref int prop)
    {
        if (prop < 2)
            return;
        prop = prop - prosperity;
    }

    private CharacterBuilder setProsperityBased()
    {
        setProsperityBasedProperty(ref resilience);
        setProsperityBasedProperty(ref stubbornness);
        setProsperityBasedProperty(ref zeal);
        setProsperityBasedProperty(ref aggressiveness);
        setProsperityBasedProperty(ref mobility);
        setProsperityBasedProperty(ref control);
        return this;
    }
    
    /// <summary>
    /// Build the character with properties setted.
    /// </summary>
    /// <returns>A new character.</returns>
    public Character Build()
    {
        setProsperityBased();
        
        Character character = new Character();

        throw new NotImplementedException();

        return character;
    }

    /// <summary>
    /// Define this character with:
    /// <br>3 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public EscalableCharacterBuilder AsTank()
    {
        setProperties(3, 0, 0, 0, 0, 0);
        return new EscalableCharacterBuilder(this);
    }

    /// <summary>
    /// Define this character with:
    /// <br>2 of resilience</br>
    /// <br>1 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsConquer()
    {
        setProperties(2, 1, 0, 0, 0, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>1 of resilience</br>
    /// <br>2 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsFigther()
    {
        setProperties(1, 2, 0, 0, 0, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>3 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public EscalableCharacterBuilder AsBerserker()
    {
        setProperties(0, 3, 0, 0, 0, 0);
        return new EscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>2 of stubbornness</br>
    /// <br>1 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsBarbarian()
    {
        setProperties(0, 2, 1, 0, 0, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>1 of stubbornness</br>
    /// <br>2 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsPaladin()
    {
        setProperties(0, 1, 2, 0, 0, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>3 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public EscalableCharacterBuilder AsRanger()
    {
        setProperties(0, 0, 3, 0, 0, 0);
        return new EscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>2 of zeal</br>
    /// <br>1 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsMercenary()
    {
        setProperties(0, 0, 2, 1, 0, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>1 of zeal</br>
    /// <br>2 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsDuelist()
    {
        setProperties(0, 0, 1, 2, 0, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>3 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public EscalableCharacterBuilder AsAssassin()
    {
        setProperties(0, 0, 0, 3, 0, 0);
        return new EscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>2 of aggressiveness</br>
    /// <br>1 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsNinja()
    {
        setProperties(0, 0, 0, 2, 1, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>1 of aggressiveness</br>
    /// <br>2 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsHunter()
    {
        setProperties(0, 0, 0, 1, 2, 0);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>3 of mobility</br>
    /// <br>0 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public EscalableCharacterBuilder AsExplorer()
    {
        setProperties(0, 0, 0, 0, 3, 0);
        return new EscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>2 of mobility</br>
    /// <br>1 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsMage()
    {
        setProperties(0, 0, 0, 0, 2, 1);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>1 of mobility</br>
    /// <br>2 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsSorcerer()
    {
        setProperties(0, 0, 0, 0, 1, 2);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>0 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>3 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public EscalableCharacterBuilder AsWizard()
    {
        setProperties(0, 0, 0, 0, 0, 3);
        return new EscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>1 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>2 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsWitchie()
    {
        setProperties(1, 0, 0, 0, 0, 2);
        return new NonEscalableCharacterBuilder(this);
    }
    
    /// <summary>
    /// Define this character with:
    /// <br>2 of resilience</br>
    /// <br>0 of stubbornness</br>
    /// <br>0 of zeal</br>
    /// <br>0 of aggressiveness</br>
    /// <br>0 of mobility</br>
    /// <br>1 of control</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    public NonEscalableCharacterBuilder AsGladiator()
    {
        setProperties(2, 0, 0, 0, 0, 1);
        return new NonEscalableCharacterBuilder(this);
    }
}