using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Morgrem : Pokemon
	{
		public override string Name => "Morgrem";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Prankster(), new Abilities.Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
		public override Stats BaseStats => new Stats(65, 60, 45, 75, 55, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Falsesurrender() },
			[1] = new List<Move>() { new Moves.Falsesurrender(), new Moves.Fakeout(), new Moves.Confide(), new Moves.Bite(), new Moves.Flatter() },
			[12] = new List<Move>() { new Moves.Faketears() },
			[16] = new List<Move>() { new Moves.Assurance() },
			[20] = new List<Move>() { new Moves.Swagger() },
			[24] = new List<Move>() { new Moves.Suckerpunch() },
			[28] = new List<Move>() { new Moves.Torment() },
			[35] = new List<Move>() { new Moves.Darkpulse() },
			[40] = new List<Move>() { new Moves.Nastyplot() },
			[46] = new List<Move>() { new Moves.Playrough() },
			[52] = new List<Move>() { new Moves.Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Burningjealousy(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Foulplay(), new Moves.Hiddenpower(), new Moves.Lashout(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uproar() };
		public override int Weight => 125;
		public override int ExpYield => 130;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}