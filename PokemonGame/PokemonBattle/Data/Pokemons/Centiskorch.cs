using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Centiskorch : Pokemon
	{
		public override string Name => "Centiskorch";
		public override List<Ability> AvailableAbilities => new() {new Flashfire(), new Whitesmoke() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flamebody() };
		public override Stats BaseStats => new Stats(100, 115, 65, 65, 90, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Inferno(), new Ember(), new Smokescreen(), new Wrap(), new Bite() },
			[15] = new List<Move>() { new Flamewheel() },
			[20] = new List<Move>() { new Bugbite() },
			[25] = new List<Move>() { new Coil() },
			[32] = new List<Move>() { new Slam() },
			[39] = new List<Move>() { new Firespin() },
			[46] = new List<Move>() { new Crunch() },
			[53] = new List<Move>() { new Firelash() },
			[60] = new List<Move>() { new Lunge() },
			[67] = new List<Move>() { new Burnup() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brutalswing(), new Bugbuzz(), new Crunch(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flareblitz(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Mysticalfire(), new Overheat(), new Powerwhip(), new Protect(), new Rest(), new Round(), new Scald(), new Scorchingsands(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thunderfang(), new Venoshock(), new Willowisp(), new Xscissor() };
		public override int Weight => 1200;
		public override int ExpYield => 184;
		public override int CatchRate => 75;
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