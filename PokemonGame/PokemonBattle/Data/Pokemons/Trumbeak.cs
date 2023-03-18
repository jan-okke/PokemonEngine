using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Trumbeak : Pokemon
	{
		public override string Name => "Trumbeak";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Skilllink() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickup() };
		public override Stats BaseStats => new Stats(55, 85, 50, 40, 50, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Rockblast(), new Moves.Peck(), new Moves.Growl(), new Moves.Echoedvoice(), new Moves.Rocksmash() },
			[3] = new List<Move>() { new Moves.Growl() },
			[7] = new List<Move>() { new Moves.Echoedvoice() },
			[9] = new List<Move>() { new Moves.Rocksmash() },
			[13] = new List<Move>() { new Moves.Supersonic() },
			[16] = new List<Move>() { new Moves.Pluck() },
			[21] = new List<Move>() { new Moves.Roost() },
			[24] = new List<Move>() { new Moves.Furyattack() },
			[29] = new List<Move>() { new Moves.Screech() },
			[32] = new List<Move>() { new Moves.Drillpeck() },
			[37] = new List<Move>() { new Moves.Bulletseed() },
			[40] = new List<Move>() { new Moves.Featherdance() },
			[45] = new List<Move>() { new Moves.Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Flamecharge(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Knockoff(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override int Weight => 148;
		public override int ExpYield => 124;
		public override int CatchRate => 120;
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
}