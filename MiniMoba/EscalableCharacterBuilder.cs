/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */

namespace MiniMoba;

public class EscalableCharacterBuilder : InnerCharacterBuilder
{
    internal EscalableCharacterBuilder(CharacterBuilder inner) : base(inner) { }

    /// <summary>
    /// Define this character with 1 of prosperity.
    /// </summary>
    /// <returns>Return this builder</returns>
    protected EscalableCharacterBuilder AsEarlyGame()
    {
        this.prosperity = 1;
        return this;
    }

    /// <summary>
    /// Define this character with 1 of prosperity.
    /// </summary>
    /// <returns>Return this builder</returns>
    protected EscalableCharacterBuilder AsMidGame()
    {
        this.prosperity = 1;
        return this;
    }

    /// <summary>
    /// Define this character with 2 of prosperity.
    /// <br>Only be used with Tank, Berserker, Ranger, Assassin, Explorer and Wizard.</br>
    /// </summary>
    /// <returns>Return this builder</returns>
    protected EscalableCharacterBuilder AsEndGame()
    {
        this.prosperity = 2;
        return this;
    }
}