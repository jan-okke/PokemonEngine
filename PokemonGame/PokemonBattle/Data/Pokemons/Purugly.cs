using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Purugly : Pokemon
	{
		public override string Name => "Purugly";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(71, 82, 64, 64, 59, 112);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Swagger() },
			[1] = new List<Move>() { new Swagger(), new Fakeout(), new Scratch(), new Growl() },
			[5] = new List<Move>() { new Scratch() },
			[8] = new List<Move>() { new Growl() },
			[13] = new List<Move>() { new Hypnosis() },
			[17] = new List<Move>() { new Aerialace() },
			[20] = new List<Move>() { new Furyswipes() },
			[25] = new List<Move>() { new Charm() },
			[29] = new List<Move>() { new Taunt() },
			[32] = new List<Move>() { new Retaliate() },
			[37] = new List<Move>() { new Slash() },
			[45] = new List<Move>() { new Bodyslam() },
			[52] = new List<Move>() { new Attract() },
			[60] = new List<Move>() { new Honeclaws() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Knockoff(), new Lastresort(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Roar(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snatch(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Torment(), new Uturn(), new Waterpulse(), new Workup() };
		public override int Weight => 438;
		public override int ExpYield => 158;
		public override int CatchRate => 75;
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