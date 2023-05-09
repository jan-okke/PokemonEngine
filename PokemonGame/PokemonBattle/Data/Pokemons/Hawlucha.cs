using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hawlucha : Pokemon
{
	public override string Name => "Hawlucha";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber(), new Abilities.Unburden() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
	public override Stats BaseStats => new Stats(78, 92, 75, 74, 63, 118);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Honeclaws() },
		[4] = new List<Move>() { new Moves.Wingattack() },
		[8] = new List<Move>() { new Moves.Detect() },
		[12] = new List<Move>() { new Moves.Aerialace() },
		[16] = new List<Move>() { new Moves.Encore() },
		[20] = new List<Move>() { new Moves.Featherdance() },
		[24] = new List<Move>() { new Moves.Submission() },
		[28] = new List<Move>() { new Moves.Bounce() },
		[32] = new List<Move>() { new Moves.Taunt() },
		[36] = new List<Move>() { new Moves.Roost() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[44] = new List<Move>() { new Moves.Flyingpress() },
		[48] = new List<Move>() { new Moves.Highjumpkick() },
		[52] = new List<Move>() { new Moves.Endeavor() },
		[56] = new List<Move>() { new Moves.Skyattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodypress(), new Moves.Bounce(), new Moves.Bravebird(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Dualwingbeat(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Ironhead(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Uturn(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Crosschop(), new Moves.Defog(), new Moves.Entrainment(), new Moves.Feint(), new Moves.Meanlook(), new Moves.Quickguard() };
	public override int Weight => 215;
	public override int ExpYield => 175;
	public override int CatchRate => 100;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}