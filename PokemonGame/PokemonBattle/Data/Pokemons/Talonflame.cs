using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Talonflame : Pokemon
	{
		public override string Name => "Talonflame";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Galewings() };
		public override Stats BaseStats => new Stats(78, 81, 71, 74, 69, 126);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Flamecharge(), new Flareblitz(), new Feint(), new Peck(), new Growl(), new Quickattack(), new Ember() },
			[15] = new List<Move>() { new Flail() },
			[22] = new List<Move>() { new Acrobatics() },
			[29] = new List<Move>() { new Agility() },
			[38] = new List<Move>() { new Aerialace() },
			[47] = new List<Move>() { new Tailwind() },
			[56] = new List<Move>() { new Steelwing() },
			[65] = new List<Move>() { new Roost() },
			[74] = new List<Move>() { new Fly() },
			[83] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Attract(), new Bravebird(), new Bulkup(), new Dualwingbeat(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fly(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Overheat(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 245;
		public override int ExpYield => 175;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}