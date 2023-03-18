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
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(40, 55, 99, 47, 40, 79);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Irondefense() },
			[1] = new List<Move>() { new Irondefense(), new Poisonsting(), new Defensecurl(), new Rollout(), new Protect() },
			[12] = new List<Move>() { new Poisontail() },
			[16] = new List<Move>() { new Screech() },
			[20] = new List<Move>() { new Bugbite() },
			[26] = new List<Move>() { new Venoshock() },
			[32] = new List<Move>() { new Takedown() },
			[38] = new List<Move>() { new Agility() },
			[44] = new List<Move>() { new Toxic() },
			[50] = new List<Move>() { new Venomdrench() },
			[56] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Endure(), new Facade(), new Gyroball(), new Hex(), new Hiddenpower(), new Irondefense(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Spikes(), new Steelroller(), new Substitute(), new Sunnyday(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
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