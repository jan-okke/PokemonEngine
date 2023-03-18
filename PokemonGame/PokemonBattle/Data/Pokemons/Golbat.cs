using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golbat : Pokemon
	{
		public override string Name => "Golbat";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(75, 80, 70, 90, 65, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Screech(), new Absorb(), new Supersonic(), new Astonish(), new Meanlook() },
			[15] = new List<Move>() { new Poisonfang() },
			[20] = new List<Move>() { new Quickguard() },
			[27] = new List<Move>() { new Aircutter() },
			[34] = new List<Move>() { new Bite() },
			[41] = new List<Move>() { new Haze() },
			[48] = new List<Move>() { new Venoshock() },
			[55] = new List<Move>() { new Confuseray() },
			[62] = new List<Move>() { new Airslash() },
			[69] = new List<Move>() { new Leechlife() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Assurance(), new Attract(), new Bravebird(), new Crunch(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Gigadrain(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Nastyplot(), new Payback(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Roost(), new Round(), new Screech(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Torment(), new Uproar(), new Uturn(), new Venomdrench(), new Venoshock(), new Zenheadbutt() };
		public override int Weight => 550;
		public override int ExpYield => 159;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}