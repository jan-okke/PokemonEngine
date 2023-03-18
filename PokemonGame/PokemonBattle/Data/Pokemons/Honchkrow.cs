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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Insomnia(), new Abilities.Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
		public override Stats BaseStats => new Stats(100, 125, 52, 105, 52, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Nightslash(), new Moves.Suckerpunch(), new Moves.Astonish(), new Moves.Haze(), new Moves.Wingattack() },
			[25] = new List<Move>() { new Moves.Swagger() },
			[35] = new List<Move>() { new Moves.Nastyplot() },
			[45] = new List<Move>() { new Moves.Foulplay() },
			[55] = new List<Move>() { new Moves.Nightslash() },
			[65] = new List<Move>() { new Moves.Quash() },
			[75] = new List<Move>() { new Moves.Darkpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Quash(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Uproar() };
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