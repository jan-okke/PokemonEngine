using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Piplup : Pokemon
	{
		public override string Name => "Piplup";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(53, 51, 53, 40, 61, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound() },
			[4] = new List<Move>() { new Growl() },
			[6] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Charm() },
			[15] = new List<Move>() { new Peck() },
			[18] = new List<Move>() { new Bubblebeam() },
			[22] = new List<Move>() { new Swagger() },
			[25] = new List<Move>() { new Furyattack() },
			[29] = new List<Move>() { new Brine() },
			[32] = new List<Move>() { new Whirlpool() },
			[36] = new List<Move>() { new Mist() },
			[39] = new List<Move>() { new Drillpeck() },
			[43] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Brickbreak(), new Brine(), new Confide(), new Covet(), new Cut(), new Defog(), new Dig(), new Dive(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Fling(), new Frustration(), new Grassknot(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Pluck(), new Protect(), new Quash(), new Raindance(), new Rest(), new Return(), new Rocktomb(), new Round(), new Scald(), new Signalbeam(), new Sleeptalk(), new Snore(), new Stealthrock(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Aquaring(), new Doublehit(), new Featherdance(), new Flail(), new Hydropump(), new Icywind(), new Mudslap(), new Snore(), new Supersonic(), new Yawn() };
		public override int Weight => 52;
		public override int ExpYield => 63;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}