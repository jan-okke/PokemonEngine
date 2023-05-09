using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.AI;

public static class BattleAi
{
    /*
    public static Move AiChooseMove(this Battle battle)
    {
        var pokemon = battle.EnemyParty.GetFirstAlivePokemon();
        // this is just max dmg base power move for now.
        return pokemon.GetHighestBPMoves()[0];
    }

    public static Move GetBestAiMove(this Battle battle)
    {
        var pokemon = battle.EnemyParty.GetFirstAlivePokemon();
        var opponent = battle.PlayerParty.GetFirstAlivePokemon();

        var enemySide = battle.PlayerSide;

        // Check OHKOs
        foreach (var m in pokemon.Moves.Where(m => CanOhko(battle, m)))
        {
            return m;
        }

        // check if enemy can ohko
        foreach (var aiM in from m in opponent.Moves where CanOppOhko(battle, m) from aiM in pokemon.Moves where aiM.Priority > m.Priority select aiM)
        {
            return aiM;
        }

        // check if should set up entry hazards
        if (pokemon.CanSetupToxicSpikes() && enemySide.GetHazardCount(Hazard.ToxicSpikes) < 2)
        {
            if (ShouldUseHazards(battle, Hazard.ToxicSpikes))
            {
                return pokemon.FindMove("Toxic Spikes");
            }
        }

        if (pokemon.CanSetupRocks() & !enemySide.HasHazard(Hazard.StealthRock))
        {
            if (ShouldUseHazards(battle, Hazard.StealthRock))
            {
                return pokemon.FindMove("Stealth Rocks");
            }
        }

        if (pokemon.CanSetupSpikes() && enemySide.GetHazardCount(Hazard.Spikes) < 3)
        {
            if (ShouldUseHazards(battle, Hazard.Spikes))
            {
                return pokemon.FindMove("Spikes");
            }
        }

        // if cant ohko check if should lower speed
        if (opponent.IsFaster(pokemon))
        {
            foreach (var m in pokemon.Moves.Where(m => m.DoesLowerSpeed() && m.AffectsPokemon(pokemon, opponent)))
            {
                return m;
            }
        }

        // check if can 2hko
        foreach (var m in pokemon.Moves.Where(m => Can2Hko(battle, m)))
        {
            return m;
        }

        // if has status condition move, use it
        foreach (var m in pokemon.Moves.Where(m => m.AffectsPokemon(pokemon, opponent) & !opponent.HasAbility("Guts")))
        {
            // check if status condition is useful
        }

        // 
        foreach (var m in pokemon.Moves.Where(m => m.AffectsPokemon(pokemon, opponent)))
        {
            return m;
        }

        return pokemon.Moves[0];
    }

    private static bool CanOhko(Battle battle, Move move)
    {
        var opponent = battle.PlayerParty.GetFirstAlivePokemon();
        return CalculateDamage(battle, move) > opponent.CurrentHP;
    }

    private static bool CanOppOhko(Battle battle, Move move)
    {
        var user = battle.ActiveOpponentBattler;
        var target = battle.ActivePlayerBattler;
        return battle.CalculateDamage(target, user, true, move).Value > user.CurrentHP;
    }

    private static bool Can2Hko(Battle battle, Move move)
    {
        var opponent = battle.PlayerParty.GetFirstAlivePokemon();
        return CalculateDamage(battle, move) > opponent.CurrentHP / 2;
    }

    private static int CalculateDamage(Battle battle, Move move) => battle
        .CalculateDamage(battle.ActiveOpponentBattler, battle.ActivePlayerBattler, false, move).Value;

    private static bool ShouldUseHazards(Battle battle, Hazard hazard)
    {
        // assumes enemy side doesnt have hazards already
        var oppParty = battle.PlayerParty;
        var opponent = oppParty.GetFirstAlivePokemon();

        if (opponent.HasAbility("Magic Bounce") || opponent.HasMove("Magic Coat"))
            return false; // reflecting hazards
        double damageValuePercent = 0;
        foreach (var p in oppParty.Pokemons)
        {
            if (!(p.HasAbility("Levitate") && (hazard == Hazard.Spikes || hazard == Hazard.ToxicSpikes)))
                damageValuePercent += p.GetDamagePercentageFromHazard(hazard);
            if (p.HasMove("Rapid Spin", "Defog")) return false;
        }

        return damageValuePercent > 50;
    }
    */
    public static Move GetBestAiMove(Pokemon currentPokemon)
    {
        return currentPokemon.Moves[0]; // TODO
    }
}