﻿using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using System.Linq;

namespace PokemonGame.PokemonBattle.Validation;

public static class PokemonValidation
{
    public static bool CanFlinch(this Pokemon pokemon) => true; // TODO

    public static bool CanTrap(this Pokemon pokemon) => true; // TODO

    public static bool CanConfused(this Pokemon pokemon) => true; // TODO

    public static bool CanMute(this Pokemon pokemon) => true; // TODO
        
    public static bool CanGetStatusCondition(this Pokemon pokemon, StatusConditionType condition) => true; // TODO

    public static bool CanInfatuate(this Pokemon pokemon, Pokemon sender) => sender.IsOpposingGender(pokemon);

    public static bool CanCursed(this Pokemon pokemon) => true; // TODO
        
    public static bool CanDynamax(this Pokemon pokemon) => false; // TODO

    public static bool IsMoveValid(this Pokemon pokemon, Move move) => pokemon.CheckEggMoveCompatability(move) || pokemon.CheckMoveTutorCompatability(move) || pokemon.LevelUpLearnSet.Where(l => l.Key > 0).Any(x => x.Value.Any(m => m.NameIsAnyOf(move.Name)));

    public static bool CanHaveAbility(this Pokemon pokemon, Ability ability) {
        foreach (Ability a in pokemon.AvailableAbilities) {
            if (a.HasName(ability.Name))
            {
                return true;
            }
        }
        foreach (Ability a in pokemon.AvailableHiddenAbilities) {
            if (a.HasName(ability.Name))
            {
                return true;
            }
        }
        return false;
    }
}