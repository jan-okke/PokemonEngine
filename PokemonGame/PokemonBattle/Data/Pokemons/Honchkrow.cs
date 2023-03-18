using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Honchkrow : Pokemon
	{
		public override string Name => "Honchkrow";
		public override List<Ability> AvailableAbilities => new() {new Insomnia(), new Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(100, 125, 52, 105, 52, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nightslash(), new Suckerpunch(), new Astonish(), new Haze(), new Wingattack() },
			[25] = new List<Move>() { new Swagger() },
			[35] = new List<Move>() { new Nastyplot() },
			[45] = new List<Move>() { new Foulplay() },
			[55] = new List<Move>() { new Nightslash() },
			[65] = new List<Move>() { new Quash() },
			[75] = new List<Move>() { new Darkpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Calmmind(), new Confide(), new Darkpulse(), new Defog(), new Doubleteam(), new Dreameater(), new Embargo(), new Endure(), new Facade(), new Fly(), new Foulplay(), new Frustration(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Icywind(), new Nastyplot(), new Payback(), new Pluck(), new Protect(), new Psychic(), new Psychup(), new Quash(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Shadowball(), new Skyattack(), new Sleeptalk(), new Snarl(), new Snatch(), new Snore(), new Spite(), new Steelwing(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Tailwind(), new Taunt(), new Thief(), new Thunderwave(), new Torment(), new Uproar() };
		public override int Weight => 273;
		public override int ExpYield => 177;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}