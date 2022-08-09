﻿/* Sourced from Neal McKee's Penumbra color theme:
 * https://github.com/nealmckee/penumbra/blob/main/penumbra.tsv
 * https://github.com/nealmckee/penumbra#accent-colour-palettes-2
 */

namespace ScottPlot.Palettes;

public class Penumbra : HexPaletteBase, IPalette
{
    public override string Name => this.GetType().Name;

    public override string Description => string.Empty;

    internal override string[] HexColors => new string[]
    {
        "#CB7459", "#A38F2D", "#46A473", "#00A0BE", "#7E87D6", "#BD72A8"
    };
}
