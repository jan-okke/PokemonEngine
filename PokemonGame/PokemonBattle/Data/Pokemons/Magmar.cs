using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magmar : Pokemon
	{
		public override string Name => "Magmar";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Vitalspirit() };
		public override Stats BaseStats => new Stats(65, 95, 57, 100, 85, 93);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Smog(), new Moves.Leer(), new Moves.Ember(), new Moves.Smokescreen() },
			[12] = new List<Move>() { new Moves.Clearsmog() },
			[16] = new List<Move>() { new Moves.Flamewheel() },
			[20] = new List<Move>() { new Moves.Confuseray() },
			[24] = new List<Move>() { new Moves.Scaryface() },
			[28] = new List<Move>() { new Moves.Firepunch() },
			[34] = new List<Move>() { new Moves.Lavaplume() },
			[40] = new List<Move>() { new Moves.Lowkick() },
			[46] = new List<Move>() { new Moves.Flamethrower() },
			[52] = new List<Move>() { new Moves.Sunnyday() },
			[58] = new List<Move>() { new Moves.Fireblast() },
			[64] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Burningjealousy(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Overheat(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Willowisp() };
		public override int Weight => 445;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}