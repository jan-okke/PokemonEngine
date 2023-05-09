using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Marshadow : Pokemon
{
	public override string Name => "Marshadow";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Technician() };
	public override Stats BaseStats => new Stats(90, 125, 80, 90, 90, 125);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Thunderpunch(), new Moves.Firepunch(), new Moves.Icepunch(), new Moves.Copycat(), new Moves.Shadowsneak(), new Moves.Feint(), new Moves.Counter() },
		[9] = new List<Move>() { new Moves.Roleplay() },
		[18] = new List<Move>() { new Moves.Shadowpunch() },
		[27] = new List<Move>() { new Moves.Forcepalm() },
		[36] = new List<Move>() { new Moves.Assurance() },
		[45] = new List<Move>() { new Moves.Suckerpunch() },
		[54] = new List<Move>() { new Moves.Drainpunch() },
		[63] = new List<Move>() { new Moves.Psychup() },
		[72] = new List<Move>() { new Moves.Spectralthief() },
		[81] = new List<Move>() { new Moves.Laserfocus() },
		[90] = new List<Move>() { new Moves.Endeavor() },
		[99] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Assurance(), new Moves.Aurasphere(), new Moves.Blazekick(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poisonjab(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swift(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 222;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}