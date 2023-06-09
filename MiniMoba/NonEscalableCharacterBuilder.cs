/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */

namespace MiniMoba;

public class NonEscalableCharacterBuilder : InnerCharacterBuilder
{
    internal NonEscalableCharacterBuilder(CharacterBuilder inner) : base(inner) { }

    /// <summary>
    /// Define this character with 1 of prosperity.
    /// </summary>
    /// <returns>Return this builder</returns>
    protected NonEscalableCharacterBuilder AsEarlyGame()
    {
        Data.Prosperity = 1;
        return this;
    }

    /// <summary>
    /// Define this character with 1 of prosperity.
    /// </summary>
    /// <returns>Return this builder</returns>
    protected NonEscalableCharacterBuilder AsMidGame()
    {
        Data.Prosperity = 2;
        return this;
    }
}