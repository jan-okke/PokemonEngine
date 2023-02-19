using PokemonGame.PokemonBattle.Entities;
using System.Linq;
using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;
using System;

namespace PokemonGame.PokemonBattle.Extensions 
{
    public static class PokemonExtension 
    {
        public static bool SetStatus(this Pokemon pokemon, StatusConditionType condition, int startingTurns)
        {
            if (!pokemon.CanGetStatusCondition(condition)) return false;
            pokemon.Status = new StatusCondition(condition, startingTurns);
            return true;
        }
        public static void MaxIVS(this Pokemon pokemon, bool ignoreAttack = false, bool ignoreSpeed = false)
        {
            pokemon.IVs.HP = 31;
            pokemon.IVs.Attack = ignoreAttack ? 0 : 31;
            pokemon.IVs.Defense = 31;
            pokemon.IVs.SpecialAttack = 31;
            pokemon.IVs.SpecialDefense = 31;
            pokemon.IVs.Speed = ignoreSpeed ? 0 : 31;
        }
        public static void HealHP(this Pokemon pokemon)
        {
            pokemon.CurrentHP = pokemon.Stats.HP;
        }
        public static void HealHP(this Pokemon pokemon, int amount)
        {
            pokemon.CurrentHP += Math.Min(amount, pokemon.Stats.HP - pokemon.CurrentHP);
        }
        public static void TakeDamage(this Pokemon pokemon, int amount)
        {
            pokemon.CurrentHP -= Math.Min(amount, pokemon.CurrentHP);
        }
        private static bool CanGetStatusCondition(this Pokemon pokemon, StatusConditionType condition) => true; // TODO
        public static void CalculateStats(this Pokemon pokemon) 
        {
            var baseStats = pokemon.BaseStats;
            var ivs = pokemon.IVs;
            var evs = pokemon.EVs;
            var level = pokemon.Level;
            pokemon.Stats.HP = ((2 * baseStats.HP + ivs.HP + evs.HP / 4) * level / 100) + level + 10;
            pokemon.Stats.Attack = ((2 * baseStats.Attack + ivs.Attack + evs.Attack / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.Defense = ((2 * baseStats.Defense + ivs.Defense + evs.Defense / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.SpecialAttack = ((2 * baseStats.SpecialAttack + ivs.SpecialAttack + evs.SpecialAttack / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.SpecialDefense = ((2 * baseStats.SpecialDefense + ivs.SpecialDefense + evs.SpecialDefense / 4) * level / 100) + 5; // () * natureMod
            pokemon.Stats.Speed = ((2 * baseStats.Speed + ivs.Speed + evs.Speed / 4) * level / 100) + 5; // () * natureMod
        }

        public static bool IsFaster(this Pokemon pokemon, Pokemon other)
        {
            // TODO: Modifier for Stat Stages!
            return pokemon.Stats.Speed > other.Stats.Speed;
        }
        public static bool IsSameGender(this Pokemon pokemon, Pokemon other) => pokemon.Gender != Gender.None && pokemon.Gender == other.Gender;

        public static bool IsOpposingGender(this Pokemon pokemon, Pokemon other) => pokemon.Gender != Gender.None && pokemon.Gender == other.Gender;

        public static double GetHPPercentage(this Pokemon pokemon) => pokemon.CurrentHP / pokemon.Stats.HP;

        public static bool BelowHalfHP(this Pokemon pokemon) => pokemon.GetHPPercentage() < 50;

        public static bool AtFullHP(this Pokemon pokemon) => pokemon.CurrentHP == pokemon.Stats.HP;

        public static bool HasEffect(this Pokemon pokemon, EffectType effect) => pokemon.Effects.Any(e => e.Type == effect && e.IsActive);

        public static bool HasEffect(this Pokemon pokemon, params EffectType[] effects) => effects.Any(e => pokemon.HasEffect(e));

        public static int EffectCount(this Pokemon pokemon, EffectType effect) => pokemon.Effects.Where(e => e.Type == effect).Count();

        public static int EffectCount(this Pokemon pokemon, params EffectType[] effects) => effects.Aggregate(0, (result, e) => result += pokemon.EffectCount(e));
        
        public static bool HasType(this Pokemon pokemon, PokemonType t) => pokemon.Types.Contains(t);

        public static bool HasAbility(this Pokemon pokemon, string abilityName) => pokemon.Ability.Name == abilityName;

        public static bool HasAbility(this Pokemon pokemon, params string[] abilityNames) => abilityNames.Any(a => pokemon.HasAbility(a));

        public static bool HasItem(this Pokemon pokemon, string itemName) => pokemon.Item != null && pokemon.Item.Name == itemName;

        public static bool HasItem(this Pokemon pokemon, params string[] itemNames) => itemNames.Any(i => pokemon.HasItem(i));
        
        public static bool HasStatusCondition(this Pokemon pokemon, StatusConditionType condition) => pokemon.Status != null && pokemon.Status.IsActive && pokemon.Status.Conditon == condition;

        public static bool HasStatusCondition(this Pokemon pokemon) => pokemon.Status == null || pokemon.Status.IsActive;

        public static bool HasStatusCondition(this Pokemon pokemon, List<StatusCondition> conditions) => conditions.Any(c => pokemon.HasStatusCondition(c.Conditon));

        public static bool HasStatusCondition(this Pokemon pokemon, params StatusConditionType[] conditionTypes) => conditionTypes.Any(c => pokemon.HasStatusCondition(c));

        public static double GetStabModBoost(this Pokemon pokemon) => pokemon.HasAbility("Adaptability") ? 2 : 1.5;

        public static double GetBurnedModifier(this Pokemon pokemon) => pokemon.HasAbility("Guts") ? 1.5 : 0.5;

        public static int GetBST(this Pokemon pokemon) 
        {
            return pokemon.BaseStats.Sum();
        }

        public static List<Move> GetHighestBPMoves(this Pokemon pokemon)
        {
            return pokemon.Moves.Where(m => m.BasePower == pokemon.Moves.Max(m => m.BasePower)).ToList();
        }
    }
}