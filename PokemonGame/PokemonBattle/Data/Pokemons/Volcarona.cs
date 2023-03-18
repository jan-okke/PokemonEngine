using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Volcarona : Pokemon
	{
		public override string Name => "Volcarona";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(85, 60, 65, 135, 105, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Quiverdance() },
			[1] = new List<Move>() { new Quiverdance(), new Fierydance(), new Whirlwind(), new Ember(), new Flamecharge(), new Takedown(), new Doubleedge(), new Flareblitz(), new Firespin(), new Stringshot(), new Gust(), new Strugglebug() },
			[18] = new List<Move>() { new Flamewheel() },
			[24] = new List<Move>() { new Bugbite() },
			[30] = new List<Move>() { new Screech() },
			[36] = new List<Move>() { new Leechlife() },
			[42] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Heatwave() },
			[54] = new List<Move>() { new Amnesia() },
			[62] = new List<Move>() { new Hurricane() },
			[70] = new List<Move>() { new Fireblast() },
			[78] = new List<Move>() { new Ragepowder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Amnesia(), new Attract(), new Bugbuzz(), new Calmmind(), new Dualwingbeat(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fly(), new Gigadrain(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Leechlife(), new Lightscreen(), new Mysticalfire(), new Overheat(), new Poisonjab(), new Protect(), new Psychic(), new Rest(), new Round(), new Safeguard(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Uturn(), new Wildcharge(), new Willowisp(), new Zenheadbutt() };
		public override int Weight => 460;
		public override int ExpYield => 275;
		public override int CatchRate => 15;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}