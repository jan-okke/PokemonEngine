using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meowth : Pokemon
	{
		public override string Name => "Meowth";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(40, 45, 35, 40, 40, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fakeout(), new Growl() },
			[4] = new List<Move>() { new Feint() },
			[8] = new List<Move>() { new Scratch() },
			[12] = new List<Move>() { new Payday() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Taunt() },
			[24] = new List<Move>() { new Assurance() },
			[29] = new List<Move>() { new Furyswipes() },
			[32] = new List<Move>() { new Screech() },
			[36] = new List<Move>() { new Slash() },
			[40] = new List<Move>() { new Nastyplot() },
			[44] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Amnesia(), new Assurance(), new Attract(), new Bodyslam(), new Charm(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Gunkshot(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Round(), new Screech(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Torment(), new Uproar(), new Uturn(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Charm(), new Covet(), new Flail(), new Foulplay(), new Hypnosis(), new Lastresort(), new Spite(), new Tailwhip() };
		public override int Weight => 42;
		public override int ExpYield => 58;
		public override int CatchRate => 255;
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