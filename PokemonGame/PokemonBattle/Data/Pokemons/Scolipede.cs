using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Scolipede : Pokemon
	{
		public override string Name => "Scolipede";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Speedboost() };
		public override Stats BaseStats => new Stats(60, 100, 89, 55, 69, 112);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Irondefense(), new Moves.Batonpass(), new Moves.Poisonsting(), new Moves.Defensecurl(), new Moves.Rollout(), new Moves.Protect() },
			[12] = new List<Move>() { new Moves.Poisontail() },
			[16] = new List<Move>() { new Moves.Screech() },
			[20] = new List<Move>() { new Moves.Bugbite() },
			[26] = new List<Move>() { new Moves.Venoshock() },
			[34] = new List<Move>() { new Moves.Takedown() },
			[42] = new List<Move>() { new Moves.Agility() },
			[50] = new List<Move>() { new Moves.Toxic() },
			[58] = new List<Move>() { new Moves.Venomdrench() },
			[66] = new List<Move>() { new Moves.Doubleedge() },
			[74] = new List<Move>() { new Moves.Megahorn() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bulldoze(), new Moves.Crosspoison(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Megahorn(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Xscissor() };
		public override int Weight => 2005;
		public override int ExpYield => 243;
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