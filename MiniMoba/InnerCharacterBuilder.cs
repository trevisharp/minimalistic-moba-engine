/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */

namespace MiniMoba;

public class InnerCharacterBuilder : CharacterBuilder
{
    internal InnerCharacterBuilder(CharacterBuilder inner)
        => this.Inner = inner;

    protected internal CharacterBuilder Inner { get; set; }
}