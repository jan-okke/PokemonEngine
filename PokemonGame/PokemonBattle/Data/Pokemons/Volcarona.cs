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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swarm() };
		public override Stats BaseStats => new Stats(85, 60, 65, 135, 105, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Quiverdance() },
			[1] = new List<Move>() { new Moves.Quiverdance(), new Moves.Fierydance(), new Moves.Whirlwind(), new Moves.Ember(), new Moves.Flamecharge(), new Moves.Takedown(), new Moves.Doubleedge(), new Moves.Flareblitz(), new Moves.Firespin(), new Moves.Stringshot(), new Moves.Gust(), new Moves.Strugglebug() },
			[18] = new List<Move>() { new Moves.Flamewheel() },
			[24] = new List<Move>() { new Moves.Bugbite() },
			[30] = new List<Move>() { new Moves.Screech() },
			[36] = new List<Move>() { new Moves.Leechlife() },
			[42] = new List<Move>() { new Moves.Bugbuzz() },
			[48] = new List<Move>() { new Moves.Heatwave() },
			[54] = new List<Move>() { new Moves.Amnesia() },
			[62] = new List<Move>() { new Moves.Hurricane() },
			[70] = new List<Move>() { new Moves.Fireblast() },
			[78] = new List<Move>() { new Moves.Ragepowder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Bugbuzz(), new Moves.Calmmind(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fly(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Zenheadbutt() };
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