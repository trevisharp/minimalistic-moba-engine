/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */

namespace MiniMoba;

/// <summary>
/// Create a Possibility to a internal builder.
/// </summary>
public class InnerCharacterBuilder : CharacterBuilder
{
    internal InnerCharacterBuilder(CharacterBuilder inner)
        => this.Inner = inner;

    protected internal CharacterBuilder Inner { get; set; }

    public override Character Build()
        => Inner.Build();
}