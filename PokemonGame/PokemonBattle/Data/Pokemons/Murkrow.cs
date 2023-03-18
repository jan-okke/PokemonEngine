using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Murkrow : Pokemon
	{
		public override string Name => "Murkrow";
		public override List<Ability> AvailableAbilities => new() {new Insomnia(), new Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(60, 85, 42, 85, 42, 91);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Astonish() },
			[5] = new List<Move>() { new Gust() },
			[11] = new List<Move>() { new Haze() },
			[15] = new List<Move>() { new Wingattack() },
			[21] = new List<Move>() { new Nightshade() },
			[25] = new List<Move>() { new Assurance() },
			[31] = new List<Move>() { new Taunt() },
			[35] = new List<Move>() { new Aircutter() },
			[41] = new List<Move>() { new Meanlook() },
			[45] = new List<Move>() { new Foulplay() },
			[50] = new List<Move>() { new Tailwind() },
			[55] = new List<Move>() { new Suckerpunch() },
			[61] = new List<Move>() { new Torment() },
			[65] = new List<Move>() { new Quash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Calmmind(), new Confide(), new Darkpulse(), new Defog(), new Doubleteam(), new Dreameater(), new Embargo(), new Endure(), new Facade(), new Fly(), new Foulplay(), new Frustration(), new Heatwave(), new Hiddenpower(), new Icywind(), new Payback(), new Pluck(), new Protect(), new Psychic(), new Psychup(), new Quash(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Shadowball(), new Skyattack(), new Sleeptalk(), new Snarl(), new Snatch(), new Snore(), new Spite(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Taunt(), new Thief(), new Thunderwave(), new Torment(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Bravebird(), new Confuseray(), new Drillpeck(), new Featherdance(), new Flatter(), new Perishsong(), new Psychoshift(), new Screech(), new Skyattack(), new Whirlwind(), new Wingattack() };
		public override int Weight => 21;
		public override int ExpYield => 81;
		public override int CatchRate => 30;
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