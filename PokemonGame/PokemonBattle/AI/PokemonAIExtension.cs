namespace PokemonGame.PokemonBattle.AI;

public static class PokemonAiExtension
{
    /*
    public static bool CanSetupRocks(this Pokemon pokemon) =>
        pokemon.Moves.Any(m => m.NameIsAnyOf("Stealth Rocks"));

    public static bool CanSetupSpikes(this Pokemon pokemon) => pokemon.Moves.Any(m => m.NameIsAnyOf("Spikes"));

    public static bool CanSetupToxicSpikes(this Pokemon pokemon) =>
        pokemon.Moves.Any(m => m.NameIsAnyOf("Toxic Spikes"));

    public static bool CanSetupStickyWeb(this Pokemon pokemon) =>
        pokemon.Moves.Any(m => m.NameIsAnyOf("Sticky Web"));

    private static double GetDamagePercentageFromHazardWithType(Hazard hazard, PokemonType t) => hazard switch
    {
        // this does not account for levitating pokemon (TODO)
        Hazard.SpiderWeb => 0,
        Hazard.Spikes => t switch
        {
            PokemonType.Flying => 0,
            _ => 12.5
        },
        Hazard.StealthRock => 12.5 * BattleCalculationExtension.CalculateEffectivityMod(PokemonType.Rock, t),
        Hazard.ToxicSpikes => t switch
        {
            PokemonType.Poison => 0,
            PokemonType.Flying => 0,
            _ => 12.5 // not very accurate but its okay (TODO)
        },
        _ => throw new NotImplementedException()
    };

    public static double GetDamagePercentageFromHazard(this Pokemon pokemon, Hazard hazard) =>
        pokemon.Types.Aggregate(
            pokemon.Types.Count switch
            {
                1 => 1.0,
                2 => 0.01,
                _ => throw new NotImplementedException()
            },
            (_, type) => GetDamagePercentageFromHazardWithType(hazard, type));
    */
}