#nullable enable
using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Actions;
using System.Linq;
using System;
using PokemonGame.PokemonBattle.Exceptions;
using PokemonGame.PokemonBattle.Validation;

namespace PokemonGame.PokemonBattle.Entities;

public class Pokemon
{
    public virtual string Name { get; }
    public int Level { get; internal set; }
    public int Experience { get; internal set; }
    public Ability? Ability { get; internal set; }
    public virtual List<Ability?> AvailableAbilities { get; }
    public virtual List<Ability>? AvailableHiddenAbilities { get; }
    public Item? Item { get; internal set; }
    public List<Move> Moves { get; } = new();
    public virtual Dictionary<int, List<Move>> LevelUpLearnSet { get; }
    public virtual List<Move> EggMoves { get; }
    public virtual List<Move> TutorMoves { get; }
    public virtual Stats BaseStats { get; }
    public Stats IVs { get; } = new();
    public Stats EVs { get; } = new();
    public Stats Stats { get; } = new();
    public Stats StatStages { get; } = new();
    public StatusCondition? Status { get; internal set; }
    public List<SecondaryStatusCondition> SecondaryStatusConditions { get; } = new();
    public virtual ExperienceGroup ExperienceGroup { get; }

    public int CurrentHP { get; internal set; }
    public List<Effect> Effects { get; internal set; } = new();
    public virtual List<PokemonType> Types { get; } = new();
    public Gender Gender { get; internal set; }
    public DynamaxState DynamaxState { get; internal set; } = new(0);

    public virtual int Weight { get; internal set; }
    public virtual int ExpYield { get; }
    public virtual Dictionary<Stat, int> EVYield { get; }
    public virtual int CatchRate { get; }

    public bool IsAlive => CurrentHP > 0;
    public bool IsDynamaxed => DynamaxState.Active;
    public bool IsUnderground => false; // TODO
    public bool IsUnderwater => false; // TODO
    public bool IsProtected => Effects.Any(e => e.HasType(EffectType.Protect, EffectType.BanefulBunker));
    public bool IsFlying => false; // TODO
    public bool IsMinimized => false; // TODO

    public bool Flinched { get; internal set; } // TODO this has to be reset at the end of turn lol
    public bool Infatuated { get; internal set; } // in love
    public bool Confused { get; internal set; }
    public bool Trapped { get; internal set; }
    public bool Muted { get; internal set; } // can not use sound moves xd
    public bool Cursed { get; internal set; }


    private static Pokemon GetPokemon(string name)
    {
        const string space = "PokemonGame.PokemonBattle.Data.Pokemons";
        var pokemon = System.Type.GetType($"{space}.{name}");
        if (pokemon == null)
        {
            throw new ArgumentException($"Object name {name} not recognized.", nameof(name));
        }

        if (Activator.CreateInstance(pokemon) is not Pokemon result) throw new NullReferenceException();
        result.Ability = result.AvailableAbilities[0];
        result.CalculateStats();
        result.HealHp();

        DebugConsole.WriteLine(result.IsAlive);

        return result;

    }

    public static Pokemon GetPokemon(string name, int level)
    {
        var pokemon = GetPokemon(name);
        pokemon.Level = level;
        pokemon.CalculateStats();
        pokemon.HealHp();
        foreach (var m in pokemon.GetUpTo4MovesAtLevel(level))
        {
            pokemon.LearnMove(m);
        }

        return pokemon;
    }

    private void LearnMove(Move move)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return Name;
    }

    public void SetStatus(StatusConditionType condition, int startingTurns)
    {
        if (Status is { IsActive: true })
        {
            throw new StatusAlreadyActiveException();
        }

        Status = new StatusCondition(condition, startingTurns);
    }

    public void Flinch()
    {
        if (this.CanFlinch())
        {
            Flinched = true;
        }
    }

    public void Confuse()
    {
        if (this.CanConfused())
        {
            Confused = true;
        }
    }

    public void LowerStatStage(Stat stat, int amount)
    {
        switch (stat)
        {
            case Stat.HP:
                throw new StatCantBeLoweredException();
            case Stat.Attack:
                if (StatStages.Attack == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Attack -= amount;
                if (StatStages.Attack < -6)
                {
                    StatStages.Attack = -6;
                }

                break;
            case Stat.Defense:
                if (StatStages.Defense == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Defense -= amount;
                if (StatStages.Defense < -6)
                {
                    StatStages.Defense = -6;
                }

                break;
            case Stat.SpecialAttack:
                if (StatStages.SpecialAttack == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.SpecialAttack -= amount;
                if (StatStages.SpecialAttack < -6)
                {
                    StatStages.SpecialAttack = -6;
                }

                break;
            case Stat.SpecialDefense:
                if (StatStages.SpecialDefense == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.SpecialDefense -= amount;
                if (StatStages.SpecialDefense < -6)
                {
                    StatStages.SpecialDefense = -6;
                }

                break;
            case Stat.Speed:
                if (StatStages.Speed == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Speed -= amount;
                if (StatStages.Speed < -6)
                {
                    StatStages.Speed = -6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }

        ;
    }

    public void IncreaseStatStage(Stat stat, int amount)
    {
        switch (stat)
        {
            case Stat.HP:
                throw new StatCantBeRaisedException();
            case Stat.Attack:
                if (StatStages.Attack == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Attack += amount;
                if (StatStages.Attack > 6)
                {
                    StatStages.Attack = 6;
                }

                break;
            case Stat.Defense:
                if (StatStages.Defense == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Defense += amount;
                if (StatStages.Defense > 6)
                {
                    StatStages.Defense = 6;
                }

                break;
            case Stat.SpecialAttack:
                if (StatStages.SpecialAttack == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.SpecialAttack += amount;
                if (StatStages.SpecialAttack > 6)
                {
                    StatStages.SpecialAttack = 6;
                }

                break;
            case Stat.SpecialDefense:
                if (StatStages.SpecialDefense == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.SpecialDefense += amount;
                if (StatStages.SpecialDefense > 6)
                {
                    StatStages.SpecialDefense = 6;
                }

                break;
            case Stat.Speed:
                if (StatStages.Speed == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Speed += amount;
                if (StatStages.Speed > 6)
                {
                    StatStages.Speed = 6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }

        ;
    }

    public void GiveEffect(EffectType effectType, int turns)
    {
        if (this.HasEffect(effectType))
        {
            throw new PokemonHasEffectAlreadyException();
        }

        Effects.Add(new Effect(effectType, turns));
    }

    public void HealStatusCondition()
    {
        Status = null;
    }

    public void Infatuate(Pokemon attackingPokemon)
    {
        if (this.CanInfatuate(attackingPokemon))
        {
            Infatuated = true;
        }
    }

    public void TakeDamage(int amount)
    {
        CurrentHP -= amount;
        if (CurrentHP >= 0) return;
        CurrentHP = 0;
        OnFaint();
    }

    public void TransferItem(Item attackingPokemonItem, Pokemon defendingPokemon)
    {
        throw new NotImplementedException();
    }

    public void Trap()
    {
        if (this.CanTrap())
        {
            Trapped = true;
        }
    }

    public void IncreaseAllStatStagesBy(int amount)
    {
        IncreaseStatStage(Stat.Attack, amount);
        IncreaseStatStage(Stat.Defense, amount);
        IncreaseStatStage(Stat.SpecialAttack, amount);
        IncreaseStatStage(Stat.SpecialDefense, amount);
        IncreaseStatStage(Stat.Speed, amount);
    }

    public void IncreaseStatStage(SecondaryStat stat, int amount)
    {
        switch (stat)
        {
            case SecondaryStat.Accuracy:
                if (StatStages.Accuracy == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Accuracy += amount;
                if (StatStages.Accuracy > 6)
                {
                    StatStages.Accuracy = 6;
                }

                break;
            case SecondaryStat.Evasion:
                if (StatStages.Evasion == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Evasion += amount;
                if (StatStages.Evasion > 6)
                {
                    StatStages.Evasion = 6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    public void Curse()
    {
        if (this.CanCursed())
        {
            Cursed = true;
        }
    }

    public void HealHp(int amount)
    {
        CurrentHP += amount;
        if (CurrentHP > Stats.HP)
        {
            CurrentHP = Stats.HP;
        }
    }

    public void HealHp()
    {
        CurrentHP = Stats.HP;
    }

    public void IncreaseRandomAvailableStatBy(int amount)
    {
        throw new NotImplementedException();
    }

    public void Mute()
    {
        if (this.CanMute())
        {
            Muted = true;
        }
    }

    public void LowerStatStage(SecondaryStat stat, int amount)
    {
        switch (stat)
        {
            case SecondaryStat.Accuracy:
                if (StatStages.Accuracy == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Accuracy -= amount;
                if (StatStages.Accuracy < -6)
                {
                    StatStages.Accuracy = -6;
                }

                break;
            case SecondaryStat.Evasion:
                if (StatStages.Evasion == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Evasion -= amount;
                if (StatStages.Evasion < -6)
                {
                    StatStages.Evasion = -6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    public void OnTurnEnd()
    {
        throw new NotImplementedException();
    }

    private void OnFaint()
    {
        throw new NotImplementedException();
    }
}