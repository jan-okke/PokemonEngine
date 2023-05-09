using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Torchic : Pokemon
{
	public override string Name => "Torchic";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Speedboost() };
	public override Stats BaseStats => new Stats(45, 60, 40, 70, 50, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl() },
		[3] = new List<Move>() { new Moves.Ember() },
		[6] = new List<Move>() { new Moves.Quickattack() },
		[9] = new List<Move>() { new Moves.Flamecharge() },
		[12] = new List<Move>() { new Moves.Detect() },
		[15] = new List<Move>() { new Moves.Sandattack() },
		[18] = new List<Move>() { new Moves.Aerialace() },
		[21] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Bounce() },
		[27] = new List<Move>() { new Moves.Focusenergy() },
		[30] = new List<Move>() { new Moves.Flamethrower() },
		[33] = new List<Move>() { new Moves.Featherdance() },
		[36] = new List<Move>() { new Moves.Reversal() },
		[39] = new List<Move>() { new Moves.Flareblitz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Focusenergy(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Willowisp(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Batonpass(), new Moves.Counter(), new Moves.Crushclaw(), new Moves.Curse(), new Moves.Featherdance(), new Moves.Feint(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Nightslash(), new Moves.Peck(), new Moves.Reversal() };
	public override int Weight => 25;
	public override int ExpYield => 62;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}