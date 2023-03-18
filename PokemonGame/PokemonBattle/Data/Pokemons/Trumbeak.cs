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
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Skilllink() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickup() };
		public override Stats BaseStats => new Stats(55, 85, 50, 40, 50, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rockblast(), new Peck(), new Growl(), new Echoedvoice(), new Rocksmash() },
			[3] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Echoedvoice() },
			[9] = new List<Move>() { new Rocksmash() },
			[13] = new List<Move>() { new Supersonic() },
			[16] = new List<Move>() { new Pluck() },
			[21] = new List<Move>() { new Roost() },
			[24] = new List<Move>() { new Furyattack() },
			[29] = new List<Move>() { new Screech() },
			[32] = new List<Move>() { new Drillpeck() },
			[37] = new List<Move>() { new Bulletseed() },
			[40] = new List<Move>() { new Featherdance() },
			[45] = new List<Move>() { new Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Brickbreak(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Flamecharge(), new Fly(), new Frustration(), new Gunkshot(), new Heatwave(), new Hiddenpower(), new Hypervoice(), new Knockoff(), new Protect(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Smackdown(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Tailwind(), new Thief(), new Toxic(), new Uproar(), new Uturn(), new Workup() };
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