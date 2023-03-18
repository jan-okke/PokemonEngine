using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Whirlipede : Pokemon
	{
		public override string Name => "Whirlipede";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Speedboost() };
		public override Stats BaseStats => new Stats(40, 55, 99, 40, 79, 47);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Irondefense() },
			[1] = new List<Move>() { new Moves.Irondefense(), new Moves.Poisonsting(), new Moves.Defensecurl(), new Moves.Rollout(), new Moves.Protect() },
			[12] = new List<Move>() { new Moves.Poisontail() },
			[16] = new List<Move>() { new Moves.Screech() },
			[20] = new List<Move>() { new Moves.Bugbite() },
			[26] = new List<Move>() { new Moves.Venoshock() },
			[32] = new List<Move>() { new Moves.Takedown() },
			[38] = new List<Move>() { new Moves.Agility() },
			[44] = new List<Move>() { new Moves.Toxic() },
			[50] = new List<Move>() { new Moves.Venomdrench() },
			[56] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Endure(), new Moves.Facade(), new Moves.Gyroball(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock() };
		public override int Weight => 585;
		public override int ExpYield => 126;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}