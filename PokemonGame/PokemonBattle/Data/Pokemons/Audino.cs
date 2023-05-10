using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Audino : Pokemon
{
	public override string Name => "Audino";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Healer(), new Abilities.Regenerator() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Klutz() };
	public override Stats BaseStats => new Stats(103, 60, 86, 60, 86, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Playnice() },
		[4] = new List<Move>() { new Moves.Disarmingvoice() },
		[9] = new List<Move>() { new Moves.Babydolleyes() },
		[12] = new List<Move>() { new Moves.Helpinghand() },
		[16] = new List<Move>() { new Moves.Growl() },
		[20] = new List<Move>() { new Moves.Zenheadbutt() },
		[24] = new List<Move>() { new Moves.Lifedew() },
		[28] = new List<Move>() { new Moves.Afteryou() },
		[32] = new List<Move>() { new Moves.Takedown() },
		[36] = new List<Move>() { new Moves.Simplebeam() },
		[40] = new List<Move>() { new Moves.Hypervoice() },
		[44] = new List<Move>() { new Moves.Healpulse() },
		[48] = new List<Move>() { new Moves.Doubleedge() },
		[52] = new List<Move>() { new Moves.Entrainment() },
		[56] = new List<Move>() { new Moves.Mistyterrain() },
		[60] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyterrain(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Healingwish(), new Moves.Sweetkiss(), new Moves.Wish(), new Moves.Yawn() };
	public override int Weight => 310;
	public override int ExpYield => 390;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}