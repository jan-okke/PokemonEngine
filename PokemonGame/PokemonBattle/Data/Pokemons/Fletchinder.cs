using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fletchinder : Pokemon
	{
		public override string Name => "Fletchinder";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Galewings() };
		public override Stats BaseStats => new Stats(62, 73, 55, 84, 56, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Flamecharge() },
			[1] = new List<Move>() { new Flamecharge(), new Feint(), new Peck(), new Growl(), new Quickattack(), new Ember() },
			[15] = new List<Move>() { new Flail() },
			[22] = new List<Move>() { new Acrobatics() },
			[29] = new List<Move>() { new Agility() },
			[36] = new List<Move>() { new Aerialace() },
			[43] = new List<Move>() { new Tailwind() },
			[50] = new List<Move>() { new Steelwing() },
			[57] = new List<Move>() { new Roost() },
			[64] = new List<Move>() { new Fly() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Attract(), new Dualwingbeat(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Fly(), new Heatwave(), new Hiddenpower(), new Overheat(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 160;
		public override int ExpYield => 134;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}