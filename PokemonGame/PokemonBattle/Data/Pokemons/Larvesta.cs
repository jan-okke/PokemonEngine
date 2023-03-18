using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Larvesta : Pokemon
	{
		public override string Name => "Larvesta";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(55, 85, 55, 50, 55, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Ember(), new Stringshot() },
			[6] = new List<Move>() { new Flamecharge() },
			[12] = new List<Move>() { new Strugglebug() },
			[18] = new List<Move>() { new Flamewheel() },
			[24] = new List<Move>() { new Bugbite() },
			[30] = new List<Move>() { new Screech() },
			[36] = new List<Move>() { new Leechlife() },
			[42] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Takedown() },
			[54] = new List<Move>() { new Amnesia() },
			[60] = new List<Move>() { new Doubleedge() },
			[66] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Amnesia(), new Attract(), new Bugbuzz(), new Calmmind(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flareblitz(), new Gigadrain(), new Heatwave(), new Hiddenpower(), new Leechlife(), new Lightscreen(), new Overheat(), new Protect(), new Psychic(), new Rest(), new Round(), new Safeguard(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Uturn(), new Wildcharge(), new Willowisp(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Absorb(), new Harden(), new Thrash() };
		public override int Weight => 288;
		public override int ExpYield => 72;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}