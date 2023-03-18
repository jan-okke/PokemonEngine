using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wimpod : Pokemon
	{
		public override string Name => "Wimpod";
		public override List<Ability> AvailableAbilities => new() {new Wimpout() };
		public override Stats BaseStats => new Stats(25, 35, 40, 20, 30, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Strugglebug(), new Sandattack(), new Defensecurl() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bugbuzz(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Leechlife(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Spikes(), new Substitute(), new Surf(), new Swift(), new Taunt(), new Waterfall() };
		public override List<Move> EggMoves => new List<Move>() { new Aquajet(), new Harden(), new Metalclaw(), new Rollout(), new Wideguard() };
		public override int Weight => 120;
		public override int ExpYield => 46;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}