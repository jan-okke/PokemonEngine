using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Glameow : Pokemon
	{
		public override string Name => "Glameow";
		public override List<Ability> AvailableAbilities => new() {new Limber(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Keeneye() };
		public override Stats BaseStats => new Stats(49, 55, 42, 85, 42, 37);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fakeout() },
			[5] = new List<Move>() { new Scratch() },
			[8] = new List<Move>() { new Growl() },
			[13] = new List<Move>() { new Hypnosis() },
			[17] = new List<Move>() { new Aerialace() },
			[20] = new List<Move>() { new Furyswipes() },
			[25] = new List<Move>() { new Charm() },
			[29] = new List<Move>() { new Taunt() },
			[32] = new List<Move>() { new Retaliate() },
			[37] = new List<Move>() { new Slash() },
			[41] = new List<Move>() { new Suckerpunch() },
			[44] = new List<Move>() { new Attract() },
			[48] = new List<Move>() { new Honeclaws() },
			[50] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Knockoff(), new Lastresort(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Torment(), new Uturn(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Bite(), new Faketears(), new Flail(), new Lastresort(), new Quickattack(), new Sandattack(), new Tailwhip() };
		public override int Weight => 39;
		public override int ExpYield => 62;
		public override int CatchRate => 190;
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