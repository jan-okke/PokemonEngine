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
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Speedboost() };
		public override Stats BaseStats => new Stats(60, 100, 89, 55, 69, 112);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Irondefense(), new Batonpass(), new Poisonsting(), new Defensecurl(), new Rollout(), new Protect() },
			[12] = new List<Move>() { new Poisontail() },
			[16] = new List<Move>() { new Screech() },
			[20] = new List<Move>() { new Bugbite() },
			[26] = new List<Move>() { new Venoshock() },
			[34] = new List<Move>() { new Takedown() },
			[42] = new List<Move>() { new Agility() },
			[50] = new List<Move>() { new Toxic() },
			[58] = new List<Move>() { new Venomdrench() },
			[66] = new List<Move>() { new Doubleedge() },
			[74] = new List<Move>() { new Megahorn() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Batonpass(), new Bulldoze(), new Crosspoison(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Gyroball(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Irontail(), new Megahorn(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Smartstrike(), new Snore(), new Solarbeam(), new Spikes(), new Steelroller(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Swordsdance(), new Throatchop(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Xscissor() };
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