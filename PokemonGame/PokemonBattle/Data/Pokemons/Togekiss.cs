using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Togekiss : Pokemon
{
	public override string Name => "Togekiss";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hustle(), new Abilities.Serenegrace() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Superluck() };
	public override Stats BaseStats => new Stats(85, 50, 95, 120, 115, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Fairy, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Airslash() },
		[1] = new List<Move>() { new Moves.Airslash(), new Moves.Fairywind(), new Moves.Skyattack(), new Moves.Aurasphere(), new Moves.Extremespeed(), new Moves.Triattack(), new Moves.Charm(), new Moves.Ancientpower(), new Moves.Yawn(), new Moves.Metronome(), new Moves.Afteryou(), new Moves.Doubleedge(), new Moves.Safeguard(), new Moves.Followme(), new Moves.Batonpass(), new Moves.Lastresort(), new Moves.Wish(), new Moves.Growl(), new Moves.Pound(), new Moves.Sweetkiss(), new Moves.Lifedew() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Fly(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Mysticalfire(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Pluck(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 380;
	public override int ExpYield => 273;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}