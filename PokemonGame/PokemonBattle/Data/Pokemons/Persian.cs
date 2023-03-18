using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Persian : Pokemon
	{
		public override string Name => "Persian";
		public override List<Ability> AvailableAbilities => new() {new Limber(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(65, 70, 60, 115, 65, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Powergem() },
			[1] = new List<Move>() { new Powergem(), new Switcheroo(), new Fakeout(), new Growl(), new Feint(), new Scratch() },
			[12] = new List<Move>() { new Payday() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Taunt() },
			[24] = new List<Move>() { new Assurance() },
			[31] = new List<Move>() { new Furyswipes() },
			[36] = new List<Move>() { new Screech() },
			[42] = new List<Move>() { new Slash() },
			[48] = new List<Move>() { new Nastyplot() },
			[54] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Amnesia(), new Assurance(), new Attract(), new Bodyslam(), new Charm(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icywind(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Powergem(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Round(), new Screech(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Torment(), new Uproar(), new Uturn(), new Waterpulse(), new Workup() };
		public override int Weight => 320;
		public override int ExpYield => 154;
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